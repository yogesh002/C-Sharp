using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectGroup1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            UserDetailsForm.loginID_Myorders = "";
            /*  GreetingsLabel.Text = "Hi there !!";
            ServiceInfoLabel.Text = "We are offering home delivery now !!. \n \n If you are a returning customer please login below and place order.\n \n If you are new customer please create account below and login."; */
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            Login logon = new Login();
            logon.MdiParent = this.MdiParent;
            logon.StartPosition = FormStartPosition.CenterScreen;
            this.Dock = DockStyle.Fill;
            logon.Show();

        }

        private void createAccountButton_Click(object sender, EventArgs e)
        {
            CreateAccount createAccountPage = new CreateAccount();
            createAccountPage.MdiParent = this.MdiParent;
            createAccountPage.StartPosition = FormStartPosition.CenterScreen;
            this.Dock = DockStyle.Fill;
            createAccountPage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
