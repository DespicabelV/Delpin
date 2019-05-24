using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Delpin.Temp_Line1;


namespace Delpin
{
    public partial class Sog_RESS : Form
    {
        Temp_Line1 temp = new Temp_Line1();
        List<HovedKategori> HovedKategorier;
        List<Kategori> Katagorier;
        List<Res> Resurser;
       
        
        public Sog_RESS()
        {
            InitializeComponent();
            buttonTilføjRes.Visible = false;
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

        private void textBoxHovedKategori_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxHovedKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
