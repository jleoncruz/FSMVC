using System;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FSWinApp
{
    public partial class MainForm : Form
    {
        #region

        private FolderBrowserDialog folderBrowserDialog;
        private int quantityPhotosAvailable;

        #endregion

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectFolderButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog = new FolderBrowserDialog();

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                SourceListBox.Items.Clear();
                FolderSelectedLabel.Text = folderBrowserDialog.SelectedPath;

                DirectoryInfo sourceDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                foreach (FileInfo fi in sourceDirectory.GetFiles())
                {
                    if (fi.Extension.ToLower() == ".jpg")
                    {
                        //SourceListBox.Items.Add(new ListViewItem(fi.FullName));
                        SourceListBox.Items.Add(fi.FullName);
                        //quantityPhotosAvailable++;
                    }
                }

                SourceListBox.HorizontalScrollbar = true;
                ConvertButton.Enabled = true;
            }
        }

        private void ConvertButton_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(folderBrowserDialog.SelectedPath)))
            {
                TargetListBox.Items.Clear();
                DirectoryInfo sourceDirectory = new DirectoryInfo(folderBrowserDialog.SelectedPath);

                quantityPhotosAvailable = 0;

                StringBuilder sbMessage = new StringBuilder();

                foreach (FileInfo fi in sourceDirectory.GetFiles())
                {
                    if (fi.Extension.ToLower() == ".jpg")
                    {
                        try
                        {
                            //TargetListBox.Items.Add(new ListViewItem(Utils.ResizeAndMovePhoto(fi.FullName, fi.Name)));
                            TargetListBox.Items.Add(Utils.ResizeAndMovePhoto(folderBrowserDialog.SelectedPath, fi.FullName, fi.Name));
                            quantityPhotosAvailable++;
                        }
                        catch (Exception ex)
                        {
                            sbMessage.AppendLine($"Error Converting Photo:{fi.FullName}:{ex.Message}");
                        }
                    }
                }

                if (sbMessage.ToString().Length > 0)
                {
                    MessageBox.Show(sbMessage.ToString(),
                        "Converting Photo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }

                if (quantityPhotosAvailable > 0)
                {
                    TargetListBox.HorizontalScrollbar = true;
                    AvailablePhotosLabel.Text = $"Total Photos Converted: {quantityPhotosAvailable}";
                }
            }
        }

        #region List Boxes

        private void SourceListBox_DoubleClick(object sender, EventArgs e)
        {
            if (SourceListBox.SelectedItem != null)
            {
                string currentItem = SourceListBox.SelectedItem.ToString();

                if (currentItem != null && currentItem.Length > 0)
                {
                    Utils.PreviewImage(currentItem);
                }
            }
        }

        private void TargetListBox_DoubleClick(object sender, EventArgs e)
        {
            if (TargetListBox.SelectedItem != null)
            {
                string targetItem = TargetListBox.SelectedItem.ToString();

                if (targetItem != null && targetItem.Length > 0)
                {
                    Utils.PreviewImage(targetItem);
                }
            }
        }

        #endregion
    }
}
