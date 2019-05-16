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
    public partial class Hovedmenu : Form
    {
        public Hovedmenu()
        {
            InitializeComponent();
        }

        private void buttonDEB_Click(object sender, EventArgs e)
        {
            Opret_DEB DEB = new Opret_DEB();
            DEB.ShowDialog();
        }

        private void buttonOrdre_Click(object sender, EventArgs e)
        {
            Opret_Ordre Ordre = new Opret_Ordre();
            Ordre.ShowDialog();
        }

        private void buttonRedigerKunde_Click(object sender, EventArgs e)
        {
            Sog_DEB DEB = new Sog_DEB();
            DEB.ShowDialog();
        }

        private void buttonRedigerRes_Click(object sender, EventArgs e)
        {
            Sog_RES RES = new Sog_RES();
            RES.ShowDialog();
        }

        private void buttonRedigerOrdre_Click(object sender, EventArgs e)
        {
            Sog_Ordre Ordre = new Sog_Ordre();
            Ordre.ShowDialog();
        }

        private void buttonLejeListe_Click(object sender, EventArgs e)
        {
            Leje_Liste Leje = new Leje_Liste();
            Leje.ShowDialog();
        }
    }
}
