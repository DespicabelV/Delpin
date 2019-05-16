namespace Delpin
{
    partial class Hovedmenu
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
            this.buttonDEB = new System.Windows.Forms.Button();
            this.buttonOrdre = new System.Windows.Forms.Button();
            this.buttonRedigerKunde = new System.Windows.Forms.Button();
            this.buttonRedigerRes = new System.Windows.Forms.Button();
            this.buttonRedigerOrdre = new System.Windows.Forms.Button();
            this.buttonLejeListe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDEB
            // 
            this.buttonDEB.Location = new System.Drawing.Point(101, 52);
            this.buttonDEB.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDEB.Name = "buttonDEB";
            this.buttonDEB.Size = new System.Drawing.Size(152, 60);
            this.buttonDEB.TabIndex = 0;
            this.buttonDEB.Text = "Opret DEB";
            this.buttonDEB.UseVisualStyleBackColor = true;
            this.buttonDEB.Click += new System.EventHandler(this.buttonDEB_Click);
            // 
            // buttonOrdre
            // 
            this.buttonOrdre.Location = new System.Drawing.Point(101, 144);
            this.buttonOrdre.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOrdre.Name = "buttonOrdre";
            this.buttonOrdre.Size = new System.Drawing.Size(152, 60);
            this.buttonOrdre.TabIndex = 1;
            this.buttonOrdre.Text = "Opret Ordre";
            this.buttonOrdre.UseVisualStyleBackColor = true;
            this.buttonOrdre.Click += new System.EventHandler(this.buttonOrdre_Click);
            // 
            // buttonRedigerKunde
            // 
            this.buttonRedigerKunde.Location = new System.Drawing.Point(261, 52);
            this.buttonRedigerKunde.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRedigerKunde.Name = "buttonRedigerKunde";
            this.buttonRedigerKunde.Size = new System.Drawing.Size(152, 60);
            this.buttonRedigerKunde.TabIndex = 2;
            this.buttonRedigerKunde.Text = "Søg/Rediger Kunde";
            this.buttonRedigerKunde.UseVisualStyleBackColor = true;
            this.buttonRedigerKunde.Click += new System.EventHandler(this.buttonRedigerKunde_Click);
            // 
            // buttonRedigerRes
            // 
            this.buttonRedigerRes.Location = new System.Drawing.Point(261, 144);
            this.buttonRedigerRes.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRedigerRes.Name = "buttonRedigerRes";
            this.buttonRedigerRes.Size = new System.Drawing.Size(152, 60);
            this.buttonRedigerRes.TabIndex = 3;
            this.buttonRedigerRes.Text = "Søg/Rediger RES";
            this.buttonRedigerRes.UseVisualStyleBackColor = true;
            this.buttonRedigerRes.Click += new System.EventHandler(this.buttonRedigerRes_Click);
            // 
            // buttonRedigerOrdre
            // 
            this.buttonRedigerOrdre.Location = new System.Drawing.Point(421, 52);
            this.buttonRedigerOrdre.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRedigerOrdre.Name = "buttonRedigerOrdre";
            this.buttonRedigerOrdre.Size = new System.Drawing.Size(152, 60);
            this.buttonRedigerOrdre.TabIndex = 4;
            this.buttonRedigerOrdre.Text = "Søg/Rediger Ordre";
            this.buttonRedigerOrdre.UseVisualStyleBackColor = true;
            this.buttonRedigerOrdre.Click += new System.EventHandler(this.buttonRedigerOrdre_Click);
            // 
            // buttonLejeListe
            // 
            this.buttonLejeListe.Location = new System.Drawing.Point(421, 144);
            this.buttonLejeListe.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLejeListe.Name = "buttonLejeListe";
            this.buttonLejeListe.Size = new System.Drawing.Size(152, 60);
            this.buttonLejeListe.TabIndex = 5;
            this.buttonLejeListe.Text = "Leje liste";
            this.buttonLejeListe.UseVisualStyleBackColor = true;
            this.buttonLejeListe.Click += new System.EventHandler(this.buttonLejeListe_Click);
            // 
            // Hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 313);
            this.Controls.Add(this.buttonLejeListe);
            this.Controls.Add(this.buttonRedigerOrdre);
            this.Controls.Add(this.buttonRedigerRes);
            this.Controls.Add(this.buttonRedigerKunde);
            this.Controls.Add(this.buttonOrdre);
            this.Controls.Add(this.buttonDEB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Hovedmenu";
            this.Text = "Hoved Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDEB;
        private System.Windows.Forms.Button buttonOrdre;
        private System.Windows.Forms.Button buttonRedigerKunde;
        private System.Windows.Forms.Button buttonRedigerRes;
        private System.Windows.Forms.Button buttonRedigerOrdre;
        private System.Windows.Forms.Button buttonLejeListe;
    }
}

