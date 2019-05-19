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
            textBoxGade.Visible = false;
            textBoxPostnr.Visible = false;
            textBoxBy.Visible = false;
            comboBoxAfdeling.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label4.Visible = false;
            label7.Visible = false;
            Database_Manager Conn = new Database_Manager();
        }

        private void buttonSog_Click(object sender, EventArgs e)
        {
            Temp_Viggo.Opret_Ordre_Sog(Convert.ToInt32(textBoxCVRCPR.Text));
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
    }
}
