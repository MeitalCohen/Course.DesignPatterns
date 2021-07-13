
namespace BasicFacebookFeatures
{
    partial class EventSettingsForm
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
            this.chckLstBxEventStatus = new System.Windows.Forms.CheckedListBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chckLstBxFriendLst = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chckBxFBEventOption = new System.Windows.Forms.CheckBox();
            this.chckBxFriendLstOption = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chckLstBxEventStatus
            // 
            this.chckLstBxEventStatus.FormattingEnabled = true;
            this.chckLstBxEventStatus.Location = new System.Drawing.Point(95, 121);
            this.chckLstBxEventStatus.Name = "chckLstBxEventStatus";
            this.chckLstBxEventStatus.Size = new System.Drawing.Size(120, 94);
            this.chckLstBxEventStatus.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(70, 350);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Friends List";
            // 
            // chckLstBxFriendLst
            // 
            this.chckLstBxFriendLst.FormattingEnabled = true;
            this.chckLstBxFriendLst.Location = new System.Drawing.Point(95, 236);
            this.chckLstBxFriendLst.Name = "chckLstBxFriendLst";
            this.chckLstBxFriendLst.Size = new System.Drawing.Size(120, 94);
            this.chckLstBxFriendLst.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Event Type";
            // 
            // chckBxFBEventOption
            // 
            this.chckBxFBEventOption.AutoSize = true;
            this.chckBxFBEventOption.Location = new System.Drawing.Point(95, 49);
            this.chckBxFBEventOption.Name = "chckBxFBEventOption";
            this.chckBxFBEventOption.Size = new System.Drawing.Size(70, 17);
            this.chckBxFBEventOption.TabIndex = 8;
            this.chckBxFBEventOption.Text = "FB Event";
            this.chckBxFBEventOption.UseVisualStyleBackColor = true;
            this.chckBxFBEventOption.CheckedChanged += new System.EventHandler(this.chckBxFBEventOption_CheckedChanged);
            // 
            // chckBxFriendLstOption
            // 
            this.chckBxFriendLstOption.AutoSize = true;
            this.chckBxFriendLstOption.Location = new System.Drawing.Point(95, 72);
            this.chckBxFriendLstOption.Name = "chckBxFriendLstOption";
            this.chckBxFriendLstOption.Size = new System.Drawing.Size(107, 17);
            this.chckBxFriendLstOption.TabIndex = 9;
            this.chckBxFriendLstOption.Text = "Friends Birthhday";
            this.chckBxFriendLstOption.UseVisualStyleBackColor = true;
            this.chckBxFriendLstOption.CheckedChanged += new System.EventHandler(this.chckBxFriendLstOption_CheckedChanged);
            // 
            // EventSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 388);
            this.Controls.Add(this.chckBxFriendLstOption);
            this.Controls.Add(this.chckBxFBEventOption);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chckLstBxFriendLst);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.chckLstBxEventStatus);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventSettingsForm";
            this.ShowIcon = false;
            this.Text = "Events Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chckLstBxEventStatus;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox chckLstBxFriendLst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckBxFBEventOption;
        private System.Windows.Forms.CheckBox chckBxFriendLstOption;
    }
}