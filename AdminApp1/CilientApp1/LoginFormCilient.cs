using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CilientApp1
{
    public partial class LoginForm : Form
    {
        public Students Current = null;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLoginTest_Click(object sender, EventArgs e)
        {
            string user = txtUserNameTest.Text;
            string pass = txtPassWordTest.Text;
            CilientModel CModel = new CilientModel();
            if (CModel.CheckLogin(user,pass) == true)
            {
                if(CModel.CheckExam(txtExamCodeTest.Text))
                {
                    this.Hide();
                }
            else
                MessageBox.Show("Exam not started");
            }
            else{
                MessageBox.Show("Login Fail");
            }
        }
        private void btnExitTest_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
