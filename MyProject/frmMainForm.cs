using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyProject
{

    public partial class frmMainForm : Form
    {

        CommonCalls objCS;


        public frmMainForm()
        {
            InitializeComponent();
        }

        private void btnTextToFiles_Click(object sender, EventArgs e)
        {

        }

        private void frmMainForm_Load(object sender, EventArgs e)
        {
            objCS = new CommonCalls();
        }

        private void btnTextToImage_Click(object sender, EventArgs e)
        {
            
            objCS.openForm("EnTextToImage");
        }

        private void btnFileFromFile_Click(object sender, EventArgs e)
        {

        }

        private void btnTextFromImage_Click(object sender, EventArgs e)
        {
            objCS.openForm("DeImageToText");
        }

        private void btnImageToImage_Click(object sender, EventArgs e)
        {
            objCS.openForm("EnImageToImage");
        }

        private void btnImageFromImage_Click(object sender, EventArgs e)
        {
            objCS.openForm("DeImageToImage");
        }
    }
}
