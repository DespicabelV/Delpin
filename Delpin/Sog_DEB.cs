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
        Controller cont = new Controller();
        public Sog_DEB()
        {
            InitializeComponent();
        }

        private void buttonSlet_Click(object sender, EventArgs e)
        {
            long cprCvr = Convert.ToInt64(cprCvrToolStripTextBox1.Text);
            cont.SletDEB(cprCvr);
            MessageBox.Show("DEB slettet");
        }

        private void buttonOpdater_Click(object sender, EventArgs e)
        {
            Int64 cprCvr = Convert.ToInt64(cprCvrToolStripTextBox1.Text);
            string navn = textBoxNavn.Text;
            string gade = textBoxGade.Text;
            int postnr = Convert.ToInt32(textBoxPostNr.Text);
            string by = textBoxBy.Text;
            int tlf = Convert.ToInt32(textBoxTlf.Text);
            string email = textBoxEmail.Text;
            string ansvarlig = textBoxAnsvarlig.Text;
            cont.UpdateDEB(cprCvr, navn, gade, postnr, by, tlf, email, ansvarlig);
            MessageBox.Show("DEB opdateret");
        }

        private void Sog_DEB_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delpinasDataSetSog_DEB.LejeOrdre' table. You can move, or remove it, as needed.
            this.lejeOrdreTableAdapter.Fill(this.delpinasDataSetSog_DEB.LejeOrdre);

        }

        private void søgToolStripButton_Click(object sender, EventArgs e)
        {
            long cprCvr = Convert.ToInt64(cprCvrToolStripTextBox1.Text);
            DEB deb = cont.HentDEB(cprCvr);
            textBoxNavn.Text = deb.Navn;
            textBoxGade.Text = deb.Gade;
            textBoxPostNr.Text = deb.Postnr.ToString();
            textBoxBy.Text = deb.By;
            textBoxTlf.Text = deb.Tlf.ToString();
            textBoxEmail.Text = deb.Email;
            textBoxAnsvarlig.Text = deb.Ansvarlig;

            try
            {
                this.lejeOrdreTableAdapter.Søg(this.delpinasDataSetSog_DEB.LejeOrdre, new System.Nullable<long>(((long)(System.Convert.ChangeType(cprCvrToolStripTextBox1.Text, typeof(long))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
