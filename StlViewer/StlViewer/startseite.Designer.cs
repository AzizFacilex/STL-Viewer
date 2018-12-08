namespace StlViewer
{
    partial class startseite
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Safefilename = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Bestaetigen = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Safefilename
            // 
            this.Safefilename.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Safefilename.Location = new System.Drawing.Point(226, 160);
            this.Safefilename.Name = "Safefilename";
            this.Safefilename.Size = new System.Drawing.Size(348, 28);
            this.Safefilename.TabIndex = 3;
            // 
            // FileName
            // 
            this.FileName.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.Location = new System.Drawing.Point(226, 220);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(481, 30);
            this.FileName.TabIndex = 4;
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(226, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 55);
            this.button1.TabIndex = 5;
            this.button1.Text = "Datei auswählen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bestaetigen
            // 
            this.Bestaetigen.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bestaetigen.Location = new System.Drawing.Point(500, 312);
            this.Bestaetigen.Name = "Bestaetigen";
            this.Bestaetigen.Size = new System.Drawing.Size(207, 55);
            this.Bestaetigen.TabIndex = 6;
            this.Bestaetigen.Text = "Bestätigen";
            this.Bestaetigen.UseVisualStyleBackColor = true;
            this.Bestaetigen.Click += new System.EventHandler(this.Bestaetigen_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Default",
            "Rot",
            "Grün",
            "Blau"});
            this.comboBox1.Location = new System.Drawing.Point(586, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.Text = "Farbe";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Bestaetigen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Safefilename);
            this.Name = "startseite";
            this.Size = new System.Drawing.Size(928, 496);
            this.Load += new System.EventHandler(this.startseite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Safefilename;
        private System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bestaetigen;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
