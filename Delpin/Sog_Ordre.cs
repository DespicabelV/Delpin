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
    public partial class Sog_Ordre : Form
    {
        public Sog_Ordre()
        {
            InitializeComponent();
        }

        private void Sog_Ordre_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'delpinasDataSet_Sog_Ordre.LejeOrdreLinjer' table. You can move, or remove it, as needed.
            this.lejeOrdreLinjerTableAdapter.Fill(this.delpinasDataSet_Sog_Ordre.LejeOrdreLinjer);

        }

        private void søgToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.lejeOrdreLinjerTableAdapter.Søg(this.delpinasDataSet_Sog_Ordre.LejeOrdreLinjer, new System.Nullable<int>(((int)(System.Convert.ChangeType(ordreNummerToolStripTextBox1.Text, typeof(int))))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
