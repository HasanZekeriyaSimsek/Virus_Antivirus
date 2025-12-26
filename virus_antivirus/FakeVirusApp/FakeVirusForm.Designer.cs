
namespace FakeVirusApp
{
    partial class FakeVirusForm
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
            this.btnRunVirus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRunVirus
            // 
            this.btnRunVirus.BackColor = System.Drawing.Color.Red;
            this.btnRunVirus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRunVirus.ForeColor = System.Drawing.Color.White;
            this.btnRunVirus.Location = new System.Drawing.Point(50, 50);
            this.btnRunVirus.Name = "btnRunVirus";
            this.btnRunVirus.Size = new System.Drawing.Size(200, 60);
            this.btnRunVirus.TabIndex = 0;
            this.btnRunVirus.Text = "Virüs Çalıştır";
            this.btnRunVirus.UseVisualStyleBackColor = false;
            this.btnRunVirus.Click += new System.EventHandler(this.btnRunVirus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 130);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 15);
            this.lblStatus.TabIndex = 1;
            // 
            // FakeVirusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 200);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnRunVirus);
            this.Name = "FakeVirusForm";
            this.Text = "Sahte Virüs Simülasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRunVirus;
        private System.Windows.Forms.Label lblStatus;
    }
}
