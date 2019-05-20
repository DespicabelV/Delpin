namespace Delpin
{
    partial class Opret_Ordre
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCVRCPR = new System.Windows.Forms.TextBox();
            this.textBoxNavn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBoxJa = new System.Windows.Forms.CheckBox();
            this.checkBoxNej = new System.Windows.Forms.CheckBox();
            this.textBoxGade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPostnr = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxBy = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxAfdeling = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Res_Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris_Pr_Dag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonTilfojVare = new System.Windows.Forms.Button();
            this.buttonSletVare = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEkslMoms = new System.Windows.Forms.TextBox();
            this.textBoxInkMoms = new System.Windows.Forms.TextBox();
            this.buttonOpretOrdre = new System.Windows.Forms.Button();
            this.buttonSog = new System.Windows.Forms.Button();
            this.buttonOpretKunde = new System.Windows.Forms.Button();
            this.ButtonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CVR/CPR";
            // 
            // textBoxCVRCPR
            // 
            this.textBoxCVRCPR.Location = new System.Drawing.Point(75, 10);
            this.textBoxCVRCPR.Name = "textBoxCVRCPR";
            this.textBoxCVRCPR.Size = new System.Drawing.Size(189, 20);
            this.textBoxCVRCPR.TabIndex = 1;
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.Location = new System.Drawing.Point(75, 36);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(189, 20);
            this.textBoxNavn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Levering";
            // 
            // checkBoxJa
            // 
            this.checkBoxJa.AutoSize = true;
            this.checkBoxJa.Location = new System.Drawing.Point(75, 64);
            this.checkBoxJa.Name = "checkBoxJa";
            this.checkBoxJa.Size = new System.Drawing.Size(37, 17);
            this.checkBoxJa.TabIndex = 5;
            this.checkBoxJa.Text = "Ja";
            this.checkBoxJa.UseVisualStyleBackColor = true;
            this.checkBoxJa.CheckedChanged += new System.EventHandler(this.checkBoxJa_CheckedChanged);
            // 
            // checkBoxNej
            // 
            this.checkBoxNej.AutoSize = true;
            this.checkBoxNej.Location = new System.Drawing.Point(118, 64);
            this.checkBoxNej.Name = "checkBoxNej";
            this.checkBoxNej.Size = new System.Drawing.Size(42, 17);
            this.checkBoxNej.TabIndex = 6;
            this.checkBoxNej.Text = "Nej";
            this.checkBoxNej.UseVisualStyleBackColor = true;
            this.checkBoxNej.CheckedChanged += new System.EventHandler(this.checkBoxNej_CheckedChanged);
            // 
            // textBoxGade
            // 
            this.textBoxGade.Location = new System.Drawing.Point(75, 88);
            this.textBoxGade.Name = "textBoxGade";
            this.textBoxGade.Size = new System.Drawing.Size(313, 20);
            this.textBoxGade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gade";
            // 
            // textBoxPostnr
            // 
            this.textBoxPostnr.Location = new System.Drawing.Point(75, 114);
            this.textBoxPostnr.Name = "textBoxPostnr";
            this.textBoxPostnr.Size = new System.Drawing.Size(93, 20);
            this.textBoxPostnr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Post Nr.";
            // 
            // textBoxBy
            // 
            this.textBoxBy.Location = new System.Drawing.Point(199, 114);
            this.textBoxBy.Name = "textBoxBy";
            this.textBoxBy.Size = new System.Drawing.Size(189, 20);
            this.textBoxBy.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(174, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Afdeling";
            // 
            // comboBoxAfdeling
            // 
            this.comboBoxAfdeling.FormattingEnabled = true;
            this.comboBoxAfdeling.Items.AddRange(new object[] {
            "Assens",
            "Kolding",
            "Soenderborg",
            "Esbjerg",
            "Odense",
            "Vejle",
            "Fredericia",
            "Roedekro",
            "Haderslev"});
            this.comboBoxAfdeling.Location = new System.Drawing.Point(75, 88);
            this.comboBoxAfdeling.Name = "comboBoxAfdeling";
            this.comboBoxAfdeling.Size = new System.Drawing.Size(189, 21);
            this.comboBoxAfdeling.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Navn,
            this.Res_Nr,
            this.Pris_Pr_Dag,
            this.Pris,
            this.Start,
            this.Slut});
            this.dataGridView1.Location = new System.Drawing.Point(54, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(640, 256);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Navn
            // 
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            // 
            // Res_Nr
            // 
            this.Res_Nr.HeaderText = "RES Nr.";
            this.Res_Nr.Name = "Res_Nr";
            // 
            // Pris_Pr_Dag
            // 
            this.Pris_Pr_Dag.HeaderText = "Pris pr. dag";
            this.Pris_Pr_Dag.Name = "Pris_Pr_Dag";
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            // 
            // Start
            // 
            this.Start.HeaderText = "Start Dato";
            this.Start.Name = "Start";
            // 
            // Slut
            // 
            this.Slut.HeaderText = "Slut Dato";
            this.Slut.Name = "Slut";
            // 
            // buttonTilfojVare
            // 
            this.buttonTilfojVare.Location = new System.Drawing.Point(54, 136);
            this.buttonTilfojVare.Name = "buttonTilfojVare";
            this.buttonTilfojVare.Size = new System.Drawing.Size(75, 23);
            this.buttonTilfojVare.TabIndex = 16;
            this.buttonTilfojVare.Text = "Tilføj Vare";
            this.buttonTilfojVare.UseVisualStyleBackColor = true;
            this.buttonTilfojVare.Click += new System.EventHandler(this.buttonTilfojVare_Click);
            // 
            // buttonSletVare
            // 
            this.buttonSletVare.Location = new System.Drawing.Point(619, 136);
            this.buttonSletVare.Name = "buttonSletVare";
            this.buttonSletVare.Size = new System.Drawing.Size(75, 23);
            this.buttonSletVare.TabIndex = 17;
            this.buttonSletVare.Text = "Slet Vare";
            this.buttonSletVare.UseVisualStyleBackColor = true;
            this.buttonSletVare.Click += new System.EventHandler(this.buttonSletVare_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(493, 438);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Ink. Moms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(384, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Eksl. Moms";
            // 
            // textBoxEkslMoms
            // 
            this.textBoxEkslMoms.Location = new System.Drawing.Point(387, 454);
            this.textBoxEkslMoms.Name = "textBoxEkslMoms";
            this.textBoxEkslMoms.ReadOnly = true;
            this.textBoxEkslMoms.Size = new System.Drawing.Size(100, 20);
            this.textBoxEkslMoms.TabIndex = 20;
            // 
            // textBoxInkMoms
            // 
            this.textBoxInkMoms.Location = new System.Drawing.Point(496, 454);
            this.textBoxInkMoms.Name = "textBoxInkMoms";
            this.textBoxInkMoms.ReadOnly = true;
            this.textBoxInkMoms.Size = new System.Drawing.Size(100, 20);
            this.textBoxInkMoms.TabIndex = 21;
            // 
            // buttonOpretOrdre
            // 
            this.buttonOpretOrdre.Location = new System.Drawing.Point(602, 438);
            this.buttonOpretOrdre.Name = "buttonOpretOrdre";
            this.buttonOpretOrdre.Size = new System.Drawing.Size(92, 36);
            this.buttonOpretOrdre.TabIndex = 22;
            this.buttonOpretOrdre.Text = "Opret Ordre";
            this.buttonOpretOrdre.UseVisualStyleBackColor = true;
            this.buttonOpretOrdre.Click += new System.EventHandler(this.buttonOpretOrdre_Click);
            // 
            // buttonSog
            // 
            this.buttonSog.Location = new System.Drawing.Point(277, 7);
            this.buttonSog.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSog.Name = "buttonSog";
            this.buttonSog.Size = new System.Drawing.Size(56, 24);
            this.buttonSog.TabIndex = 23;
            this.buttonSog.Text = "Søg";
            this.buttonSog.UseVisualStyleBackColor = true;
            this.buttonSog.Click += new System.EventHandler(this.buttonSog_Click);
            // 
            // buttonOpretKunde
            // 
            this.buttonOpretKunde.Location = new System.Drawing.Point(277, 37);
            this.buttonOpretKunde.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpretKunde.Name = "buttonOpretKunde";
            this.buttonOpretKunde.Size = new System.Drawing.Size(56, 44);
            this.buttonOpretKunde.TabIndex = 24;
            this.buttonOpretKunde.Text = "Opret kunde";
            this.buttonOpretKunde.UseVisualStyleBackColor = true;
            this.buttonOpretKunde.Click += new System.EventHandler(this.buttonOpretKunde_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(289, 438);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(92, 36);
            this.ButtonUpdate.TabIndex = 25;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // Opret_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 504);
            this.Controls.Add(this.ButtonUpdate);
            this.Controls.Add(this.buttonOpretKunde);
            this.Controls.Add(this.buttonSog);
            this.Controls.Add(this.buttonOpretOrdre);
            this.Controls.Add(this.textBoxInkMoms);
            this.Controls.Add(this.textBoxEkslMoms);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonSletVare);
            this.Controls.Add(this.buttonTilfojVare);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxAfdeling);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxBy);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxPostnr);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxGade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxNej);
            this.Controls.Add(this.checkBoxJa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNavn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxCVRCPR);
            this.Controls.Add(this.label1);
            this.Name = "Opret_Ordre";
            this.Text = "Opret_Ordre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCVRCPR;
        private System.Windows.Forms.TextBox textBoxNavn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBoxJa;
        private System.Windows.Forms.CheckBox checkBoxNej;
        private System.Windows.Forms.TextBox textBoxGade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPostnr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxBy;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxAfdeling;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonTilfojVare;
        private System.Windows.Forms.Button buttonSletVare;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEkslMoms;
        private System.Windows.Forms.TextBox textBoxInkMoms;
        private System.Windows.Forms.Button buttonOpretOrdre;
        private System.Windows.Forms.Button buttonSog;
        private System.Windows.Forms.Button buttonOpretKunde;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Res_Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris_Pr_Dag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slut;
        private System.Windows.Forms.Button ButtonUpdate;
    }
}