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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lejeOrdreLinjerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonKvitering = new System.Windows.Forms.Button();
            this.buttonFaktura = new System.Windows.Forms.Button();
            this.søgToolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ordreNummerToolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.ordreNummerToolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.søgToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lejeOrdreLinjerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.delpinasDataSet_Sog_Ordre = new Delpin.delpinasDataSet_Sog_Ordre();
            this.lejeOrdreLinjerTableAdapter = new Delpin.delpinasDataSet_Sog_OrdreTableAdapters.LejeOrdreLinjerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource)).BeginInit();
            this.søgToolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSet_Sog_Ordre)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridView1.DataSource = this.lejeOrdreLinjerBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(20, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 345);
            this.dataGridView1.TabIndex = 3;
            // 
            // lejeOrdreLinjerBindingSource
            // 
            this.lejeOrdreLinjerBindingSource.DataMember = "LejeOrdreLinjer";
            // 
            // buttonKvitering
            // 
            this.buttonKvitering.Location = new System.Drawing.Point(671, 393);
            this.buttonKvitering.Margin = new System.Windows.Forms.Padding(4);
            this.buttonKvitering.Name = "buttonKvitering";
            this.buttonKvitering.Size = new System.Drawing.Size(107, 42);
            this.buttonKvitering.TabIndex = 4;
            this.buttonKvitering.Text = "Kvitering";
            this.buttonKvitering.UseVisualStyleBackColor = true;
            // 
            // buttonFaktura
            // 
            this.buttonFaktura.Location = new System.Drawing.Point(556, 393);
            this.buttonFaktura.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFaktura.Name = "buttonFaktura";
            this.buttonFaktura.Size = new System.Drawing.Size(107, 42);
            this.buttonFaktura.TabIndex = 5;
            this.buttonFaktura.Text = "Faktura";
            this.buttonFaktura.UseVisualStyleBackColor = true;
            // 
            // søgToolStrip1
            // 
            this.søgToolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.søgToolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.søgToolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordreNummerToolStripLabel1,
            this.ordreNummerToolStripTextBox1,
            this.søgToolStripButton1});
            this.søgToolStrip1.Location = new System.Drawing.Point(20, 9);
            this.søgToolStrip1.Name = "søgToolStrip1";
            this.søgToolStrip1.Size = new System.Drawing.Size(261, 27);
            this.søgToolStrip1.TabIndex = 7;
            this.søgToolStrip1.Text = "søgToolStrip1";
            // 
            // ordreNummerToolStripLabel1
            // 
            this.ordreNummerToolStripLabel1.Name = "ordreNummerToolStripLabel1";
            this.ordreNummerToolStripLabel1.Size = new System.Drawing.Size(108, 24);
            this.ordreNummerToolStripLabel1.Text = "OrdreNummer:";
            // 
            // ordreNummerToolStripTextBox1
            // 
            this.ordreNummerToolStripTextBox1.Name = "ordreNummerToolStripTextBox1";
            this.ordreNummerToolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // søgToolStripButton1
            // 
            this.søgToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.søgToolStripButton1.Name = "søgToolStripButton1";
            this.søgToolStripButton1.Size = new System.Drawing.Size(39, 24);
            this.søgToolStripButton1.Text = "Søg";
            this.søgToolStripButton1.Click += new System.EventHandler(this.søgToolStripButton1_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "resnr";
            this.dataGridViewTextBoxColumn1.HeaderText = "resnr";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "startDato";
            this.dataGridViewTextBoxColumn2.HeaderText = "startDato";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "pris";
            this.dataGridViewTextBoxColumn3.HeaderText = "pris";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lejeOrdreLinjerBindingSource1
            // 
            this.lejeOrdreLinjerBindingSource1.DataMember = "LejeOrdreLinjer";
            this.lejeOrdreLinjerBindingSource1.DataSource = this.delpinasDataSet_Sog_Ordre;
            // 
            // delpinasDataSet_Sog_Ordre
            // 
            this.delpinasDataSet_Sog_Ordre.DataSetName = "delpinasDataSet_Sog_Ordre";
            this.delpinasDataSet_Sog_Ordre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lejeOrdreLinjerTableAdapter
            // 
            this.lejeOrdreLinjerTableAdapter.ClearBeforeFill = true;
            // 
            // Sog_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 490);
            this.Controls.Add(this.søgToolStrip1);
            this.Controls.Add(this.buttonFaktura);
            this.Controls.Add(this.buttonKvitering);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sog_Ordre";
            this.Text = "Sog_Ordre";
            this.Load += new System.EventHandler(this.Sog_Ordre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource)).EndInit();
            this.søgToolStrip1.ResumeLayout(false);
            this.søgToolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSet_Sog_Ordre)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKvitering;
        private System.Windows.Forms.Button buttonFaktura;
        private System.Windows.Forms.BindingSource lejeOrdreLinjerBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn resnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private delpinasDataSet_Sog_Ordre delpinasDataSet_Sog_Ordre;
        private System.Windows.Forms.BindingSource lejeOrdreLinjerBindingSource1;
        private delpinasDataSet_Sog_OrdreTableAdapters.LejeOrdreLinjerTableAdapter lejeOrdreLinjerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ToolStrip søgToolStrip1;
        private System.Windows.Forms.ToolStripLabel ordreNummerToolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox ordreNummerToolStripTextBox1;
        private System.Windows.Forms.ToolStripButton søgToolStripButton1;
    }
}