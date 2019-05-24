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
            this.buttonKvitering = new System.Windows.Forms.Button();
            this.buttonFaktura = new System.Windows.Forms.Button();
            this.søgToolStrip = new System.Windows.Forms.ToolStrip();
            this.ordreNummerToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ordreNummerToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.søgToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lejeOrdreLinjerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delpinasDataSet2 = new Delpin.delpinasDataSet2();
            this.lejeOrdreLinjerTableAdapter = new Delpin.delpinasDataSet2TableAdapters.LejeOrdreLinjerTableAdapter();
            this.resnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resnavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slutDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.søgToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.resnrDataGridViewTextBoxColumn,
            this.resnavnDataGridViewTextBoxColumn,
            this.startDatoDataGridViewTextBoxColumn,
            this.slutDatoDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lejeOrdreLinjerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(20, 41);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(757, 345);
            this.dataGridView1.TabIndex = 3;
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
            // søgToolStrip
            // 
            this.søgToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.søgToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.søgToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordreNummerToolStripLabel,
            this.ordreNummerToolStripTextBox,
            this.søgToolStripButton});
            this.søgToolStrip.Location = new System.Drawing.Point(20, 10);
            this.søgToolStrip.Name = "søgToolStrip";
            this.søgToolStrip.Size = new System.Drawing.Size(261, 27);
            this.søgToolStrip.TabIndex = 6;
            this.søgToolStrip.Text = "søgToolStrip";
            // 
            // ordreNummerToolStripLabel
            // 
            this.ordreNummerToolStripLabel.Name = "ordreNummerToolStripLabel";
            this.ordreNummerToolStripLabel.Size = new System.Drawing.Size(108, 24);
            this.ordreNummerToolStripLabel.Text = "OrdreNummer:";
            // 
            // ordreNummerToolStripTextBox
            // 
            this.ordreNummerToolStripTextBox.Name = "ordreNummerToolStripTextBox";
            this.ordreNummerToolStripTextBox.Size = new System.Drawing.Size(100, 27);
            // 
            // søgToolStripButton
            // 
            this.søgToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.søgToolStripButton.Name = "søgToolStripButton";
            this.søgToolStripButton.Size = new System.Drawing.Size(39, 24);
            this.søgToolStripButton.Text = "Søg";
            this.søgToolStripButton.Click += new System.EventHandler(this.søgToolStripButton_Click);
            // 
            // lejeOrdreLinjerBindingSource
            // 
            this.lejeOrdreLinjerBindingSource.DataMember = "LejeOrdreLinjer";
            this.lejeOrdreLinjerBindingSource.DataSource = this.delpinasDataSet2;
            // 
            // delpinasDataSet2
            // 
            this.delpinasDataSet2.DataSetName = "delpinasDataSet2";
            this.delpinasDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lejeOrdreLinjerTableAdapter
            // 
            this.lejeOrdreLinjerTableAdapter.ClearBeforeFill = true;
            // 
            // resnrDataGridViewTextBoxColumn
            // 
            this.resnrDataGridViewTextBoxColumn.DataPropertyName = "resnr";
            this.resnrDataGridViewTextBoxColumn.HeaderText = "resnr";
            this.resnrDataGridViewTextBoxColumn.Name = "resnrDataGridViewTextBoxColumn";
            // 
            // resnavnDataGridViewTextBoxColumn
            // 
            this.resnavnDataGridViewTextBoxColumn.DataPropertyName = "resnavn";
            this.resnavnDataGridViewTextBoxColumn.HeaderText = "resnavn";
            this.resnavnDataGridViewTextBoxColumn.Name = "resnavnDataGridViewTextBoxColumn";
            // 
            // startDatoDataGridViewTextBoxColumn
            // 
            this.startDatoDataGridViewTextBoxColumn.DataPropertyName = "startDato";
            this.startDatoDataGridViewTextBoxColumn.HeaderText = "startDato";
            this.startDatoDataGridViewTextBoxColumn.Name = "startDatoDataGridViewTextBoxColumn";
            // 
            // slutDatoDataGridViewTextBoxColumn
            // 
            this.slutDatoDataGridViewTextBoxColumn.DataPropertyName = "slutDato";
            this.slutDatoDataGridViewTextBoxColumn.HeaderText = "slutDato";
            this.slutDatoDataGridViewTextBoxColumn.Name = "slutDatoDataGridViewTextBoxColumn";
            // 
            // prisDataGridViewTextBoxColumn
            // 
            this.prisDataGridViewTextBoxColumn.DataPropertyName = "pris";
            this.prisDataGridViewTextBoxColumn.HeaderText = "pris";
            this.prisDataGridViewTextBoxColumn.Name = "prisDataGridViewTextBoxColumn";
            // 
            // Sog_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 490);
            this.Controls.Add(this.søgToolStrip);
            this.Controls.Add(this.buttonFaktura);
            this.Controls.Add(this.buttonKvitering);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sog_Ordre";
            this.Text = "Sog_Ordre";
            this.Load += new System.EventHandler(this.Sog_Ordre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.søgToolStrip.ResumeLayout(false);
            this.søgToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonKvitering;
        private System.Windows.Forms.Button buttonFaktura;
        private delpinasDataSet2 delpinasDataSet2;
        private System.Windows.Forms.BindingSource lejeOrdreLinjerBindingSource;
        private delpinasDataSet2TableAdapters.LejeOrdreLinjerTableAdapter lejeOrdreLinjerTableAdapter;
        private System.Windows.Forms.ToolStrip søgToolStrip;
        private System.Windows.Forms.ToolStripLabel ordreNummerToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ordreNummerToolStripTextBox;
        private System.Windows.Forms.ToolStripButton søgToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn resnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
    }
}