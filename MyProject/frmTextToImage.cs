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
    public partial class frmTextToImage : Form
    {
        private string p;
        Image image1;
        CommonCalls objCS;
        public frmTextToImage()
        {
            InitializeComponent();
        }

        public frmTextToImage(string p)
        {
            // TODO: Complete member initialization
            InitializeComponent();
            this.p = p;
        }

        private void frmTextToImage_Load(object sender, EventArgs e)
        {
            objCS = new CommonCalls();
            if (p.Equals("Decryption"))
            {
                btnOperation.Text = "Decrypt";
                this.Controls.Remove(txtConfirmPassword);
                this.Controls.Remove(lblConfirmPassword);
                txtText.Location = new Point(txtText.Location.X, 79);
                lblText.Location = new Point(lblText.Location.X, lblText.Location.Y - 30);
                btnOperation.Location = new Point(btnOperation.Location.X, btnOperation.Location.Y - 32);
                btnReset.Location = new Point(btnReset.Location.X, btnOperation.Location.Y);

                btnMainWindow.Location = new Point(btnMainWindow.Location.X, btnOperation.Location.Y);
                this.Height = this.Height - 32;
            }
            btnOperation.NotifyDefault(true);
        }

        private void frmTextToImage_Activated(object sender, EventArgs e)
        {

        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            string details = "p:" + txtPassword.Text;

            if (objCS.notNull(txtPassword.Text) && objCS.notNull(txtPath.Text))
            {

                if (btnOperation.Text.Equals("Encrypt"))
                {
                    if (objCS.notNull(txtText.Text))
                    {
                        if (objCS.passwordMatch(txtPassword.Text, txtConfirmPassword.Text))
                        {
                            image1 = objCS.EnTextToImage(txtPath.Text, details, txtText.Text);
                            FileSave.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Something Wrong.Please Check the Details.Password And Confirm Password Does Not Match.", "Password Validation", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }

                    }
                    else
                    {
                        MessageBox.Show("Something Wrong.Please Check the Details.All Fields Are Compulsory.", "Null Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }

                }
                else if (btnOperation.Text.Equals("Decrypt"))
                {

                    bool verification;
                    string temp = objCS.DeImageToText(txtPath.Text, details, out verification);
                    if (!verification)
                        MessageBox.Show("Wrong Details.");
                    else
                    {

                        txtText.Text = temp;
                        txtText.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Something Wrong.Please Check the Details.All Fields Are Compulsory.", "Null Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void FileSelect_FileOk(object sender, CancelEventArgs e)
        {
            bool validate = objCS.validateFile(FileSelect.FileName);
            if (validate)
                txtPath.Text = FileSelect.FileName;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileSelect.ShowDialog();
        }

        private void FileSave_FileOk(object sender, CancelEventArgs e)
        {
            image1.Save(FileSave.FileName, System.Drawing.Imaging.ImageFormat.Png);
        }

        private void btnMainWindow_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }


    }
}
