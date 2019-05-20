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
    public partial class Sog_DEB : Form
    {
        public Sog_DEB()
        {
            InitializeComponent();
        }

        private void buttonsog_Click(object sender, EventArgs e)
        {
            long cprCvr = Convert.ToInt64(textBoxCPRCVR.Text);
            DEB deb = Controller.HentDEB(cprCvr);
            textBoxNavn.Text = deb.Navn;
            textBoxGade.Text = deb.Gade;
            textBoxPostNr.Text = deb.Postnr.ToString();
            textBoxBy.Text = deb.By;
            textBoxTlf.Text = deb.Tlf.ToString();
            textBoxEmail.Text = deb.Email;
            textBoxAnsvarlig.Text = deb.Ansvarlig;
            
        }

        private void buttonSlet_Click(object sender, EventArgs e)
        {
            long cprCvr = Convert.ToInt64(textBoxCPRCVR.Text);
            Controller.SletDEB(cprCvr);
            MessageBox.Show("DEB slettet");
        }

        private void buttonOpdater_Click(object sender, EventArgs e)
        {
            Int64 cprCvr = Convert.ToInt64(textBoxCPRCVR.Text);
            string navn = textBoxNavn.Text;
            string gade = textBoxGade.Text;
            int postnr = Convert.ToInt32(textBoxPostNr.Text);
            string by = textBoxBy.Text;
            int tlf = Convert.ToInt32(textBoxTlf.Text);
            string email = textBoxEmail.Text;
            string ansvarlig = textBoxAnsvarlig.Text;
            Controller.UpdateDEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            MessageBox.Show("DEB opdateret");
        }
    }
}
