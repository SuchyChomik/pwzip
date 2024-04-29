using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using System;
using System.IO;
using System.Windows.Forms;
namespace pwzip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void browseZipButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Zip files (*.zip)|*.zip";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                zipTextBox.Text = openFileDialog.FileName;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dictionaryTextBox_TextChanged(object sender, EventArgs e)
        {

        }



        private void crackButton_Click(object sender, EventArgs e)
        {
            string zipFilePath = zipTextBox.Text;

            if (string.IsNullOrWhiteSpace(zipFilePath) || !File.Exists(zipFilePath))
            {
                MessageBox.Show("Please select a valid zip file.");
                return;
            }

            if (dictionaryRadioButton.Checked)
            {
                string dictionaryFilePath = dictionaryTextBox.Text;

                if (string.IsNullOrWhiteSpace(dictionaryFilePath) || !File.Exists(dictionaryFilePath))
                {
                    MessageBox.Show("Please select a valid dictionary file.");
                    return;
                }

                string[] passwords = File.ReadAllLines(dictionaryFilePath);

                using (ZipFile zipFile = new ZipFile(zipFilePath))
                {
                    foreach (string password in passwords)
                    {
                        zipFile.Password = password;

                        try
                        {
                            foreach (ZipEntry entry in zipFile)
                            {
                                using (Stream entryStream = zipFile.GetInputStream(entry))
                                {
                                    // Process entryStream here
                                }
                            }
                            MessageBox.Show($"Success! Password is: {password}");
                            return; // Found the password, no need to continue
                        }
                        catch (Exception)
                        {
                            // Wrong password, continue to next one
                            continue;
                        }
                    }

                    // If execution reaches here, no correct password was found
                    MessageBox.Show("No correct password found in the dictionary.");
                }
            }
            else if (bruteForceRadioButton.Checked)
            {
                // Implement brute force attack here
                MessageBox.Show("Brute force attack not implemented yet.");
            }
        }

        private void dictionaryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dictionaryTextBox.Enabled = dictionaryRadioButton.Checked;
            browseDictionaryButton.Enabled = dictionaryRadioButton.Checked;
        }

        private void browseDictionaryButton_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                dictionaryTextBox.Text = openFileDialog.FileName;
            }
        }

    }
}
