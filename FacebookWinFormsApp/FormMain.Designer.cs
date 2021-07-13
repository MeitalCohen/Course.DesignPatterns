namespace BasicFacebookFeatures
{
    partial class FormMain
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
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.listBoxEvents = new System.Windows.Forms.ListBox();
            this.calenderEvent = new System.Windows.Forms.MonthCalendar();
            this.btnEvents = new System.Windows.Forms.Button();
            this.picBoxProfile = new System.Windows.Forms.PictureBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnFilterEvents = new System.Windows.Forms.Button();
            this.btnClearEvent = new System.Windows.Forms.Button();
            this.btnActivity = new System.Windows.Forms.Button();
            this.btnStatus = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(352, 182);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(179, 23);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(352, 211);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(179, 23);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // listBoxEvents
            // 
            this.listBoxEvents.FormattingEnabled = true;
            this.listBoxEvents.Location = new System.Drawing.Point(18, 506);
            this.listBoxEvents.Name = "listBoxEvents";
            this.listBoxEvents.Size = new System.Drawing.Size(227, 264);
            this.listBoxEvents.TabIndex = 53;
            // 
            // calenderEvent
            // 
            this.calenderEvent.Location = new System.Drawing.Point(18, 286);
            this.calenderEvent.MaxSelectionCount = 20;
            this.calenderEvent.Name = "calenderEvent";
            this.calenderEvent.TabIndex = 56;
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(60, 460);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(138, 23);
            this.btnEvents.TabIndex = 57;
            this.btnEvents.Text = "Display Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // picBoxProfile
            // 
            this.picBoxProfile.Location = new System.Drawing.Point(353, 31);
            this.picBoxProfile.Name = "picBoxProfile";
            this.picBoxProfile.Size = new System.Drawing.Size(178, 145);
            this.picBoxProfile.TabIndex = 60;
            this.picBoxProfile.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(185, 251);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(60, 23);
            this.btnRefresh.TabIndex = 62;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // btnFilterEvents
            // 
            this.btnFilterEvents.Location = new System.Drawing.Point(18, 251);
            this.btnFilterEvents.Name = "btnFilterEvents";
            this.btnFilterEvents.Size = new System.Drawing.Size(57, 23);
            this.btnFilterEvents.TabIndex = 64;
            this.btnFilterEvents.Text = "Filter";
            this.btnFilterEvents.UseVisualStyleBackColor = true;
            this.btnFilterEvents.Click += new System.EventHandler(this.btnFilterEvents_Click);
            // 
            // btnClearEvent
            // 
            this.btnClearEvent.Location = new System.Drawing.Point(102, 251);
            this.btnClearEvent.Name = "btnClearEvent";
            this.btnClearEvent.Size = new System.Drawing.Size(60, 23);
            this.btnClearEvent.TabIndex = 65;
            this.btnClearEvent.Text = "Clear";
            this.btnClearEvent.UseVisualStyleBackColor = true;
            this.btnClearEvent.Click += new System.EventHandler(this.btnClearEvent_Click);
            // 
            // btnActivity
            // 
            this.btnActivity.Location = new System.Drawing.Point(712, 242);
            this.btnActivity.Name = "btnActivity";
            this.btnActivity.Size = new System.Drawing.Size(118, 23);
            this.btnActivity.TabIndex = 66;
            this.btnActivity.Text = "History Activity";
            this.btnActivity.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            this.btnStatus.Location = new System.Drawing.Point(712, 286);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(118, 23);
            this.btnStatus.TabIndex = 67;
            this.btnStatus.Text = "Status Activity";
            this.btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnJob
            // 
            this.btnJob.Location = new System.Drawing.Point(712, 327);
            this.btnJob.Name = "btnJob";
            this.btnJob.Size = new System.Drawing.Size(118, 23);
            this.btnJob.TabIndex = 68;
            this.btnJob.Text = "Job Status";
            this.btnJob.UseVisualStyleBackColor = true;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUserName.Location = new System.Drawing.Point(303, 266);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(169, 31);
            this.lblUserName.TabIndex = 69;
            this.lblUserName.Text = "Lorem ipsum";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblStatus.Location = new System.Drawing.Point(303, 327);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(120, 24);
            this.lblStatus.TabIndex = 70;
            this.lblStatus.Text = "Lorem ipsum";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 891);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnStatus);
            this.Controls.Add(this.btnActivity);
            this.Controls.Add(this.btnClearEvent);
            this.Controls.Add(this.btnFilterEvents);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.picBoxProfile);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.calenderEvent);
            this.Controls.Add(this.listBoxEvents);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonLogin);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.ListBox listBoxEvents;
        private System.Windows.Forms.MonthCalendar calenderEvent;
        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.PictureBox picBoxProfile;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnFilterEvents;
        private System.Windows.Forms.Button btnClearEvent;
        private System.Windows.Forms.Button btnActivity;
        private System.Windows.Forms.Button btnStatus;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblStatus;
    }
}

