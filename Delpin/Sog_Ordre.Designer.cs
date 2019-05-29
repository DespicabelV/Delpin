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
            this.ordrenrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resnrDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resnavnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.slutDatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lejeOrdreLinjerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.delpinasDataSetSog_Ordre = new Delpin.delpinasDataSetSog_Ordre();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonFaktura = new System.Windows.Forms.Button();
            this.buttonKvittering = new System.Windows.Forms.Button();
            this.søgToolStrip = new System.Windows.Forms.ToolStrip();
            this.ordreNummerToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.ordreNummerToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.søgToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lejeOrdreLinjerTableAdapter = new Delpin.delpinasDataSetSog_OrdreTableAdapters.LejeOrdreLinjerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSetSog_Ordre)).BeginInit();
            this.søgToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ordrenrDataGridViewTextBoxColumn,
            this.resnrDataGridViewTextBoxColumn,
            this.resnavnDataGridViewTextBoxColumn,
            this.startDatoDataGridViewTextBoxColumn,
            this.slutDatoDataGridViewTextBoxColumn,
            this.prisDataGridViewTextBoxColumn,
            this.iDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lejeOrdreLinjerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(954, 251);
            this.dataGridView1.TabIndex = 0;
            // 
            // ordrenrDataGridViewTextBoxColumn
            // 
            this.ordrenrDataGridViewTextBoxColumn.DataPropertyName = "ordrenr";
            this.ordrenrDataGridViewTextBoxColumn.HeaderText = "ordrenr";
            this.ordrenrDataGridViewTextBoxColumn.Name = "ordrenrDataGridViewTextBoxColumn";
            this.ordrenrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resnrDataGridViewTextBoxColumn
            // 
            this.resnrDataGridViewTextBoxColumn.DataPropertyName = "resnr";
            this.resnrDataGridViewTextBoxColumn.HeaderText = "resnr";
            this.resnrDataGridViewTextBoxColumn.Name = "resnrDataGridViewTextBoxColumn";
            this.resnrDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // resnavnDataGridViewTextBoxColumn
            // 
            this.resnavnDataGridViewTextBoxColumn.DataPropertyName = "resnavn";
            this.resnavnDataGridViewTextBoxColumn.HeaderText = "resnavn";
            this.resnavnDataGridViewTextBoxColumn.Name = "resnavnDataGridViewTextBoxColumn";
            this.resnavnDataGridViewTextBoxColumn.ReadOnly = true;
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
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lejeOrdreLinjerBindingSource
            // 
            this.lejeOrdreLinjerBindingSource.DataMember = "LejeOrdreLinjer";
            this.lejeOrdreLinjerBindingSource.DataSource = this.delpinasDataSetSog_Ordre;
            // 
            // delpinasDataSetSog_Ordre
            // 
            this.delpinasDataSetSog_Ordre.DataSetName = "delpinasDataSetSog_Ordre";
            this.delpinasDataSetSog_Ordre.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(871, 369);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(95, 40);
            this.buttonUpdate.TabIndex = 1;
            this.buttonUpdate.Text = "Opdater";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonFaktura
            // 
            this.buttonFaktura.Location = new System.Drawing.Point(753, 369);
            this.buttonFaktura.Name = "buttonFaktura";
            this.buttonFaktura.Size = new System.Drawing.Size(95, 40);
            this.buttonFaktura.TabIndex = 2;
            this.buttonFaktura.Text = "Faktura";
            this.buttonFaktura.UseVisualStyleBackColor = true;
            // 
            // buttonKvittering
            // 
            this.buttonKvittering.Location = new System.Drawing.Point(622, 369);
            this.buttonKvittering.Name = "buttonKvittering";
            this.buttonKvittering.Size = new System.Drawing.Size(95, 40);
            this.buttonKvittering.TabIndex = 3;
            this.buttonKvittering.Text = "Kvittering";
            this.buttonKvittering.UseVisualStyleBackColor = true;
            // 
            // søgToolStrip
            // 
            this.søgToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.søgToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.søgToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordreNummerToolStripLabel,
            this.ordreNummerToolStripTextBox,
            this.søgToolStripButton});
            this.søgToolStrip.Location = new System.Drawing.Point(12, 23);
            this.søgToolStrip.Name = "søgToolStrip";
            this.søgToolStrip.Size = new System.Drawing.Size(261, 27);
            this.søgToolStrip.TabIndex = 4;
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
            // lejeOrdreLinjerTableAdapter
            // 
            this.lejeOrdreLinjerTableAdapter.ClearBeforeFill = true;
            // 
            // Sog_Ordre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 450);
            this.Controls.Add(this.søgToolStrip);
            this.Controls.Add(this.buttonKvittering);
            this.Controls.Add(this.buttonFaktura);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Sog_Ordre";
            this.Text = "Sog_Ordre";
            this.Load += new System.EventHandler(this.Sog_Ordre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lejeOrdreLinjerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delpinasDataSetSog_Ordre)).EndInit();
            this.søgToolStrip.ResumeLayout(false);
            this.søgToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private delpinasDataSetSog_Ordre delpinasDataSetSog_Ordre;
        private System.Windows.Forms.BindingSource lejeOrdreLinjerBindingSource;
        private delpinasDataSetSog_OrdreTableAdapters.LejeOrdreLinjerTableAdapter lejeOrdreLinjerTableAdapter;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonFaktura;
        private System.Windows.Forms.Button buttonKvittering;
        private System.Windows.Forms.ToolStrip søgToolStrip;
        private System.Windows.Forms.ToolStripLabel ordreNummerToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox ordreNummerToolStripTextBox;
        private System.Windows.Forms.ToolStripButton søgToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordrenrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resnrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resnavnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slutDatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
    }
}