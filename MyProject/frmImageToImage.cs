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
    public partial class frmImageToImage : Form
    {


        private string p;
        Image image1;
        CommonCalls objCS;

        public frmImageToImage()
        {
            InitializeComponent();
        }

        public frmImageToImage(string p)
        {
            InitializeComponent();
            // TODO: Complete member initialization
            this.p = p;
        }

        private void FileSelect_FileOk(object sender, CancelEventArgs e)
        {
            bool validate = objCS.validateFile(FileSelect.FileName);
            if (validate)
                txtPath.Text = FileSelect.FileName;
        }

        private void FileSelect1_FileOk(object sender, CancelEventArgs e)
        {
            bool validate = objCS.validateFile(FileSelect1.FileName);
            if (validate)
                txtPath1.Text = FileSelect1.FileName;
        }

        private void frmImageToImage_Load(object sender, EventArgs e)
        {
            objCS = new CommonCalls();
            if (p.Equals("Decryption"))
            {
                btnOperation.Text = "Decrypt";
                this.Controls.Remove(txtConfirmPassword);
                this.Controls.Remove(lblConfirmPassword);
                this.Controls.Remove(txtPath1);
                this.Controls.Remove(lblImage);
                this.Controls.Remove(btnBrowse1);
                btnOperation.Location = new Point(btnOperation.Location.X, btnOperation.Location.Y - 64);
                 btnReset.Location = new Point(btnReset.Location.X, btnOperation.Location.Y);
                 btnMainWindow.Location = new Point(btnMainWindow.Location.X, btnOperation.Location.Y);
                this.Height = this.Height - 64;
            }
            btnOperation.NotifyDefault(true);
        }

        private void btnOperation_Click(object sender, EventArgs e)
        {
            string details = "p:" + txtPassword.Text;


            if (objCS.notNull(txtPassword.Text) && objCS.notNull(txtPath.Text) )
            {

                if (btnOperation.Text.Equals("Encrypt"))
                {
                    if (objCS.notNull(txtPath1.Text))
                    {
                        if (objCS.passwordMatch(txtPassword.Text, txtConfirmPassword.Text))
                        {


                            image1 = objCS.EnImageToImage(txtPath.Text, details, txtPath1.Text);
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
                    image1 = objCS.DeImageToImage(txtPath.Text, details, out verification);
                    if (!verification)
                        MessageBox.Show("Wrong Details.");
                    else
                        FileSave.ShowDialog();
                }
            }



            else
            {
                MessageBox.Show("Something Wrong.Please Check the Details.All Fields Are Compulsory.", "Null Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            FileSelect1.ShowDialog();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileSelect.ShowDialog();
        }

        private void FileSave_FileOk(object sender, CancelEventArgs e)
        {
            image1.Save(FileSave.FileName, System.Drawing.Imaging.ImageFormat.Png);

        }
    }
}
