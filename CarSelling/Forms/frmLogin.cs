using CarSelling.Sessions;
using CarSelling.Utils;
using CarSellingDAL;
using CarSellingDAL.DAL;
using CarSellingDAL.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarSelling
{
    public partial class frmLogin : Form
    {
     
        UsersDal userDal;
        public frmLogin()
        {
           
            InitializeComponent();
            userDal = new UsersDal();

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user =userDal.GetByEmail(txtUserEmail.Text);
            if (user != null && user.Password == Helper.GenerateSHA256Hash(txtUserPassword.Text, user.Salt))
            {
                LoginSession.LoginUser = user;
                frmMain m = new frmMain();
                m.Show();
                this.Hide();
            }
            else
            {
                lblResult.Text = "Srhvdir";
                lblResult.Visible = true;
            }
        }

        private void btnSendCode_Click(object sender, EventArgs e)
        {
            EmailSending email = new EmailSending();
            email.SendCode(txtTextEmail.Text);
            MessageBox.Show("Kod gonderildi");
        }
    
        private void txtPassword2_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text!=txtRepeatPassword.Text)
            {
                txtRepeatPassword.BackColor=Color.Red;
                btnSave.Visible = false;
            }
            else
            {
                
                txtRepeatPassword.BackColor =Color.FromArgb(58, 68, 76);
                btnSave.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            EmailChacingDal emdal = new EmailChacingDal();

            if (emdal.GetByCode(Convert.ToInt32(txtCod.Text), txtTextEmail.Text)==true)
            {
                Users user = new Users();
                user.Email= txtTextEmail.Text;
                user.Code =Convert.ToInt32(txtCod.Text);
                user.Salt = Helper.CreateSalt(10);
                user.Password = Helper.GenerateSHA256Hash(txtPassword.Text, user.Salt);
                user.Name = txtName.Text;
                user.Number = txtNumber.Text;
               

                userDal.Insert(user);
                MessageBox.Show("Yadda saxlanildi");
            }
            else
            {
                MessageBox.Show("Daxil etdiyiniz kod səhvdir");
            }
        }

    }
}
