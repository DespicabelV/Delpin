﻿using System;
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
    public partial class Leje_Liste : Form
    {
        //Katrine:
        public Leje_Liste()
        {
            InitializeComponent();
        }

        Controller cont = new Controller();
        private void buttonPrint_Click(object sender, EventArgs e)
        {
            string start = dateTimePickerStart.Text;
            string slut = dateTimePickerSlut.Text;
            string filnavn = start + " til "+ slut;
            cont.SkrivOpretFil(filnavn, start, slut);
        }
    }
}
