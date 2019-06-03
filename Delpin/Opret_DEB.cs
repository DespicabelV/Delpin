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
    public partial class Opret_DEB : Form
    {
        //Katrine
        Controller cont = new Controller();
        public Opret_DEB()
        {
            InitializeComponent();
        }

        private void buttonPrivat_Click(object sender, EventArgs e)
        {
            textBoxAnsvarlig.Text = textBoxNavn.Text;
        }

        private void buttonOpret_Click(object sender, EventArgs e)
        {
            Int64 cprCvr = Convert.ToInt64(textBoxCPRCVR.Text);
            string navn = textBoxNavn.Text;
            string gade = textBoxGade.Text;
            int postnr = Convert.ToInt32(textBoxPostNr.Text);
            string by = textBoxBy.Text;
            int tlf = Convert.ToInt32(textBoxTlf.Text);
            string email = textBoxEmail.Text;
            string ansvarlig = textBoxAnsvarlig.Text;
            cont.GemDEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            MessageBox.Show("Kunde oprettet");
        }
    }
}
