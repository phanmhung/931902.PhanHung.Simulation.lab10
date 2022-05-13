using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Simulation.Lab._10
{
    public partial class Form1 : Form
    {
        string[] teams = new string[8] { "T1", "T2", "T3", "T4", "T5", "T6", "T7", "T8" };
        int[] teams_id = new int[8] { 0, 1, 2, 3, 4, 5, 6, 7 };
        float[] team_lambda = new float[8];
        int[,] team_matches = new int[8, 8];
        int rounds = 1;

        Dictionary<string, Dictionary<string, int>> team_stat_name = new Dictionary<string, Dictionary<string, int>>();

        public Form1()
        {
            InitializeComponent();
        }

        private void main_diagonale_setter()
        {
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    if (i == j) team_matches[i, j] = 1;
        }

        private int[] teams_next_round_matches()
        {
            int[] teams_id_next = new int[8];
            int k = 0;
            int[] teams_temp = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < 8; i++)
            {
                if (teams_temp[i] == 0)
                    for (int j = 0; j < 8; j++)
                    {
                        if (team_matches[i, j] != 1 && teams_temp[j] == 0)
                        {
                            teams_id_next[k] = i;
                            teams_id_next[k + 1] = j;
                            k += 2;

                            team_matches[i, j] = 1;

                            teams_temp[i] = 1;
                            teams_temp[j] = 1;
                            break;
                        }
                    }
            }
            return teams_id_next;
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_rnd_teams_Click(object sender, EventArgs e)
        {
            if (btn_start.Enabled == false) btn_start.Enabled = true;
            grid_team_lambda.Rows.Clear();
            Random rnd = new Random();
            for (int i = 0; i < teams.Length; i++)
            {
                team_lambda[i] = (float)rnd.Next(1001) / 100;
                grid_team_lambda.Rows.Add(teams[i], team_lambda[i]);
            }
        }

        private void btn_next_round_Click(object sender, EventArgs e)
        {
            grid_team_points.ClearSelection();
            grid_team_lambda.ClearSelection();
            grid_match_results.ClearSelection();
            if (btn_reset.Enabled == false) btn_reset.Enabled = true;
            for (int i = 0; i < teams.Length; i++)
                for (int j = 0; j < teams.Length; j++)
                    grid_match_results[i, j].Style.BackColor = Color.White;

            lbl_rounds.Text = $"Round: {rounds}/14";

            Random rnd = new Random();
            int[] next_round = new int[8];
            next_round = teams_next_round_matches();

            for (int i = 0; i < teams.Length; i += 2)
            {
                int a = next_round[i];
                int b = next_round[i + 1];
                int goals_a = match(team_lambda[a]);
                int goals_b = match(team_lambda[b]);

                if (goals_a == goals_b)
                {
                    team_stat_name[teams[a]]["point"] += 1;
                    team_stat_name[teams[a]]["draw"] += 1;
                    team_stat_name[teams[b]]["point"] += 1;
                    team_stat_name[teams[b]]["draw"] += 1;
                }
                else if (goals_a > goals_b)
                {
                    team_stat_name[teams[a]]["point"] += 3;
                    team_stat_name[teams[a]]["win"] += 1;
                    team_stat_name[teams[b]]["lose"] += 1;
                }
                else
                {
                    team_stat_name[teams[a]]["lose"] += 1;
                    team_stat_name[teams[b]]["point"] += 3;
                    team_stat_name[teams[b]]["win"] += 1;
                }

                grid_match_results[b, a].Value = $"{goals_a} - {goals_b}";
                grid_match_results[b, a].Style.BackColor = Color.Green;
            }

            sort_dictionary();

            grid_team_points.Rows.Clear();

            foreach (var team in team_stat_name)
            {
                grid_team_points.Rows.Add(team.Key, team.Value["point"], team.Value["win"], team.Value["draw"], team.Value["lose"]);
            }

            if (rounds == 14)
            {
                btn_next_round.Enabled = false;
                grid_team_points.Rows[7].DefaultCellStyle.BackColor = Color.Gold;
                grid_team_points.Rows[6].DefaultCellStyle.BackColor = Color.Silver;
                grid_team_points.Rows[5].DefaultCellStyle.BackColor = Color.Brown;
            }
            rounds += 1;
            grid_team_points.ClearSelection();
            grid_team_lambda.ClearSelection();
            grid_match_results.ClearSelection();
        }

        private int match(double lambda)
        {
            int x = 0;
            double sum = 0;
            Random rnd = new Random();

            while (sum > -lambda)
            {
                sum += Math.Log(rnd.NextDouble());
                x++;
            }
            x -= 1;

            return x;
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            grid_team_points.ClearSelection();
            grid_team_lambda.ClearSelection();
            grid_match_results.ClearSelection();
            main_diagonale_setter();
            for (int i = 0; i < teams.Length; i++)
            {
                grid_match_results.Columns.Add(new DataGridViewColumn { HeaderText = teams[i], CellTemplate = new DataGridViewTextBoxCell() });
            }

            for (int i = 0; i < teams.Length; i++)
            {
                grid_match_results.Rows.Add();
                grid_match_results.Rows[i].HeaderCell = new DataGridViewRowHeaderCell { Value = teams[i] };
            }

            for (int i = 0; i < teams.Length; i++)
                for (int j = 0; j < teams.Length; j++)
                    if (i == j) grid_match_results[i, j].Value = "---";

            for (int i = 0; i < teams.Length; i++)
            {
                team_stat_name[teams[i]] = new Dictionary<string, int>()
                {
                    ["point"] = 0,
                    ["win"] = 0,
                    ["draw"] = 0,
                    ["lose"] = 0
                };
            }

            // Dictionary<string, int> team_stat_stat = 

            foreach (var team in team_stat_name)
            {
                grid_team_points.Rows.Add(team.Key, team.Value["point"], team.Value["win"], team.Value["draw"], team.Value["lose"]);
            }

            //for (int i = 0; i < teams.Length; i++) grid_team_points.Rows.Add(teams[i], "0", "0", "0", "0");

            btn_start.Visible = false;
            btn_next_round.Visible = true;
            btn_rnd_teams.Enabled = false;
        }

        private void sort_dictionary()
        {
            team_stat_name = team_stat_name.OrderBy(pair => pair.Value["point"]).ToDictionary(pair => pair.Key, pair => pair.Value);
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    }
}
