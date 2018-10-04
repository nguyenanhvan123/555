using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdminApp1
{
    public partial class LoginForm : Form
    {
        public Staff CurrentUser = null;//khai bao tai khoan dang online
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
                string user = txtUserName.Text;
                string pass = txtPassWord.Text;
                AdminModel model = new AdminModel();
                CurrentUser = model.CheckLogin(user, pass);
                if (CurrentUser == null)
                {
                    MessageBox.Show("Login fail");
                }
                else
                {
                    MessageBox.Show("Login success");
                    this.Dispose();
                }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
