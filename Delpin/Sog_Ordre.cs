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
    //Viggo:
    public partial class Sog_Ordre : Form
    {
        Database_Manager DBM = new Database_Manager();

        public Sog_Ordre()
        {
            InitializeComponent();
        }

        private void Sog_Ordre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delpinasDataSetSog_Ordre.LejeOrdreLinjer' table. You can move, or remove it, as needed.
            this.lejeOrdreLinjerTableAdapter.Fill(this.delpinasDataSetSog_Ordre.LejeOrdreLinjer);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int ID;
            double prisF, prisE, dageF, dageE;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                ID = Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
                DBM.Sog_Ordre_Hent_Dato(ID, out string start, out string slut);
                dageF = (Convert.ToDateTime(slut) - Convert.ToDateTime(start)).TotalDays;
                prisF = Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value) / dageF;
                dageE = (Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value) - Convert.ToDateTime(dataGridView1.Rows[i].Cells[3].Value)).TotalDays;
                prisE = prisF * dageE;
                dataGridView1.Rows[i].Cells[5].Value = prisE;
            }
            this.lejeOrdreLinjerTableAdapter.Update(this.delpinasDataSetSog_Ordre.LejeOrdreLinjer);
        }

        private void søgToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lejeOrdreLinjerTableAdapter.Søg(this.delpinasDataSetSog_Ordre.LejeOrdreLinjer, new System.Nullable<int>(((int)(System.Convert.ChangeType(ordreNummerToolStripTextBox.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
