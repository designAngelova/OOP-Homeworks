namespace CompanyApp
{
    partial class BusinessReportForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.reports = new System.Windows.Forms.TreeView();
            this.reportInfo = new System.Windows.Forms.TextBox();
            this.exportToWordBtn = new System.Windows.Forms.Button();
            this.aboutBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "Import Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ImportData);
            // 
            // reports
            // 
            this.reports.CheckBoxes = true;
            this.reports.Location = new System.Drawing.Point(12, 72);
            this.reports.Name = "reports";
            this.reports.Size = new System.Drawing.Size(219, 228);
            this.reports.TabIndex = 1;
            this.reports.DrawNode += new System.Windows.Forms.DrawTreeNodeEventHandler(this.DrawReportNodes);
            this.reports.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.ShowReportInfo);
            // 
            // reportInfo
            // 
            this.reportInfo.Location = new System.Drawing.Point(257, 72);
            this.reportInfo.Multiline = true;
            this.reportInfo.Name = "reportInfo";
            this.reportInfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.reportInfo.Size = new System.Drawing.Size(373, 228);
            this.reportInfo.TabIndex = 2;
            // 
            // exportToWordBtn
            // 
            this.exportToWordBtn.Location = new System.Drawing.Point(169, 12);
            this.exportToWordBtn.Name = "exportToWordBtn";
            this.exportToWordBtn.Size = new System.Drawing.Size(140, 37);
            this.exportToWordBtn.TabIndex = 3;
            this.exportToWordBtn.Text = "Export To Word";
            this.exportToWordBtn.UseVisualStyleBackColor = true;
            this.exportToWordBtn.Click += new System.EventHandler(this.ExportReportsToWord);
            // 
            // aboutBtn
            // 
            this.aboutBtn.Location = new System.Drawing.Point(326, 12);
            this.aboutBtn.Name = "aboutBtn";
            this.aboutBtn.Size = new System.Drawing.Size(140, 37);
            this.aboutBtn.TabIndex = 4;
            this.aboutBtn.Text = "About";
            this.aboutBtn.UseVisualStyleBackColor = true;
            this.aboutBtn.Click += new System.EventHandler(this.ShowAboutWindow);
            // 
            // BusinessReportForm
            // 
            this.AccessibleDescription = "Business Report";
            this.AccessibleName = "reports";
            this.ClientSize = new System.Drawing.Size(654, 322);
            this.Controls.Add(this.aboutBtn);
            this.Controls.Add(this.exportToWordBtn);
            this.Controls.Add(this.reportInfo);
            this.Controls.Add(this.reports);
            this.Controls.Add(this.button1);
            this.Name = "BusinessReportForm";
            this.Text = "Business Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TreeView reports;
        private System.Windows.Forms.TextBox reportInfo;
        private System.Windows.Forms.Button exportToWordBtn;
        private System.Windows.Forms.Button aboutBtn;
    }
}