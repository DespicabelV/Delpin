namespace Delpin
{
    partial class Sog_RESS
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
            this.buttonTilfojRes = new System.Windows.Forms.Button();
            this.buttonSog = new System.Windows.Forms.Button();
            this.dateTimePickerSlut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBoxHovedKategori = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTilfojRes
            // 
            this.buttonTilfojRes.Location = new System.Drawing.Point(20, 492);
            this.buttonTilfojRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTilfojRes.Name = "buttonTilfojRes";
            this.buttonTilfojRes.Size = new System.Drawing.Size(109, 47);
            this.buttonTilfojRes.TabIndex = 17;
            this.buttonTilfojRes.Text = "Tilføj Res";
            this.buttonTilfojRes.UseVisualStyleBackColor = true;
            this.buttonTilfojRes.Click += new System.EventHandler(this.buttonTilføjRes_Click);
            // 
            // buttonSog
            // 
            this.buttonSog.Location = new System.Drawing.Point(132, 43);
            this.buttonSog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSog.Name = "buttonSog";
            this.buttonSog.Size = new System.Drawing.Size(104, 28);
            this.buttonSog.TabIndex = 15;
            this.buttonSog.Text = "Søg";
            this.buttonSog.UseVisualStyleBackColor = true;
            this.buttonSog.Click += new System.EventHandler(this.buttonSog_Click);
            // 
            // dateTimePickerSlut
            // 
            this.dateTimePickerSlut.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerSlut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerSlut.Location = new System.Drawing.Point(439, 36);
            this.dateTimePickerSlut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerSlut.Name = "dateTimePickerSlut";
            this.dateTimePickerSlut.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerSlut.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Slut";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CustomFormat = "yyyy-MM-dd";
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(439, 7);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerStart.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hoved Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Kategori";
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(132, 80);
            this.comboBoxKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(236, 24);
            this.comboBoxKategori.TabIndex = 19;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(20, 149);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(700, 281);
            this.dataGridView1.TabIndex = 20;
            // 
            // comboBoxHovedKategori
            // 
            this.comboBoxHovedKategori.FormattingEnabled = true;
            this.comboBoxHovedKategori.Location = new System.Drawing.Point(132, 11);
            this.comboBoxHovedKategori.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxHovedKategori.Name = "comboBoxHovedKategori";
            this.comboBoxHovedKategori.Size = new System.Drawing.Size(236, 24);
            this.comboBoxHovedKategori.TabIndex = 21;
            // 
            // Sog_RESS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 554);
            this.Controls.Add(this.comboBoxHovedKategori);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonTilfojRes);
            this.Controls.Add(this.buttonSog);
            this.Controls.Add(this.dateTimePickerSlut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sog_RESS";
            this.Text = "Sog_RES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTilfojRes;
        private System.Windows.Forms.Button buttonSog;
        private System.Windows.Forms.DateTimePicker dateTimePickerSlut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboBoxHovedKategori;
    }
}