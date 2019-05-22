namespace Delpin
{
    partial class Sog_Ordre
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
            this.textBoxOrdreNr = new System.Windows.Forms.TextBox();
            this.buttonSog = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ResNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Navn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pris_Pr_Dag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Start_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slut_Dato = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonKvitering = new System.Windows.Forms.Button();
            this.buttonFaktura = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ordre Nummer";
            // 
            // textBoxOrdreNr
            // 
            this.textBoxOrdreNr.Location = new System.Drawing.Point(124, 7);
            this.textBoxOrdreNr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxOrdreNr.Name = "textBoxOrdreNr";
            this.textBoxOrdreNr.Size = new System.Drawing.Size(399, 22);
            this.textBoxOrdreNr.TabIndex = 1;
            // 
            // buttonSog
            // 
            this.buttonSog.Location = new System.Drawing.Point(532, 5);
            this.buttonSog.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonSog.Name = "buttonSog";
            this.buttonSog.Size = new System.Drawing.Size(100, 28);
            this.buttonSog.TabIndex = 2;
            this.buttonSog.Text = "Søg";
            this.buttonSog.UseVisualStyleBackColor = true;
            this.buttonSog.Click += new System.EventHandler(this.buttonSog_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ResNr,
            this.Navn,
            this.Pris_Pr_Dag,
            this.Start_Dato,
            this.Slut_Dato});
            this.dataGridView1.Location = new System.Drawing.Point(20, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // ResNr
            // 
            this.ResNr.HeaderText = "Res Nr.";
            this.ResNr.Name = "ResNr";
            this.ResNr.ReadOnly = true;
            // 
            // Navn
            // 
            this.Navn.HeaderText = "Navn";
            this.Navn.Name = "Navn";
            this.Navn.ReadOnly = true;
            // 
            // Pris_Pr_Dag
            // 
            this.Pris_Pr_Dag.HeaderText = "Pris pr dag";
            this.Pris_Pr_Dag.Name = "Pris_Pr_Dag";
            this.Pris_Pr_Dag.ReadOnly = true;
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
            // buttonKvitering
            // 
            this.buttonKvitering.Location = new System.Drawing.Point(671, 393);
            this.buttonKvitering.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKvitering.Name = "buttonKvitering";
            this.buttonKvitering.Size = new System.Drawing.Size(107, 42);
            this.buttonKvitering.TabIndex = 4;
            this.buttonKvitering.Text = "Kvitering";
            this.buttonKvitering.UseVisualStyleBackColor = true;
            // 
            // buttonFaktura
            // 
            this.buttonFaktura.Location = new System.Drawing.Point(556, 393);
            this.buttonFaktura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonFaktura.Name = "buttonFaktura";
            this.buttonFaktura.Size = new System.Drawing.Size(107, 42);
            this.buttonFaktura.TabIndex = 5;
            this.buttonFaktura.Text = "Faktura";
            this.buttonFaktura.UseVisualStyleBackColor = true;
            // 
            // Sog_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 490);
            this.Controls.Add(this.buttonFaktura);
            this.Controls.Add(this.buttonKvitering);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSog);
            this.Controls.Add(this.textBoxOrdreNr);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Sog_Ordre";
            this.Text = "Sog_Ordre";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOrdreNr;
        private System.Windows.Forms.Button buttonSog;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKvitering;
        private System.Windows.Forms.Button buttonFaktura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Navn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pris_Pr_Dag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Start_Dato;
        private System.Windows.Forms.DataGridViewTextBoxColumn Slut_Dato;
    }
}