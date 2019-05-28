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
            this.components = new System.ComponentModel.Container();
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
            this.afdelingerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delpinasDataSet_Opret_Ordre_Afdeling = new Delpin.delpinasDataSet_Opret_Ordre_Afdeling();
            this.afdelingerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.afdelingerTableAdapter = new Delpin.delpinasDataSet_Opret_Ordre_AfdelingTableAdapters.AfdelingerTableAdapter();
            this.buttonIndset = new System.Windows.Forms.Button();
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Res_Nr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris_Pr_Dag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSet_Opret_Ordre_Afdeling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CVR/CPR";
            // 
            // textBoxCVRCPR
            // 
            this.textBoxCVRCPR.Location = new System.Drawing.Point(100, 12);
            this.textBoxCVRCPR.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCVRCPR.Name = "textBoxCVRCPR";
            this.textBoxCVRCPR.Size = new System.Drawing.Size(251, 22);
            this.textBoxCVRCPR.TabIndex = 1;
            // 
            // textBoxNavn
            // 
            this.textBoxNavn.Location = new System.Drawing.Point(100, 44);
            this.textBoxNavn.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNavn.Name = "textBoxNavn";
            this.textBoxNavn.Size = new System.Drawing.Size(251, 22);
            this.textBoxNavn.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Navn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Levering";
            // 
            // checkBoxJa
            // 
            this.checkBoxJa.AutoSize = true;
            this.checkBoxJa.Location = new System.Drawing.Point(100, 79);
            this.checkBoxJa.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxJa.Name = "checkBoxJa";
            this.checkBoxJa.Size = new System.Drawing.Size(45, 21);
            this.checkBoxJa.TabIndex = 5;
            this.checkBoxJa.Text = "Ja";
            this.checkBoxJa.UseVisualStyleBackColor = true;
            this.checkBoxJa.CheckedChanged += new System.EventHandler(this.checkBoxJa_CheckedChanged);
            // 
            // checkBoxNej
            // 
            this.checkBoxNej.AutoSize = true;
            this.checkBoxNej.Location = new System.Drawing.Point(157, 79);
            this.checkBoxNej.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxNej.Name = "checkBoxNej";
            this.checkBoxNej.Size = new System.Drawing.Size(51, 21);
            this.checkBoxNej.TabIndex = 6;
            this.checkBoxNej.Text = "Nej";
            this.checkBoxNej.UseVisualStyleBackColor = true;
            this.checkBoxNej.CheckedChanged += new System.EventHandler(this.checkBoxNej_CheckedChanged);
            // 
            // textBoxGade
            // 
            this.textBoxGade.Location = new System.Drawing.Point(100, 108);
            this.textBoxGade.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxGade.Name = "textBoxGade";
            this.textBoxGade.Size = new System.Drawing.Size(416, 22);
            this.textBoxGade.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Gade";
            // 
            // textBoxPostnr
            // 
            this.textBoxPostnr.Location = new System.Drawing.Point(100, 140);
            this.textBoxPostnr.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPostnr.Name = "textBoxPostnr";
            this.textBoxPostnr.Size = new System.Drawing.Size(123, 22);
            this.textBoxPostnr.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 145);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Post Nr.";
            // 
            // textBoxBy
            // 
            this.textBoxBy.Location = new System.Drawing.Point(265, 140);
            this.textBoxBy.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxBy.Name = "textBoxBy";
            this.textBoxBy.Size = new System.Drawing.Size(251, 22);
            this.textBoxBy.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 144);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "By";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 112);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Afdeling";
            // 
            // comboBoxAfdeling
            // 
            this.comboBoxAfdeling.DataSource = this.afdelingerBindingSource1;
            this.comboBoxAfdeling.DisplayMember = "bynavn";
            this.comboBoxAfdeling.FormattingEnabled = true;
            this.comboBoxAfdeling.Location = new System.Drawing.Point(100, 108);
            this.comboBoxAfdeling.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxAfdeling.Name = "comboBoxAfdeling";
            this.comboBoxAfdeling.Size = new System.Drawing.Size(251, 24);
            this.comboBoxAfdeling.TabIndex = 14;
            this.comboBoxAfdeling.ValueMember = "bynavn";
            // 
            // afdelingerBindingSource1
            // 
            this.afdelingerBindingSource1.DataMember = "Afdelinger";
            this.afdelingerBindingSource1.DataSource = this.delpinasDataSet_Opret_Ordre_Afdeling;
            // 
            // delpinasDataSet_Opret_Ordre_Afdeling
            // 
            this.delpinasDataSet_Opret_Ordre_Afdeling.DataSetName = "delpinasDataSet_Opret_Ordre_Afdeling";
            this.delpinasDataSet_Opret_Ordre_Afdeling.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // afdelingerBindingSource
            // 
            this.afdelingerBindingSource.DataMember = "Afdelinger";
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
            this.dataGridView1.Location = new System.Drawing.Point(72, 204);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(853, 315);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonTilfojVare
            // 
            this.buttonTilfojVare.Location = new System.Drawing.Point(72, 167);
            this.buttonTilfojVare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonTilfojVare.Name = "buttonTilfojVare";
            this.buttonTilfojVare.Size = new System.Drawing.Size(100, 28);
            this.buttonTilfojVare.TabIndex = 16;
            this.buttonTilfojVare.Text = "Tilføj Vare";
            this.buttonTilfojVare.UseVisualStyleBackColor = true;
            this.buttonTilfojVare.Click += new System.EventHandler(this.buttonTilfojVare_Click);
            // 
            // buttonSletVare
            // 
            this.buttonSletVare.Location = new System.Drawing.Point(825, 167);
            this.buttonSletVare.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSletVare.Name = "buttonSletVare";
            this.buttonSletVare.Size = new System.Drawing.Size(100, 28);
            this.buttonSletVare.TabIndex = 17;
            this.buttonSletVare.Text = "Slet Vare";
            this.buttonSletVare.UseVisualStyleBackColor = true;
            this.buttonSletVare.Click += new System.EventHandler(this.buttonSletVare_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(657, 539);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Ink. Moms";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(512, 538);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total Eksl. Moms";
            // 
            // textBoxEkslMoms
            // 
            this.textBoxEkslMoms.Location = new System.Drawing.Point(516, 559);
            this.textBoxEkslMoms.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEkslMoms.Name = "textBoxEkslMoms";
            this.textBoxEkslMoms.ReadOnly = true;
            this.textBoxEkslMoms.Size = new System.Drawing.Size(132, 22);
            this.textBoxEkslMoms.TabIndex = 20;
            // 
            // textBoxInkMoms
            // 
            this.textBoxInkMoms.Location = new System.Drawing.Point(661, 559);
            this.textBoxInkMoms.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxInkMoms.Name = "textBoxInkMoms";
            this.textBoxInkMoms.ReadOnly = true;
            this.textBoxInkMoms.Size = new System.Drawing.Size(132, 22);
            this.textBoxInkMoms.TabIndex = 21;
            // 
            // buttonOpretOrdre
            // 
            this.buttonOpretOrdre.Location = new System.Drawing.Point(803, 539);
            this.buttonOpretOrdre.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOpretOrdre.Name = "buttonOpretOrdre";
            this.buttonOpretOrdre.Size = new System.Drawing.Size(123, 44);
            this.buttonOpretOrdre.TabIndex = 22;
            this.buttonOpretOrdre.Text = "Opret Ordre";
            this.buttonOpretOrdre.UseVisualStyleBackColor = true;
            this.buttonOpretOrdre.Click += new System.EventHandler(this.buttonOpretOrdre_Click);
            // 
            // buttonSog
            // 
            this.buttonSog.Location = new System.Drawing.Point(369, 9);
            this.buttonSog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSog.Name = "buttonSog";
            this.buttonSog.Size = new System.Drawing.Size(75, 30);
            this.buttonSog.TabIndex = 23;
            this.buttonSog.Text = "Søg";
            this.buttonSog.UseVisualStyleBackColor = true;
            this.buttonSog.Click += new System.EventHandler(this.buttonSog_Click);
            // 
            // buttonOpretKunde
            // 
            this.buttonOpretKunde.Location = new System.Drawing.Point(369, 46);
            this.buttonOpretKunde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOpretKunde.Name = "buttonOpretKunde";
            this.buttonOpretKunde.Size = new System.Drawing.Size(75, 54);
            this.buttonOpretKunde.TabIndex = 24;
            this.buttonOpretKunde.Text = "Opret kunde";
            this.buttonOpretKunde.UseVisualStyleBackColor = true;
            this.buttonOpretKunde.Click += new System.EventHandler(this.buttonOpretKunde_Click);
            // 
            // ButtonUpdate
            // 
            this.ButtonUpdate.Location = new System.Drawing.Point(385, 539);
            this.ButtonUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.ButtonUpdate.Name = "ButtonUpdate";
            this.ButtonUpdate.Size = new System.Drawing.Size(123, 44);
            this.ButtonUpdate.TabIndex = 25;
            this.ButtonUpdate.Text = "Update";
            this.ButtonUpdate.UseVisualStyleBackColor = true;
            this.ButtonUpdate.Click += new System.EventHandler(this.ButtonUpdate_Click);
            // 
            // afdelingerTableAdapter
            // 
            this.afdelingerTableAdapter.ClearBeforeFill = true;
            // 
            // buttonIndset
            // 
            this.buttonIndset.Location = new System.Drawing.Point(180, 167);
            this.buttonIndset.Margin = new System.Windows.Forms.Padding(4);
            this.buttonIndset.Name = "buttonIndset";
            this.buttonIndset.Size = new System.Drawing.Size(100, 28);
            this.buttonIndset.TabIndex = 26;
            this.buttonIndset.Text = "Indset Vare";
            this.buttonIndset.UseVisualStyleBackColor = true;
            this.buttonIndset.Click += new System.EventHandler(this.buttonIndset_Click);
            // 
            // Navn
            // 
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            this.Navn.ReadOnly = true;
            // 
            // Res_Nr
            // 
            this.Res_Nr.HeaderText = "RES Nr.";
            this.Res_Nr.Name = "Res_Nr";
            this.Res_Nr.ReadOnly = true;
            // 
            // Pris_Pr_Dag
            // 
            this.Pris_Pr_Dag.HeaderText = "Pris pr. dag";
            this.Pris_Pr_Dag.Name = "Pris_Pr_Dag";
            this.Pris_Pr_Dag.ReadOnly = true;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            // 
            // Start
            // 
            this.Start.HeaderText = "Start Dato";
            this.Start.Name = "Start";
            this.Start.ReadOnly = true;
            // 
            // Slut
            // 
            this.Slut.HeaderText = "Slut Dato";
            this.Slut.Name = "Slut";
            this.Slut.ReadOnly = true;
            // 
            // Opret_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 620);
            this.Controls.Add(this.buttonIndset);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Opret_Ordre";
            this.Text = "Opret_Ordre";
            this.Load += new System.EventHandler(this.Opret_Ordre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.afdelingerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSet_Opret_Ordre_Afdeling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.afdelingerBindingSource)).EndInit();
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
        private System.Windows.Forms.Button ButtonUpdate;
        private System.Windows.Forms.BindingSource afdelingerBindingSource;
        private delpinasDataSet_Opret_Ordre_Afdeling delpinasDataSet_Opret_Ordre_Afdeling;
        private System.Windows.Forms.BindingSource afdelingerBindingSource1;
        private delpinasDataSet_Opret_Ordre_AfdelingTableAdapters.AfdelingerTableAdapter afdelingerTableAdapter;
        private System.Windows.Forms.Button buttonIndset;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Res_Nr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris_Pr_Dag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slut;
    }
}