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
    public partial class frmYear : Form
    {
        public frmYear()
        {
            InitializeComponent();
        }

        private void btnFilm_Click(object sender, EventArgs e)
        {
            frmFilm f4 = new frmFilm(); // Instantiate a Form4 object.
            
            f4.Show();
        }
    }
}
