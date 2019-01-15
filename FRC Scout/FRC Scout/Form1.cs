using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRC_Scout
{

    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username = "6317";
            String Password = "WestCSE";


            if (txtUsername.Text == Username)
            {
                if (txtPassword.Text == Password)
                {
                    lblHello.Text = "Hello";
                    //Send to Year page
                    //frmYear.Show();
                }
            }
            else if (txtUsername.Text != Username || txtPassword.Text != Password)
            {
                lblError.Text = "Your Username or Password is incorrect.";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}