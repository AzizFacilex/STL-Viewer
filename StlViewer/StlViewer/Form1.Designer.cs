namespace StlViewer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Sidepanel = new System.Windows.Forms.Panel();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Bestaetigen = new System.Windows.Forms.Button();
            this.Safefilename = new System.Windows.Forms.TextBox();
            this.FileName = new System.Windows.Forms.TextBox();
            this.startseite1 = new StlViewer.startseite();
            this.entwicklerseite1 = new StlViewer.Entwicklerseite();
            this.hilfe1 = new StlViewer.Hilfe();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.Sidepanel);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 585);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Sidepanel
            // 
            this.Sidepanel.BackColor = System.Drawing.Color.Black;
            this.Sidepanel.Location = new System.Drawing.Point(0, 163);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(21, 73);
            this.Sidepanel.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(3, 253);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(194, 73);
            this.button5.TabIndex = 4;
            this.button5.Text = "Hilfe";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(3, 433);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(194, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "Beenden";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(6, 343);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 73);
            this.button3.TabIndex = 2;
            this.button3.Text = "Entwickler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(3, 163);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 73);
            this.button2.TabIndex = 1;
            this.button2.Text = "Startseite";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "STL Viewer";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(765, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 52);
            this.button1.TabIndex = 6;
            this.button1.Text = "Datei auswählen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Bestaetigen
            // 
            this.Bestaetigen.Location = new System.Drawing.Point(789, 279);
            this.Bestaetigen.Name = "Bestaetigen";
            this.Bestaetigen.Size = new System.Drawing.Size(207, 55);
            this.Bestaetigen.TabIndex = 7;
            this.Bestaetigen.Text = "Bestätigen";
            this.Bestaetigen.UseVisualStyleBackColor = true;
            // 
            // Safefilename
            // 
            this.Safefilename.Location = new System.Drawing.Point(416, 222);
            this.Safefilename.Name = "Safefilename";
            this.Safefilename.Size = new System.Drawing.Size(272, 22);
            this.Safefilename.TabIndex = 8;
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(407, 303);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(334, 22);
            this.FileName.TabIndex = 9;
            // 
            // startseite1
            // 
            this.startseite1.BackColor = System.Drawing.Color.LightSlateGray;
            this.startseite1.Location = new System.Drawing.Point(193, 0);
            this.startseite1.Name = "startseite1";
            this.startseite1.Size = new System.Drawing.Size(894, 585);
            this.startseite1.TabIndex = 10;
            this.startseite1.Load += new System.EventHandler(this.startseite1_Load_1);
            // 
            // entwicklerseite1
            // 
            this.entwicklerseite1.BackColor = System.Drawing.Color.LightSlateGray;
            this.entwicklerseite1.Location = new System.Drawing.Point(193, 0);
            this.entwicklerseite1.Name = "entwicklerseite1";
            this.entwicklerseite1.Size = new System.Drawing.Size(894, 545);
            this.entwicklerseite1.TabIndex = 11;
            // 
            // hilfe1
            // 
            this.hilfe1.BackColor = System.Drawing.Color.LightSlateGray;
            this.hilfe1.Location = new System.Drawing.Point(203, 0);
            this.hilfe1.Name = "hilfe1";
            this.hilfe1.Size = new System.Drawing.Size(884, 585);
            this.hilfe1.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 585);
            this.Controls.Add(this.hilfe1);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.Safefilename);
            this.Controls.Add(this.Bestaetigen);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.entwicklerseite1);
            this.Controls.Add(this.startseite1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "STL Viewer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Bestaetigen;
        private System.Windows.Forms.TextBox Safefilename;
        private System.Windows.Forms.TextBox FileName;
        private startseite startseite1;
        private Entwicklerseite entwicklerseite1;
        private System.Windows.Forms.Button button5;
        private Hilfe hilfe1;
        private System.Windows.Forms.Panel Sidepanel;
    }
}

