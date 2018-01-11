using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace File_Master
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {

            InitializeComponent();
           
        }
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete D = new Delete();
            D.StartPosition = FormStartPosition.Manual;
            Location = this.Location;
            D.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.StartPosition = FormStartPosition.Manual;
            Location = this.Location;
            F.Show();
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }
       
    }
    
}
