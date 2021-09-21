namespace SNAKEfinale
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel1 = new System.Windows.Forms.Panel();
            this.home = new System.Windows.Forms.PictureBox();
            this.riprendi = new System.Windows.Forms.PictureBox();
            this.punteggio = new System.Windows.Forms.Label();
            this.record = new System.Windows.Forms.Label();
            this.nome2 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pausa = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.timersnake = new System.Windows.Forms.Timer(this.components);
            this.campo = new System.Windows.Forms.Panel();
            this.testas = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riprendi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.campo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.testas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Controls.Add(this.home);
            this.panel1.Controls.Add(this.riprendi);
            this.panel1.Controls.Add(this.punteggio);
            this.panel1.Controls.Add(this.record);
            this.panel1.Controls.Add(this.nome2);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pausa);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 114);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // home
            // 
            this.home.BackColor = System.Drawing.Color.Transparent;
            this.home.Image = global::SNAKEfinale.Properties.Resources.home_snake;
            this.home.Location = new System.Drawing.Point(931, 24);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(79, 79);
            this.home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.home.TabIndex = 33;
            this.home.TabStop = false;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // riprendi
            // 
            this.riprendi.BackColor = System.Drawing.Color.Transparent;
            this.riprendi.Image = global::SNAKEfinale.Properties.Resources.riprendi_snake;
            this.riprendi.Location = new System.Drawing.Point(1207, 24);
            this.riprendi.Name = "riprendi";
            this.riprendi.Size = new System.Drawing.Size(79, 79);
            this.riprendi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.riprendi.TabIndex = 32;
            this.riprendi.TabStop = false;
            this.riprendi.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // punteggio
            // 
            this.punteggio.AutoSize = true;
            this.punteggio.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punteggio.Location = new System.Drawing.Point(124, 35);
            this.punteggio.Name = "punteggio";
            this.punteggio.Size = new System.Drawing.Size(109, 39);
            this.punteggio.TabIndex = 31;
            this.punteggio.Text = "label4";
            // 
            // record
            // 
            this.record.AutoSize = true;
            this.record.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.record.Location = new System.Drawing.Point(332, 35);
            this.record.Name = "record";
            this.record.Size = new System.Drawing.Size(0, 39);
            this.record.TabIndex = 30;
            // 
            // nome2
            // 
            this.nome2.AutoSize = true;
            this.nome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nome2.Location = new System.Drawing.Point(571, 35);
            this.nome2.Name = "nome2";
            this.nome2.Size = new System.Drawing.Size(109, 39);
            this.nome2.TabIndex = 29;
            this.nome2.Text = "label6";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(236, 24);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(71, 65);
            this.pictureBox6.TabIndex = 28;
            this.pictureBox6.TabStop = false;
            // 
            // pausa
            // 
            this.pausa.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pausa.BackgroundImage")));
            this.pausa.Location = new System.Drawing.Point(1064, 24);
            this.pausa.Name = "pausa";
            this.pausa.Size = new System.Drawing.Size(79, 79);
            this.pausa.TabIndex = 27;
            this.pausa.TabStop = false;
            this.pausa.Click += new System.EventHandler(this.pausa_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox8.BackgroundImage")));
            this.pictureBox8.Location = new System.Drawing.Point(44, 24);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(63, 65);
            this.pictureBox8.TabIndex = 26;
            this.pictureBox8.TabStop = false;
            // 
            // timersnake
            // 
            this.timersnake.Enabled = true;
            this.timersnake.Interval = 102;
            this.timersnake.Tick += new System.EventHandler(this.timersnake_Tick);
            // 
            // campo
            // 
            this.campo.BackgroundImage = global::SNAKEfinale.Properties.Resources.prato_fiori;
            this.campo.Controls.Add(this.testas);
            this.campo.Location = new System.Drawing.Point(234, 119);
            this.campo.Name = "campo";
            this.campo.Size = new System.Drawing.Size(857, 637);
            this.campo.TabIndex = 34;
            this.campo.Paint += new System.Windows.Forms.PaintEventHandler(this.updateGraphics);
            // 
            // testas
            // 
            this.testas.BackColor = System.Drawing.Color.Transparent;
            this.testas.Image = global::SNAKEfinale.Properties.Resources.testagiu;
            this.testas.Location = new System.Drawing.Point(292, 142);
            this.testas.Name = "testas";
            this.testas.Size = new System.Drawing.Size(30, 30);
            this.testas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.testas.TabIndex = 33;
            this.testas.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(1334, 774);
            this.Controls.Add(this.campo);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.home)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riprendi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pausa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.campo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.testas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label punteggio;
        private System.Windows.Forms.Label record;
        private System.Windows.Forms.Label nome2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pausa;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox testas;
        private System.Windows.Forms.Panel campo;
        private System.Windows.Forms.Timer timersnake;
        private System.Windows.Forms.PictureBox riprendi;
        private System.Windows.Forms.PictureBox home;
    }
}