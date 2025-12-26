using System;
using System.IO;
using System.Windows.Forms;

namespace FakeVirusApp
{
    public partial class FakeVirusForm : Form
    {
        // Define directory and file paths
        private const string TargetDirectory = @"C:\FakeVirusTest";
        private const string TargetFileName = "evil_test.txt";
        // The harmless signature that identifies this "virus"
        private const string VirusSignature = "Hi, I am Azerbaijan virus, due to poor technology in my country I not able to damage your computer, please be kind enough to smash your computer with a hammer";

        public FakeVirusForm()
        {
            InitializeComponent();
        }

        private void btnRunVirus_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure the directory exists
                if (!Directory.Exists(TargetDirectory))
                {
                    Directory.CreateDirectory(TargetDirectory);
                }

                string fullPath = Path.Combine(TargetDirectory, TargetFileName);

                // Create the file with the signature
                File.WriteAllText(fullPath, VirusSignature);

                // Notify User
                lblStatus.Text = "Zararsız test virüsü çalıştırıldı!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                
                MessageBox.Show($"Dosya oluşturuldu:\n{fullPath}\n\nİçerik:\n{VirusSignature}", 
                                "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Error handling
                lblStatus.Text = "Hata oluştu!";
                lblStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
