
namespace BasicFacebookFeatures
{
    partial class CreateCVForm
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnExtraData = new System.Windows.Forms.Button();
            this.btnSkills = new System.Windows.Forms.Button();
            this.btnEducation = new System.Windows.Forms.Button();
            this.btnExperience = new System.Windows.Forms.Button();
            this.btnGeneralInfo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnNext);
            this.splitContainer1.Panel1.Controls.Add(this.btnExtraData);
            this.splitContainer1.Panel1.Controls.Add(this.btnSkills);
            this.splitContainer1.Panel1.Controls.Add(this.btnEducation);
            this.splitContainer1.Panel1.Controls.Add(this.btnExperience);
            this.splitContainer1.Panel1.Controls.Add(this.btnGeneralInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 593);
            this.splitContainer1.SplitterDistance = 191;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnNext
            // 
            this.btnNext.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnNext.Location = new System.Drawing.Point(3, 536);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(185, 35);
            this.btnNext.TabIndex = 5;
            this.btnNext.Text = "Done";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnExtraData
            // 
            this.btnExtraData.Location = new System.Drawing.Point(4, 318);
            this.btnExtraData.Name = "btnExtraData";
            this.btnExtraData.Size = new System.Drawing.Size(185, 35);
            this.btnExtraData.TabIndex = 4;
            this.btnExtraData.Text = "Extra Data";
            this.btnExtraData.UseVisualStyleBackColor = true;
            this.btnExtraData.Click += new System.EventHandler(this.btnExtraData_Click);
            // 
            // btnSkills
            // 
            this.btnSkills.Location = new System.Drawing.Point(4, 277);
            this.btnSkills.Name = "btnSkills";
            this.btnSkills.Size = new System.Drawing.Size(185, 35);
            this.btnSkills.TabIndex = 3;
            this.btnSkills.Text = "Skills";
            this.btnSkills.UseVisualStyleBackColor = true;
            this.btnSkills.Click += new System.EventHandler(this.btnSkills_Click);
            // 
            // btnEducation
            // 
            this.btnEducation.Location = new System.Drawing.Point(4, 236);
            this.btnEducation.Name = "btnEducation";
            this.btnEducation.Size = new System.Drawing.Size(185, 35);
            this.btnEducation.TabIndex = 2;
            this.btnEducation.Text = "Education";
            this.btnEducation.UseVisualStyleBackColor = true;
            this.btnEducation.Click += new System.EventHandler(this.btnEducation_Click);
            // 
            // btnExperience
            // 
            this.btnExperience.Location = new System.Drawing.Point(4, 195);
            this.btnExperience.Name = "btnExperience";
            this.btnExperience.Size = new System.Drawing.Size(185, 35);
            this.btnExperience.TabIndex = 1;
            this.btnExperience.Text = "Work Experience";
            this.btnExperience.UseVisualStyleBackColor = true;
            this.btnExperience.Click += new System.EventHandler(this.btnExperience_Click);
            // 
            // btnGeneralInfo
            // 
            this.btnGeneralInfo.Location = new System.Drawing.Point(4, 154);
            this.btnGeneralInfo.Name = "btnGeneralInfo";
            this.btnGeneralInfo.Size = new System.Drawing.Size(185, 35);
            this.btnGeneralInfo.TabIndex = 0;
            this.btnGeneralInfo.Text = "General Info";
            this.btnGeneralInfo.UseVisualStyleBackColor = true;
            this.btnGeneralInfo.Click += new System.EventHandler(this.btnGeneralInfo_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 593);
            this.panel1.TabIndex = 0;
            // 
            // CreateCVForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.splitContainer1);
            this.Name = "CreateCVForm";
            this.Text = "CV Creator";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnExtraData;
        private System.Windows.Forms.Button btnSkills;
        private System.Windows.Forms.Button btnEducation;
        private System.Windows.Forms.Button btnExperience;
        private System.Windows.Forms.Button btnGeneralInfo;
        private System.Windows.Forms.Panel panel1;
    }
}