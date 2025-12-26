
namespace AntivirusApp
{
    partial class AntivirusForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnScan = new System.Windows.Forms.Button();
            this.lstLog = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnScan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnScan.ForeColor = System.Drawing.Color.White;
            this.btnScan.Location = new System.Drawing.Point(20, 70);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(150, 40);
            this.btnScan.TabIndex = 2;
            this.btnScan.Text = "Tarama Başlat";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // lstLog
            // 
            this.lstLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstLog.FormattingEnabled = true;
            this.lstLog.ItemHeight = 15;
            this.lstLog.Location = new System.Drawing.Point(20, 130);
            this.lstLog.Name = "lstLog";
            this.lstLog.Size = new System.Drawing.Size(440, 199);
            this.lstLog.TabIndex = 3;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(190, 85);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(84, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "Durum: Bekleniyor";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(360, 24);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(100, 23);
            this.btnSelectFolder.TabIndex = 1;
            this.btnSelectFolder.Text = "Gözat...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(20, 24);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.ReadOnly = true;
            this.txtFolderPath.Size = new System.Drawing.Size(330, 23);
            this.txtFolderPath.TabIndex = 0;
            this.txtFolderPath.Text = "C:\\FakeVirusTest";
            // 
            // AntivirusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.txtFolderPath);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lstLog);
            this.Controls.Add(this.btnScan);
            this.Name = "AntivirusForm";
            this.Text = "Basit Antivirüs Simülasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.ListBox lstLog;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}
