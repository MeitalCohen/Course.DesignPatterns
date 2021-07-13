
namespace BasicFacebookFeatures
{
    partial class CVPreview
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
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblUrl = new System.Windows.Forms.Label();
            this.lblJobDescription = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnTips = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblName.Location = new System.Drawing.Point(13, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(150, 26);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Lorem ipsum";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblEmail.Location = new System.Drawing.Point(434, 22);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(192, 15);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Lorem ipsum@Lorem ipsum.com";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(434, 46);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(80, 15);
            this.lblPhoneNumber.TabIndex = 2;
            this.lblPhoneNumber.Text = "Lorem ipsum";
            // 
            // lblUrl
            // 
            this.lblUrl.AutoSize = true;
            this.lblUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblUrl.Location = new System.Drawing.Point(434, 71);
            this.lblUrl.Name = "lblUrl";
            this.lblUrl.Size = new System.Drawing.Size(189, 15);
            this.lblUrl.TabIndex = 3;
            this.lblUrl.Text = "Lorem ipsum//:Lorem ipsum.com";
            // 
            // lblJobDescription
            // 
            this.lblJobDescription.AutoSize = true;
            this.lblJobDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblJobDescription.Location = new System.Drawing.Point(17, 62);
            this.lblJobDescription.Name = "lblJobDescription";
            this.lblJobDescription.Size = new System.Drawing.Size(123, 22);
            this.lblJobDescription.TabIndex = 11;
            this.lblJobDescription.Text = "Lorem ipsum";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(962, 14);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 23);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Update CV";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnTips
            // 
            this.btnTips.Location = new System.Drawing.Point(962, 46);
            this.btnTips.Name = "btnTips";
            this.btnTips.Size = new System.Drawing.Size(104, 23);
            this.btnTips.TabIndex = 14;
            this.btnTips.Text = "Tips";
            this.btnTips.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(962, 79);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(104, 23);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblEmail);
            this.splitContainer1.Panel1.Controls.Add(this.lblPhoneNumber);
            this.splitContainer1.Panel1.Controls.Add(this.btnBack);
            this.splitContainer1.Panel1.Controls.Add(this.lblUrl);
            this.splitContainer1.Size = new System.Drawing.Size(1078, 823);
            this.splitContainer1.SplitterDistance = 115;
            this.splitContainer1.TabIndex = 19;
            // 
            // CVPreview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 823);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnTips);
            this.Controls.Add(this.lblJobDescription);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CVPreview";
            this.Text = "CV Preview";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblUrl;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblJobDescription;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnTips;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.SplitContainer splitContainer1;
    }
}