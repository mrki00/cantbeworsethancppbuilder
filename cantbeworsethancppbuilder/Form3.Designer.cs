
namespace cantbeworsethancppbuilder
{
    partial class Form3
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
            System.Windows.Forms.ColumnHeader url;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.urlT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.downloadB = new System.Windows.Forms.Button();
            this.atqT = new System.Windows.Forms.Button();
            this.rfqB = new System.Windows.Forms.Button();
            this.downloadqueueB = new System.Windows.Forms.Button();
            this.itqB = new System.Windows.Forms.Button();
            this.efqB = new System.Windows.Forms.Button();
            this.spb = new System.Windows.Forms.ProgressBar();
            this.percentageL = new System.Windows.Forms.Label();
            this.checksumL = new System.Windows.Forms.Label();
            this.checksumT = new System.Windows.Forms.TextBox();
            this.checkB = new System.Windows.Forms.Button();
            this.reportCB = new System.Windows.Forms.CheckBox();
            this.reportOptions = new System.Windows.Forms.ComboBox();
            url = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // url
            // 
            resources.ApplyResources(url, "url");
            // 
            // urlT
            // 
            resources.ApplyResources(this.urlT, "urlT");
            this.urlT.Name = "urlT";
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
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            url});
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // downloadB
            // 
            resources.ApplyResources(this.downloadB, "downloadB");
            this.downloadB.Name = "downloadB";
            this.downloadB.UseVisualStyleBackColor = true;
            this.downloadB.Click += new System.EventHandler(this.downloadB_Click);
            // 
            // atqT
            // 
            resources.ApplyResources(this.atqT, "atqT");
            this.atqT.Name = "atqT";
            this.atqT.UseVisualStyleBackColor = true;
            this.atqT.Click += new System.EventHandler(this.atqT_Click);
            // 
            // rfqB
            // 
            resources.ApplyResources(this.rfqB, "rfqB");
            this.rfqB.Name = "rfqB";
            this.rfqB.UseVisualStyleBackColor = true;
            this.rfqB.Click += new System.EventHandler(this.rfqB_Click);
            // 
            // downloadqueueB
            // 
            resources.ApplyResources(this.downloadqueueB, "downloadqueueB");
            this.downloadqueueB.Name = "downloadqueueB";
            this.downloadqueueB.UseVisualStyleBackColor = true;
            this.downloadqueueB.Click += new System.EventHandler(this.downloadqueueB_Click);
            // 
            // itqB
            // 
            resources.ApplyResources(this.itqB, "itqB");
            this.itqB.Name = "itqB";
            this.itqB.UseVisualStyleBackColor = true;
            this.itqB.Click += new System.EventHandler(this.itqB_Click);
            // 
            // efqB
            // 
            resources.ApplyResources(this.efqB, "efqB");
            this.efqB.Name = "efqB";
            this.efqB.UseVisualStyleBackColor = true;
            this.efqB.Click += new System.EventHandler(this.efqB_Click);
            // 
            // spb
            // 
            resources.ApplyResources(this.spb, "spb");
            this.spb.Name = "spb";
            // 
            // percentageL
            // 
            resources.ApplyResources(this.percentageL, "percentageL");
            this.percentageL.Name = "percentageL";
            // 
            // checksumL
            // 
            resources.ApplyResources(this.checksumL, "checksumL");
            this.checksumL.Name = "checksumL";
            this.checksumL.Click += new System.EventHandler(this.label3_Click);
            // 
            // checksumT
            // 
            resources.ApplyResources(this.checksumT, "checksumT");
            this.checksumT.Name = "checksumT";
            // 
            // checkB
            // 
            resources.ApplyResources(this.checkB, "checkB");
            this.checkB.Name = "checkB";
            this.checkB.UseVisualStyleBackColor = true;
            this.checkB.Click += new System.EventHandler(this.checkB_Click);
            // 
            // reportCB
            // 
            resources.ApplyResources(this.reportCB, "reportCB");
            this.reportCB.Name = "reportCB";
            this.reportCB.UseVisualStyleBackColor = true;
            // 
            // reportOptions
            // 
            resources.ApplyResources(this.reportOptions, "reportOptions");
            this.reportOptions.FormattingEnabled = true;
            this.reportOptions.Items.AddRange(new object[] {
            resources.GetString("reportOptions.Items"),
            resources.GetString("reportOptions.Items1")});
            this.reportOptions.Name = "reportOptions";
            // 
            // Form3
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportOptions);
            this.Controls.Add(this.reportCB);
            this.Controls.Add(this.checkB);
            this.Controls.Add(this.checksumT);
            this.Controls.Add(this.checksumL);
            this.Controls.Add(this.percentageL);
            this.Controls.Add(this.spb);
            this.Controls.Add(this.efqB);
            this.Controls.Add(this.itqB);
            this.Controls.Add(this.downloadqueueB);
            this.Controls.Add(this.rfqB);
            this.Controls.Add(this.atqT);
            this.Controls.Add(this.downloadB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.urlT);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox urlT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button downloadB;
        private System.Windows.Forms.Button atqT;
        private System.Windows.Forms.Button rfqB;
        private System.Windows.Forms.Button downloadqueueB;
        private System.Windows.Forms.Button itqB;
        private System.Windows.Forms.Button efqB;
        private System.Windows.Forms.ProgressBar spb;
        private System.Windows.Forms.Label percentageL;
        private System.Windows.Forms.Label checksumL;
        private System.Windows.Forms.TextBox checksumT;
        private System.Windows.Forms.Button checkB;
        private System.Windows.Forms.CheckBox reportCB;
        private System.Windows.Forms.ComboBox reportOptions;
    }
}