namespace Delpin
{
    partial class Sog_RES
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
            this.buttonTilføjRes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slut_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSog = new System.Windows.Forms.Button();
            this.dateTimePickerSlut = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxResNavn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonTilføjRes
            // 
            this.buttonTilføjRes.Location = new System.Drawing.Point(20, 492);
            this.buttonTilføjRes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonTilføjRes.Name = "buttonTilføjRes";
            this.buttonTilføjRes.Size = new System.Drawing.Size(109, 47);
            this.buttonTilføjRes.TabIndex = 17;
            this.buttonTilføjRes.Text = "Tilføj Res";
            this.buttonTilføjRes.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Navn,
            this.Pris,
            this.Start_Dato,
            this.Slut_Dato});
            this.dataGridView1.Location = new System.Drawing.Point(20, 73);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(641, 411);
            this.dataGridView1.TabIndex = 16;
            // 
            // Navn
            // 
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            this.Navn.ReadOnly = true;
            // 
            // Pris
            // 
            this.Pris.HeaderText = "Pris";
            this.Pris.Name = "Pris";
            this.Pris.ReadOnly = true;
            // 
            // Start_Dato
            // 
            this.Start_Dato.HeaderText = "Start Dato";
            this.Start_Dato.Name = "Start_Dato";
            this.Start_Dato.ReadOnly = true;
            // 
            // Slut_Dato
            // 
            this.Slut_Dato.HeaderText = "Slut Dato";
            this.Slut_Dato.Name = "Slut_Dato";
            this.Slut_Dato.ReadOnly = true;
            // 
            // buttonSog
            // 
            this.buttonSog.Location = new System.Drawing.Point(95, 37);
            this.buttonSog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSog.Name = "buttonSog";
            this.buttonSog.Size = new System.Drawing.Size(104, 28);
            this.buttonSog.TabIndex = 15;
            this.buttonSog.Text = "Søg";
            this.buttonSog.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerSlut
            // 
            this.dateTimePickerSlut.Location = new System.Drawing.Point(395, 39);
            this.dateTimePickerSlut.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerSlut.Name = "dateTimePickerSlut";
            this.dateTimePickerSlut.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerSlut.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(340, 43);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Slut";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(395, 7);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerStart.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(340, 11);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Start";
            // 
            // textBoxResNavn
            // 
            this.textBoxResNavn.Location = new System.Drawing.Point(95, 7);
            this.textBoxResNavn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxResNavn.Name = "textBoxResNavn";
            this.textBoxResNavn.Size = new System.Drawing.Size(236, 22);
            this.textBoxResNavn.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Res Navn";
            // 
            // Sog_RES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 554);
            this.Controls.Add(this.buttonTilføjRes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSog);
            this.Controls.Add(this.dateTimePickerSlut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxResNavn);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sog_RES";
            this.Text = "Sog_RES";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonTilføjRes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slut_Dato;
        private System.Windows.Forms.Button buttonSog;
        private System.Windows.Forms.DateTimePicker dateTimePickerSlut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxResNavn;
        private System.Windows.Forms.Label label1;
    }
}