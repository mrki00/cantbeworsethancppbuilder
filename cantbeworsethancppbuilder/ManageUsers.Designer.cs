
namespace cantbeworsethancppbuilder
{
    partial class ManageUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers));
            this.usernameT = new System.Windows.Forms.TextBox();
            this.passT = new System.Windows.Forms.TextBox();
            this.repassT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.GoBackB = new System.Windows.Forms.Button();
            this.CreateUserB = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sha1RB = new System.Windows.Forms.RadioButton();
            this.aesRB = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.conT = new System.Windows.Forms.TextBox();
            this.DeleteUserB = new System.Windows.Forms.Button();
            this.RefreshB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameT
            // 
            resources.ApplyResources(this.usernameT, "usernameT");
            this.usernameT.Name = "usernameT";
            // 
            // passT
            // 
            resources.ApplyResources(this.passT, "passT");
            this.passT.Name = "passT";
            // 
            // repassT
            // 
            resources.ApplyResources(this.repassT, "repassT");
            this.repassT.Name = "repassT";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // GoBackB
            // 
            resources.ApplyResources(this.GoBackB, "GoBackB");
            this.GoBackB.Name = "GoBackB";
            this.GoBackB.UseVisualStyleBackColor = true;
            // 
            // CreateUserB
            // 
            resources.ApplyResources(this.CreateUserB, "CreateUserB");
            this.CreateUserB.Name = "CreateUserB";
            this.CreateUserB.UseVisualStyleBackColor = true;
            this.CreateUserB.Click += new System.EventHandler(this.CreateUserB_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // dataGridView1
            // 
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Name = "dataGridView1";
            // 
            // sha1RB
            // 
            resources.ApplyResources(this.sha1RB, "sha1RB");
            this.sha1RB.Checked = true;
            this.sha1RB.Name = "sha1RB";
            this.sha1RB.TabStop = true;
            this.sha1RB.UseVisualStyleBackColor = true;
            // 
            // aesRB
            // 
            resources.ApplyResources(this.aesRB, "aesRB");
            this.aesRB.Name = "aesRB";
            this.aesRB.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            resources.ApplyResources(this.comboBox1, "comboBox1");
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // conT
            // 
            resources.ApplyResources(this.conT, "conT");
            this.conT.Name = "conT";
            // 
            // DeleteUserB
            // 
            resources.ApplyResources(this.DeleteUserB, "DeleteUserB");
            this.DeleteUserB.Name = "DeleteUserB";
            this.DeleteUserB.UseVisualStyleBackColor = true;
            this.DeleteUserB.Click += new System.EventHandler(this.DeleteUserB_Click);
            // 
            // RefreshB
            // 
            resources.ApplyResources(this.RefreshB, "RefreshB");
            this.RefreshB.Name = "RefreshB";
            this.RefreshB.UseVisualStyleBackColor = true;
            this.RefreshB.Click += new System.EventHandler(this.RefreshB_Click);
            // 
            // ManageUsers
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RefreshB);
            this.Controls.Add(this.DeleteUserB);
            this.Controls.Add(this.conT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.aesRB);
            this.Controls.Add(this.sha1RB);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CreateUserB);
            this.Controls.Add(this.GoBackB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.repassT);
            this.Controls.Add(this.passT);
            this.Controls.Add(this.usernameT);
            this.Name = "ManageUsers";
            this.Load += new System.EventHandler(this.ManageUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameT;
        private System.Windows.Forms.TextBox passT;
        private System.Windows.Forms.TextBox repassT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button GoBackB;
        private System.Windows.Forms.Button CreateUserB;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton sha1RB;
        private System.Windows.Forms.RadioButton aesRB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox conT;
        private System.Windows.Forms.Button DeleteUserB;
        private System.Windows.Forms.Button RefreshB;
    }
}