namespace SNAKEfinale
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.punteggiofinale = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.esci = new System.Windows.Forms.Button();
            this.home = new System.Windows.Forms.Button();
            this.ricomincia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // punteggiofinale
            // 
            this.punteggiofinale.AutoSize = true;
            this.punteggiofinale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punteggiofinale.Location = new System.Drawing.Point(701, 223);
            this.punteggiofinale.Name = "punteggiofinale";
            this.punteggiofinale.Size = new System.Drawing.Size(0, 20);
            this.punteggiofinale.TabIndex = 20;
            this.punteggiofinale.Click += new System.EventHandler(this.punteggiofinale_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(421, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(392, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(404, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 26);
            this.label1.TabIndex = 18;
            this.label1.Text = "IL TUO PUNTEGGIO E\' DI:                   PUNTI";
            // 
            // esci
            // 
            this.esci.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.esci.Location = new System.Drawing.Point(524, 573);
            this.esci.Name = "esci";
            this.esci.Size = new System.Drawing.Size(186, 84);
            this.esci.TabIndex = 17;
            this.esci.Text = "ESCI";
            this.esci.UseVisualStyleBackColor = false;
            this.esci.Click += new System.EventHandler(this.esci_Click);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.home.Location = new System.Drawing.Point(524, 431);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(186, 84);
            this.home.TabIndex = 16;
            this.home.Text = "HOME";
            this.home.UseVisualStyleBackColor = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // ricomincia
            // 
            this.ricomincia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ricomincia.Location = new System.Drawing.Point(524, 290);
            this.ricomincia.Name = "ricomincia";
            this.ricomincia.Size = new System.Drawing.Size(186, 84);
            this.ricomincia.TabIndex = 15;
            this.ricomincia.Text = "RICOMINCIA";
            this.ricomincia.UseVisualStyleBackColor = false;
            this.ricomincia.Click += new System.EventHandler(this.ricomincia_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.punteggiofinale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.esci);
            this.Controls.Add(this.home);
            this.Controls.Add(this.ricomincia);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label punteggiofinale;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button esci;
        private System.Windows.Forms.Button home;
        private System.Windows.Forms.Button ricomincia;
    }
}