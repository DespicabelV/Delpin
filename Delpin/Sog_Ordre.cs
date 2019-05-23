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
        Temp_Viggo test = new Temp_Viggo();
        public Sog_Ordre()
        {
            InitializeComponent();
        }
        
        private void buttonSog_Click(object sender, EventArgs e)
        {
            string resnavn, startDato, slutDato;
            int resnr;
            double pris;
            List<LejeList> list = new List<LejeList>();
            // opret et objekt der hedder lejeordre og smid data i den så den kan loppes her og skrives i datagridview
            list = test.Sog_Ordre_Sog(Convert.ToInt32(textBoxOrdreNr.Text));

            foreach (Lejelist l in list)
            {

            }

            for (int i = 0; i < list.Count; i++)
            {
                
            }
        }
    }
}
