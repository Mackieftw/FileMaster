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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void btnPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog filePath = new FolderBrowserDialog() { Description = "Please Select a File Path" })
                if (filePath.ShowDialog() == DialogResult.OK)
                    txtPath.Text = filePath.SelectedPath;

        }

        private void btnLocation_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog path = new FolderBrowserDialog() { Description = "Please Select a File Path" })
                if (path.ShowDialog() == DialogResult.OK)
                    txtLocation.Text = path.SelectedPath;

        }

        private void btnMove_Click(object sender, EventArgs e)
        {

            string keyWord = @txtKeyword.Text;
            string rootIdle = @txtPath.Text;
            //  string rootFolder = @txtPath.Text + "/" + txtKeyword.Text;
            string rootFolder = @txtPath.Text;
            string newLocation = @txtLocation.Text;
           
           
            string partialName = keyWord;


            try
            {
                DirectoryInfo hdDirectoryInWhichToSearch = new DirectoryInfo(rootIdle);
                FileInfo[] filesInDir = hdDirectoryInWhichToSearch.GetFiles("*" + partialName + "*.*");

                foreach (FileInfo foundFile in filesInDir)
                {
                    string fullName = foundFile.FullName;
                    string rootTemp = Path.Combine(@rootIdle + "/" +fullName);
                    string newTemp = Path.Combine(@newLocation +"/" +  foundFile);

                    
                    Console.WriteLine(fullName);
                    Console.WriteLine(newTemp);
                    File.Move(fullName, newTemp);
                    MessageBox.Show("File moved from " + rootIdle + " to " + newLocation);

                   
              }
            }

            catch (Exception )
            {
                MessageBox.Show("Moving Failed, unexpected error");
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            FormMenu F = new FormMenu();
            F.StartPosition = FormStartPosition.Manual;
            Location = this.Location;
            F.Show();
            Close();
        }
        
    }
}
