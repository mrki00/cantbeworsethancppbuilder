
namespace cantbeworsethancppbuilder
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.LastLoginDateTimeLabel = new System.Windows.Forms.Label();
            this.frm3 = new System.Windows.Forms.Button();
            this.locationL = new System.Windows.Forms.Label();
            this.ManageUsersB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LastLoginDateTimeLabel
            // 
            resources.ApplyResources(this.LastLoginDateTimeLabel, "LastLoginDateTimeLabel");
            this.LastLoginDateTimeLabel.Name = "LastLoginDateTimeLabel";
            this.LastLoginDateTimeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // frm3
            // 
            resources.ApplyResources(this.frm3, "frm3");
            this.frm3.Name = "frm3";
            this.frm3.UseVisualStyleBackColor = true;
            this.frm3.Click += new System.EventHandler(this.frm3_Click);
            // 
            // locationL
            // 
            resources.ApplyResources(this.locationL, "locationL");
            this.locationL.Name = "locationL";
            // 
            // ManageUsersB
            // 
            resources.ApplyResources(this.ManageUsersB, "ManageUsersB");
            this.ManageUsersB.Name = "ManageUsersB";
            this.ManageUsersB.UseVisualStyleBackColor = true;
            this.ManageUsersB.Click += new System.EventHandler(this.ManageUsersB_Click);
            // 
            // Form2
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ManageUsersB);
            this.Controls.Add(this.locationL);
            this.Controls.Add(this.frm3);
            this.Controls.Add(this.LastLoginDateTimeLabel);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LastLoginDateTimeLabel;
        private System.Windows.Forms.Button frm3;
        private System.Windows.Forms.Label locationL;
        private System.Windows.Forms.Button ManageUsersB;
    }
}