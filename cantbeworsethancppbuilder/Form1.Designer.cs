
namespace cantbeworsethancppbuilder
{
    partial class Form1
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
            this.loginB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userT = new System.Windows.Forms.TextBox();
            this.passT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // loginB
            // 
            this.loginB.Location = new System.Drawing.Point(180, 185);
            this.loginB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginB.Name = "loginB";
            this.loginB.Size = new System.Drawing.Size(100, 28);
            this.loginB.TabIndex = 0;
            this.loginB.Text = "Login";
            this.loginB.UseVisualStyleBackColor = true;
            this.loginB.Click += new System.EventHandler(this.loginB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "password";
            // 
            // userT
            // 
            this.userT.Location = new System.Drawing.Point(147, 54);
            this.userT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userT.Name = "userT";
            this.userT.Size = new System.Drawing.Size(132, 22);
            this.userT.TabIndex = 3;
            // 
            // passT
            // 
            this.passT.Location = new System.Drawing.Point(147, 112);
            this.passT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passT.Name = "passT";
            this.passT.Size = new System.Drawing.Size(132, 22);
            this.passT.TabIndex = 4;
            this.passT.TextChanged += new System.EventHandler(this.passT_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 282);
            this.Controls.Add(this.passT);
            this.Controls.Add(this.userT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passT;
        public System.Windows.Forms.TextBox userT;
    }
}

