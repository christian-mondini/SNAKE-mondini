namespace SNAKEfinale
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.esci = new System.Windows.Forms.Button();
            this.gioca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nomegiocatore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(436, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // esci
            // 
            this.esci.BackColor = System.Drawing.Color.Yellow;
            this.esci.Location = new System.Drawing.Point(539, 555);
            this.esci.Name = "esci";
            this.esci.Size = new System.Drawing.Size(186, 86);
            this.esci.TabIndex = 14;
            this.esci.Text = "ESCI";
            this.esci.UseVisualStyleBackColor = false;
            this.esci.Click += new System.EventHandler(this.esci_Click);
            // 
            // gioca
            // 
            this.gioca.BackColor = System.Drawing.Color.Yellow;
            this.gioca.Location = new System.Drawing.Point(539, 261);
            this.gioca.Name = "gioca";
            this.gioca.Size = new System.Drawing.Size(186, 84);
            this.gioca.TabIndex = 13;
            this.gioca.Text = "PLAY";
            this.gioca.UseVisualStyleBackColor = false;
            this.gioca.Click += new System.EventHandler(this.gioca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(414, 392);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(436, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "INSERIRE IL NOME DEL GIOCATORE:";
            // 
            // nomegiocatore
            // 
            this.nomegiocatore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.nomegiocatore.Location = new System.Drawing.Point(497, 446);
            this.nomegiocatore.Name = "nomegiocatore";
            this.nomegiocatore.Size = new System.Drawing.Size(282, 20);
            this.nomegiocatore.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.YellowGreen;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.nomegiocatore);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.esci);
            this.Controls.Add(this.gioca);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button esci;
        private System.Windows.Forms.Button gioca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomegiocatore;
    }
}

