using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delpin
{
    public partial class Opret_Ordre : Form
    {
        public Opret_Ordre()
        {
            InitializeComponent();
        }

        private void buttonSog_Click(object sender, EventArgs e)
        {

        }

        private void buttonOpretKunde_Click(object sender, EventArgs e)
        {
            Opret_DEB DEB = new Opret_DEB();
            DEB.ShowDialog();
        }
    }
}
