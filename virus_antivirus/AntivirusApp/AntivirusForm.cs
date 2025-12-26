using System;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace AntivirusApp
{
    public partial class AntivirusForm : Form
    {
        // Signature to look for
        private const string VirusSignature = "Azerbaijan virus";

        public AntivirusForm()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtFolderPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            string path = txtFolderPath.Text;

            if (!Directory.Exists(path))
            {
                MessageBox.Show("Seçilen klasör bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lstLog.Items.Clear();
            lstLog.Items.Add($"Tarama Başlatıldı: {DateTime.Now}");
            lstLog.Items.Add($"Hedef: {path}");
            lblStatus.Text = "Durum: Taranıyor...";
            lblStatus.ForeColor = Color.Orange;
            Application.DoEvents(); // Keep UI responsive

            try
            {
                string[] files = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
                int virusCount = 0;

                foreach (string file in files)
                {
                    try
                    {
                        // Check file content
                        string content = File.ReadAllText(file);
                        if (content.Contains(VirusSignature))
                        {
                            // Virus Found!
                            lstLog.Items.Add($"[TEHDİT BULUNDU] {file}");
                            
                            // Delete File
                            File.Delete(file);
                            lstLog.Items.Add($"[TEMİZLENDİ] Dosya silindi: {Path.GetFileName(file)}");
                            virusCount++;
                        }
                    }
                    catch (Exception ex)
                    {
                        lstLog.Items.Add($"[HATA] Dosya okunamadı: {Path.GetFileName(file)} - {ex.Message}");
                    }
                }

                if (virusCount > 0)
                {
                    lblStatus.Text = $"Tarama Tamamlandı. {virusCount} tehdit temizlendi.";
                    lblStatus.ForeColor = Color.Green;
                    MessageBox.Show($"Tarama tamamlandı!\n{virusCount} zararlı dosya bulundu ve temizlendi.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    lblStatus.Text = "Tarama Tamamlandı. Tehdit bulunamadı.";
                    lblStatus.ForeColor = Color.Green;
                    MessageBox.Show("Tarama tamamlandı. Sistem temiz.", "Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                lblStatus.Text = "Tarama Hatası";
                lblStatus.ForeColor = Color.Red;
                MessageBox.Show($"Tarama sırasında hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
