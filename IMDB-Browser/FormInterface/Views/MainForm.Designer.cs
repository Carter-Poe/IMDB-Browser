namespace FormInterface.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_toolstrip = new System.Windows.Forms.Panel();
            this.pnl_settings = new System.Windows.Forms.Panel();
            this.pb_settings = new System.Windows.Forms.PictureBox();
            this.pnl_calender = new System.Windows.Forms.Panel();
            this.pb_calender = new System.Windows.Forms.PictureBox();
            this.lbl_calender = new System.Windows.Forms.Label();
            this.pnl_browse = new System.Windows.Forms.Panel();
            this.pb_browse = new System.Windows.Forms.PictureBox();
            this.lbl_browse = new System.Windows.Forms.Label();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.pb_dashboard = new System.Windows.Forms.PictureBox();
            this.lbl_dashboard = new System.Windows.Forms.Label();
            this.pnl_toolstrip.SuspendLayout();
            this.pnl_settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).BeginInit();
            this.pnl_calender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calender)).BeginInit();
            this.pnl_browse.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_browse)).BeginInit();
            this.pnl_dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_toolstrip
            // 
            this.pnl_toolstrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(34)))));
            this.pnl_toolstrip.Controls.Add(this.pnl_settings);
            this.pnl_toolstrip.Controls.Add(this.pnl_calender);
            this.pnl_toolstrip.Controls.Add(this.pnl_browse);
            this.pnl_toolstrip.Controls.Add(this.pnl_dashboard);
            this.pnl_toolstrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_toolstrip.Location = new System.Drawing.Point(0, 0);
            this.pnl_toolstrip.Name = "pnl_toolstrip";
            this.pnl_toolstrip.Size = new System.Drawing.Size(831, 37);
            this.pnl_toolstrip.TabIndex = 0;
            // 
            // pnl_settings
            // 
            this.pnl_settings.Controls.Add(this.pb_settings);
            this.pnl_settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_settings.Location = new System.Drawing.Point(793, 0);
            this.pnl_settings.Name = "pnl_settings";
            this.pnl_settings.Size = new System.Drawing.Size(38, 37);
            this.pnl_settings.TabIndex = 4;
            // 
            // pb_settings
            // 
            this.pb_settings.BackgroundImage = global::FormInterface.Properties.Resources.baseline_settings_white_24dp;
            this.pb_settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_settings.Location = new System.Drawing.Point(7, 7);
            this.pb_settings.Name = "pb_settings";
            this.pb_settings.Size = new System.Drawing.Size(23, 23);
            this.pb_settings.TabIndex = 1;
            this.pb_settings.TabStop = false;
            // 
            // pnl_calender
            // 
            this.pnl_calender.Controls.Add(this.pb_calender);
            this.pnl_calender.Controls.Add(this.lbl_calender);
            this.pnl_calender.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_calender.Location = new System.Drawing.Point(278, 0);
            this.pnl_calender.Name = "pnl_calender";
            this.pnl_calender.Size = new System.Drawing.Size(139, 37);
            this.pnl_calender.TabIndex = 3;
            // 
            // pb_calender
            // 
            this.pb_calender.BackgroundImage = global::FormInterface.Properties.Resources.baseline_calendar_today_white_24dp;
            this.pb_calender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_calender.Location = new System.Drawing.Point(8, 7);
            this.pb_calender.Name = "pb_calender";
            this.pb_calender.Size = new System.Drawing.Size(23, 23);
            this.pb_calender.TabIndex = 1;
            this.pb_calender.TabStop = false;
            // 
            // lbl_calender
            // 
            this.lbl_calender.AutoSize = true;
            this.lbl_calender.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_calender.ForeColor = System.Drawing.Color.White;
            this.lbl_calender.Location = new System.Drawing.Point(36, 7);
            this.lbl_calender.Name = "lbl_calender";
            this.lbl_calender.Size = new System.Drawing.Size(83, 22);
            this.lbl_calender.TabIndex = 1;
            this.lbl_calender.Text = "Calender";
            // 
            // pnl_browse
            // 
            this.pnl_browse.Controls.Add(this.pb_browse);
            this.pnl_browse.Controls.Add(this.lbl_browse);
            this.pnl_browse.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_browse.Location = new System.Drawing.Point(139, 0);
            this.pnl_browse.Name = "pnl_browse";
            this.pnl_browse.Size = new System.Drawing.Size(139, 37);
            this.pnl_browse.TabIndex = 2;
            // 
            // pb_browse
            // 
            this.pb_browse.BackgroundImage = global::FormInterface.Properties.Resources.baseline_explore_white_24dp;
            this.pb_browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_browse.Location = new System.Drawing.Point(8, 7);
            this.pb_browse.Name = "pb_browse";
            this.pb_browse.Size = new System.Drawing.Size(23, 23);
            this.pb_browse.TabIndex = 1;
            this.pb_browse.TabStop = false;
            // 
            // lbl_browse
            // 
            this.lbl_browse.AutoSize = true;
            this.lbl_browse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_browse.ForeColor = System.Drawing.Color.White;
            this.lbl_browse.Location = new System.Drawing.Point(36, 7);
            this.lbl_browse.Name = "lbl_browse";
            this.lbl_browse.Size = new System.Drawing.Size(70, 22);
            this.lbl_browse.TabIndex = 1;
            this.lbl_browse.Text = "Browse";
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.Controls.Add(this.pb_dashboard);
            this.pnl_dashboard.Controls.Add(this.lbl_dashboard);
            this.pnl_dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_dashboard.Location = new System.Drawing.Point(0, 0);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(139, 37);
            this.pnl_dashboard.TabIndex = 1;
            // 
            // pb_dashboard
            // 
            this.pb_dashboard.BackgroundImage = global::FormInterface.Properties.Resources.baseline_dashboard_white_24dp;
            this.pb_dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_dashboard.Location = new System.Drawing.Point(8, 7);
            this.pb_dashboard.Name = "pb_dashboard";
            this.pb_dashboard.Size = new System.Drawing.Size(23, 23);
            this.pb_dashboard.TabIndex = 1;
            this.pb_dashboard.TabStop = false;
            // 
            // lbl_dashboard
            // 
            this.lbl_dashboard.AutoSize = true;
            this.lbl_dashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_dashboard.ForeColor = System.Drawing.Color.White;
            this.lbl_dashboard.Location = new System.Drawing.Point(36, 7);
            this.lbl_dashboard.Name = "lbl_dashboard";
            this.lbl_dashboard.Size = new System.Drawing.Size(98, 22);
            this.lbl_dashboard.TabIndex = 1;
            this.lbl_dashboard.Text = "Dashboard";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(831, 523);
            this.Controls.Add(this.pnl_toolstrip);
            this.Name = "MainForm";
            this.Text = "IMDB Notifier";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_toolstrip.ResumeLayout(false);
            this.pnl_settings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_settings)).EndInit();
            this.pnl_calender.ResumeLayout(false);
            this.pnl_calender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_calender)).EndInit();
            this.pnl_browse.ResumeLayout(false);
            this.pnl_browse.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_browse)).EndInit();
            this.pnl_dashboard.ResumeLayout(false);
            this.pnl_dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_dashboard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_toolstrip;
        private Panel pnl_settings;
        private PictureBox pb_settings;
        private Panel pnl_calender;
        private PictureBox pb_calender;
        private Label lbl_calender;
        private Panel pnl_browse;
        private PictureBox pb_browse;
        private Label lbl_browse;
        private Panel pnl_dashboard;
        private PictureBox pb_dashboard;
        private Label lbl_dashboard;
    }
}