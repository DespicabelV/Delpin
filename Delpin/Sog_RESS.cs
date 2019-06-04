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
    public partial class Sog_RESS : Form
    {
        //Line:
        Database_Manager temp = new Database_Manager();
        List<HovedKategori> HovedKategorier;
        List<Kategori> Katagorier;
        List<Res> Resurser;
        
        public Sog_RESS()
        {
            InitializeComponent();
            buttonTilfojRes.Visible = true;
            HovedKategorier = temp.HentHovedKategori();
            Katagorier = new List<Kategori>();
            Resurser = new List<Res>();
            
            // Indsætter hovedkategori i combobox 
            foreach (HovedKategori item in HovedKategorier)
            {
                comboBoxHovedKategori.Items.Add(item.Navn.ToString());
            }
        }

        // Søger udfra valgte hovedkategori efter res i 
        private void buttonSog_Click(object sender, EventArgs e)
        {
            Katagorier = temp.HentKategorir(comboBoxHovedKategori.Text);

            comboBoxKategori.DisplayMember = "navn";
            comboBoxKategori.DataSource = Katagorier;

        }

        // Indsætter kategori i combobox og indsætter res i datagridview
        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            string start = dateTimePickerStart.Text;
            string slut = dateTimePickerSlut.Text;
            Kategori valgteKatori = comboBoxKategori.SelectedItem as Kategori;
            Resurser = temp.HentRes(valgteKatori.id, start, slut);
            dataGridView1.DataSource = Resurser;

        }

        private void buttonTilføjRes_Click(object sender, EventArgs e)
        {
            int index;
            index = dataGridView1.SelectedRows[0].Index;

            Global.global_navn_Sog_Ress  = Convert.ToString(dataGridView1.Rows[index].Cells["Navn"].Value);
            Global.global_start_Sog_Ress = Convert.ToString(dateTimePickerStart.Value.ToString("yyyy-MM-dd"));
            Global.global_slut_Sog_Ress  = Convert.ToString(dateTimePickerSlut.Value.ToString("yyyy-MM-dd"));
            Global.global_resnr_Sog_Ress = Convert.ToInt32(dataGridView1.Rows[index].Cells["Resnr"].Value);
            Global.global_pris_Sog_Ress  = Convert.ToInt64(dataGridView1.Rows[index].Cells["Pris"].Value);

            MessageBox.Show("Tilføj tilbehør her");
            this.Close();
        }
    }
}
