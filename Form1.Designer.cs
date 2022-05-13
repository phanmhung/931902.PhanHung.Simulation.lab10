namespace Simulation.Lab._10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.grid_match_results = new System.Windows.Forms.DataGridView();
            this.grid_team_lambda = new System.Windows.Forms.DataGridView();
            this.clmn_team = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid_team_points = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_draw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmn_lose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_rnd_teams = new System.Windows.Forms.Button();
            this.btn_next_round = new System.Windows.Forms.Button();
            this.lbl_rounds = new System.Windows.Forms.Label();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_match_results)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_team_lambda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_team_points)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_match_results
            // 
            this.grid_match_results.AllowUserToAddRows = false;
            this.grid_match_results.AllowUserToDeleteRows = false;
            this.grid_match_results.AllowUserToResizeColumns = false;
            this.grid_match_results.AllowUserToResizeRows = false;
            this.grid_match_results.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_match_results.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_match_results.Location = new System.Drawing.Point(18, 12);
            this.grid_match_results.Name = "grid_match_results";
            this.grid_match_results.ReadOnly = true;
            this.grid_match_results.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_match_results.Size = new System.Drawing.Size(436, 298);
            this.grid_match_results.TabIndex = 102;
            // 
            // grid_team_lambda
            // 
            this.grid_team_lambda.AllowUserToAddRows = false;
            this.grid_team_lambda.AllowUserToDeleteRows = false;
            this.grid_team_lambda.AllowUserToResizeColumns = false;
            this.grid_team_lambda.AllowUserToResizeRows = false;
            this.grid_team_lambda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_team_lambda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_team_lambda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmn_team,
            this.clmn});
            this.grid_team_lambda.Location = new System.Drawing.Point(820, 12);
            this.grid_team_lambda.Name = "grid_team_lambda";
            this.grid_team_lambda.ReadOnly = true;
            this.grid_team_lambda.RowHeadersVisible = false;
            this.grid_team_lambda.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_team_lambda.Size = new System.Drawing.Size(180, 298);
            this.grid_team_lambda.TabIndex = 103;
            // 
            // clmn_team
            // 
            this.clmn_team.HeaderText = "Team";
            this.clmn_team.MinimumWidth = 6;
            this.clmn_team.Name = "clmn_team";
            this.clmn_team.ReadOnly = true;
            // 
            // clmn
            // 
            this.clmn.HeaderText = "Lambda";
            this.clmn.MinimumWidth = 6;
            this.clmn.Name = "clmn";
            this.clmn.ReadOnly = true;
            // 
            // grid_team_points
            // 
            this.grid_team_points.AllowUserToAddRows = false;
            this.grid_team_points.AllowUserToDeleteRows = false;
            this.grid_team_points.AllowUserToResizeColumns = false;
            this.grid_team_points.AllowUserToResizeRows = false;
            this.grid_team_points.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_team_points.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_team_points.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.clmn_points,
            this.clmn_win,
            this.clmn_draw,
            this.clmn_lose});
            this.grid_team_points.Location = new System.Drawing.Point(460, 12);
            this.grid_team_points.Name = "grid_team_points";
            this.grid_team_points.ReadOnly = true;
            this.grid_team_points.RowHeadersVisible = false;
            this.grid_team_points.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.grid_team_points.Size = new System.Drawing.Size(354, 298);
            this.grid_team_points.TabIndex = 104;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Team";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // clmn_points
            // 
            this.clmn_points.HeaderText = "Points";
            this.clmn_points.MinimumWidth = 6;
            this.clmn_points.Name = "clmn_points";
            this.clmn_points.ReadOnly = true;
            // 
            // clmn_win
            // 
            this.clmn_win.HeaderText = "Win";
            this.clmn_win.MinimumWidth = 6;
            this.clmn_win.Name = "clmn_win";
            this.clmn_win.ReadOnly = true;
            // 
            // clmn_draw
            // 
            this.clmn_draw.HeaderText = "Draw";
            this.clmn_draw.MinimumWidth = 6;
            this.clmn_draw.Name = "clmn_draw";
            this.clmn_draw.ReadOnly = true;
            // 
            // clmn_lose
            // 
            this.clmn_lose.HeaderText = "Lose";
            this.clmn_lose.MinimumWidth = 6;
            this.clmn_lose.Name = "clmn_lose";
            this.clmn_lose.ReadOnly = true;
            // 
            // btn_rnd_teams
            // 
            this.btn_rnd_teams.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btn_rnd_teams.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rnd_teams.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_rnd_teams.Location = new System.Drawing.Point(820, 317);
            this.btn_rnd_teams.Name = "btn_rnd_teams";
            this.btn_rnd_teams.Size = new System.Drawing.Size(180, 43);
            this.btn_rnd_teams.TabIndex = 105;
            this.btn_rnd_teams.Text = "Create teams";
            this.btn_rnd_teams.UseVisualStyleBackColor = false;
            this.btn_rnd_teams.Click += new System.EventHandler(this.btn_rnd_teams_Click);
            // 
            // btn_next_round
            // 
            this.btn_next_round.BackColor = System.Drawing.SystemColors.Info;
            this.btn_next_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_next_round.Location = new System.Drawing.Point(12, 316);
            this.btn_next_round.Name = "btn_next_round";
            this.btn_next_round.Size = new System.Drawing.Size(158, 58);
            this.btn_next_round.TabIndex = 106;
            this.btn_next_round.Text = "Next round";
            this.btn_next_round.UseVisualStyleBackColor = false;
            this.btn_next_round.Visible = false;
            this.btn_next_round.Click += new System.EventHandler(this.btn_next_round_Click);
            // 
            // lbl_rounds
            // 
            this.lbl_rounds.AutoSize = true;
            this.lbl_rounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_rounds.Location = new System.Drawing.Point(185, 335);
            this.lbl_rounds.Name = "lbl_rounds";
            this.lbl_rounds.Size = new System.Drawing.Size(104, 20);
            this.lbl_rounds.TabIndex = 107;
            this.lbl_rounds.Text = "Round: 0 / 14";
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_reset.Enabled = false;
            this.btn_reset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_reset.Location = new System.Drawing.Point(295, 328);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(85, 35);
            this.btn_reset.TabIndex = 108;
            this.btn_reset.Text = "Restart";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_start.Enabled = false;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_start.Location = new System.Drawing.Point(12, 316);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(158, 58);
            this.btn_start.TabIndex = 109;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 452);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_rounds);
            this.Controls.Add(this.btn_next_round);
            this.Controls.Add(this.btn_rnd_teams);
            this.Controls.Add(this.grid_team_points);
            this.Controls.Add(this.grid_team_lambda);
            this.Controls.Add(this.grid_match_results);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grid_match_results)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_team_lambda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_team_points)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_match_results;
        private System.Windows.Forms.DataGridView grid_team_lambda;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_team;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn;
        private System.Windows.Forms.DataGridView grid_team_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_points;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_win;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_draw;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmn_lose;
        private System.Windows.Forms.Button btn_rnd_teams;
        private System.Windows.Forms.Button btn_next_round;
        private System.Windows.Forms.Label lbl_rounds;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_start;
    }
}

