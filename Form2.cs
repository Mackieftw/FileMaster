using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Master
{
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog filePath = new FolderBrowserDialog() { Description = "Please Select a File Path" })
                if (filePath.ShowDialog() == DialogResult.OK)
                    txtPath.Text = filePath.SelectedPath;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string keyWord = @txtKeyword.Text;
            string rootFolder = @txtPath.Text;
            try
            {
                string[] fileList = Directory.GetFiles(rootFolder);

                foreach (string file in fileList)
                {
                    
                    if (file.ToUpper().Contains(keyWord.ToUpper()) && MessageBox.Show("Are you sure you want to delete all files containing that word?", "Delete all files", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {

                        File.Delete(file);
                        MessageBox.Show("Files Containing Keyword Have Been Deleted");
                    }

                }
            }
            catch
            {

            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            FormMenu f = new FormMenu();
            f.StartPosition = FormStartPosition.Manual;
            Location = this.Location;
            f.Show();
            Close();
        }
       
    }
}
