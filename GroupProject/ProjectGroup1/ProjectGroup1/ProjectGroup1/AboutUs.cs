using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//created by Group1
//Adhikari(700639980), Alapati(700646035), Ghimire(700643983)

namespace ProjectGroup1

{
    public partial class AboutUs : Form
    {
        public AboutUs()
        {
            InitializeComponent();
        }

        private void AboutUs_Load(object sender, EventArgs e)
        {
            
            subContent.Text = " We are based out of Warrensburg, Missouri .\n \n Our customers can shop groceries online and pay line . \n  \n Orders will be delivered online.For more information please contact  group1@gmail.com \n \n © all right reserved group1 2016";
            this.Size = new Size(550, 300);
        }
    }
}
