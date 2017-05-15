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
    public partial class DisplayError : Form
    {
        private string errorMessage;
        public DisplayError()
        {
            InitializeComponent();
        }

        //public property
        public string ErrrorMessages
        {
            get
            {
                return errorMessage;
            }
            set
            {
                errorMessage = value;
            }
        }

        private void DisplayError_Load(object sender, EventArgs e)
        {
            ErrorLabel.Text = errorMessage;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.MdiParent = this.MdiParent;
            login.Show();
        }
    }
}
