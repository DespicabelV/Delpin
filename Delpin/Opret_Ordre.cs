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
        Temp_Viggo test = new Temp_Viggo();
        public Opret_Ordre()
        {
            InitializeComponent();
            textBoxGade.Visible = false;
            textBoxPostnr.Visible = false;
            textBoxBy.Visible = false;
            comboBoxAfdeling.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
        }

        private void buttonSog_Click(object sender, EventArgs e)
        {
            string navn, byen, gade;
            int postnr;
            test.Opret_Ordre_Sog(Convert.ToInt64(textBoxCVRCPR.Text), out navn, out gade, out postnr, out byen);
            textBoxNavn.Text = navn;
            textBoxBy.Text = byen;
            textBoxGade.Text = gade;
            textBoxPostnr.Text = Convert.ToString(postnr);
        }

        private void buttonOpretKunde_Click(object sender, EventArgs e)
        {
            Opret_DEB DEB = new Opret_DEB();
            DEB.ShowDialog();
        }

        private void buttonTilfojVare_Click(object sender, EventArgs e)
        {
            Sog_RES RES = new Sog_RES();
            RES.ShowDialog();
        }

        private void checkBoxJa_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxJa.Checked == true)
            {
                checkBoxNej.Checked = false;
            }
            textBoxGade.Visible = true;
            textBoxPostnr.Visible = true;
            textBoxBy.Visible = true;
            comboBoxAfdeling.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label4.Visible = true;
            label7.Visible = false;
        }

        private void checkBoxNej_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNej.Checked == true)
            {
                checkBoxJa.Checked = false;
            }
            textBoxGade.Visible = false;
            textBoxPostnr.Visible = false;
            textBoxBy.Visible = false;
            comboBoxAfdeling.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label7.Visible = true;
        }

        private void buttonSletVare_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            double maxI = 0;
            double maxE = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                maxE = maxE + Convert.ToDouble(dataGridView1.Rows[i].Cells["Pris"].Value);
            }
            textBoxEkslMoms.Text = Convert.ToString(maxE);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                maxI = maxI + Convert.ToDouble(dataGridView1.Rows[i].Cells["Pris"].Value);
            }
            maxI = maxI * 1.25;
            textBoxInkMoms.Text = Convert.ToString(maxI);
        }

        private void buttonOpretOrdre_Click(object sender, EventArgs e)
        {
            string dato, gade, byen;
            int levering, postnr, ordrenr;
            long cprcvr;

            dato = DateTime.Now.ToString("yyyy-MM-dd");
            gade = textBoxGade.Text;
            byen = textBoxBy.Text;
            cprcvr = Convert.ToInt32(textBoxCVRCPR.Text);
            postnr = Convert.ToInt32(textBoxPostnr.Text);

            if (checkBoxJa.Checked == true)
            {
                levering = 1;
            }
            else
            {
                levering = 0;
            }

            test.Opret_Ordre_OO(dato, levering, gade, postnr, byen, cprcvr, out ordrenr);

            string startdato, slutdato, resnavn;
            int resnr, pris;

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                resnr     = Convert.ToInt32(dataGridView1.Rows[i].Cells["Res_Nr"].Value);
                resnavn   = Convert.ToString(dataGridView1.Rows[i].Cells["Navn"].Value);
                startdato = Convert.ToString(dataGridView1.Rows[i].Cells["Start"].Value);
                slutdato  = Convert.ToString(dataGridView1.Rows[i].Cells["Slut"].Value);
                pris      = Convert.ToInt32(dataGridView1.Rows[i].Cells["Pris"].Value);
                
            test.Opret_Ordre_LejeOrdreLinjer(ordrenr, resnr,resnavn, startdato, slutdato, pris);
            }
            MessageBox.Show("Ordre oprettet");
        }
    }
}
