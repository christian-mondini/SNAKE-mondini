using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SNAKEfinale
{
    public partial class Form2 : Form
    {
        private List<Circle> Snake = new List<Circle>();//crea un array per il serpente
        private Circle cibo = new Circle();//crea un solo cerchio cioè la mela
        string nomefile = @"classifica.txt";
        

        public Form2()
        {
            InitializeComponent();
            nome2.Text= Program.globalString;//scrivo il nome del giocatore nella schermata di gioco
            new Settings();//collega la classe Settings a questo form
            gameTimer.Interval = 1000 / Settings.Velocità;//collego il timer alla valocità del serpente
            gameTimer.Tick += updateScreen;//collegare a updateScreen la funzione tempo
            gameTimer.Start();//Starta il timer
            startGame();//richiama la funzione che da inizio al gioco
            Program.percorsopunteggi = AppDomain.CurrentDomain.BaseDirectory + nomefile;//aggiungo il file alla directory corrente
            Lista();//richiamo la funzione lista
            record.Text = trofeo.ToString();//aggiungo al il punteggio del giocatore

        }

        private void controlloesistenzafile()
        {
            if(!File.Exists(Program.percorsopunteggi))
            {
                using(StreamWriter sw = File.CreateText(Program.percorsopunteggi)) { }
            }
        }

        private void Lista()
        {
            var lista = File.ReadAllLines(Program.percorsopunteggi);
            for (int i = 0; i < lista.ToArray().Length; i++)//controlla se il record è già stato superato o meno e d in caso lo sostituisce
            {
                if (lista.ToArray()[i] != "")
                {
                    string[] numeri = lista.ToArray()[i].Split(',');//divide il primo elemento dal secondo

                    if (i == 0)
                    {
                        trofeo = Convert.ToInt32(numeri[1]);
                    }
                    else
                    {
                        if (trofeo < Convert.ToInt32(numeri[1]))
                        {
                            trofeo = Convert.ToInt32(numeri[1]);
                        }
                    }
                }
               
            }
        }
        
        int trofeo = 0;//creo il record di punteggi

        bool giocatoregiaTrovato = false;//serve nel caso abbiama già trovato il giocatore, me il suo punteggio è minore del record che quel giocatore aveva fatto in precedenza

        private void controlloPunteggigiocatore()
        {
            
                var Punteggi = File.ReadAllLines(Program.percorsopunteggi);
                if (Punteggi.ToArray().Length != 0)
                {
                    for (int i = 0; i < Punteggi.ToArray().Length; i++)
                    {
                        string[] dettagligiocatore = Punteggi[i].Split(',');
                        if (nome2.Text == dettagligiocatore[0])
                        {
                            if (Convert.ToInt32(punteggio) > Convert.ToInt32(dettagligiocatore[1]))
                            {
                                dettagligiocatore[1] = punteggio.ToString();
                                Punteggi[i] = $"{dettagligiocatore[0]},{dettagligiocatore[1]}";
                                File.WriteAllLines(Program.percorsopunteggi, Punteggi);
                            }
                            else
                            {
                                giocatoregiaTrovato = true;
                            }
                        }
                        else
                        {
                            if (i == Punteggi.ToArray().Length - 1 && giocatoregiaTrovato == false)
                            {
                                nuovoGiocatore(Punteggi.ToArray());
                            }
                        }
                    }
                }
            
        }
        private void nuovoGiocatore(string[] punteggi)
        {
            Array.Resize(ref punteggi, punteggi.Length + 1);
            punteggi[punteggi.Length - 1] = $"{nome2},{punteggi}";
            File.WriteAllLines(Program.percorsopunteggi, punteggi);
            
        }
       


        bool sinistra = false, destra = false, sopra = false, sotto = false;//creo variabili epr il movimento della testa
        
        private void timersnake_Tick(object sender, EventArgs e)//collego al timer della testa del serpente i suoi movimenti 
        {
            movimentotesta();
        }
        

        
        private void movimentotesta()//movimenti della testa del serpente
        {

            if(sopra)
            {
                testas.Top -= 30;
            }
            if (sotto)
            {
                testas.Top += 30;
            }
            if (sinistra)
            {
                testas.Left -= 30;
            }
             if(destra)
            {
                testas.Left += 30;
            }

        }

        private void updateScreen(object sender, EventArgs e)//
        {

            //se il gioco è finito ed il giocatore preme enter ricomincia il gioco
            if (Settings.GameOver == true)
            {
                if (Input.KeyPress(Keys.Enter))
                {
                    startGame();
                }
            }
            else
            {
                //movimenti del serpente
                if (Input.KeyPress(Keys.D) && Settings.direzione != Directions.sinistra)
                {
                    Settings.direzione = Directions.destra;

                    testas.Image = Properties.Resources.testadestra;//collego il giramento della testa ed i suoi movimenti ai movimenti del corpo
                    destra = true;
                    sinistra = false;
                    sotto = false;
                    sopra = false;


                }
                else if (Input.KeyPress(Keys.A) && Settings.direzione != Directions.destra)
                {
                    Settings.direzione = Directions.sinistra;

                    testas.Image = Properties.Resources.testasinistra;
                    destra = false;
                    sinistra = true;
                    sotto = false;
                    sopra = false;

                }
                else if (Input.KeyPress(Keys.S) && Settings.direzione != Directions.sopra)
                {
                    Settings.direzione = Directions.sotto;

                    testas.Image = Properties.Resources.testagiu;
                    destra = false;
                    sinistra = false;
                    sotto = true;
                    sopra = false;

                }
                else if (Input.KeyPress(Keys.W) && Settings.direzione != Directions.sotto)
                {
                    Settings.direzione = Directions.sopra;

                    testas.Image = Properties.Resources.testasu;
                    destra = false;
                    sinistra = false;
                    sotto = false;
                    sopra = true;

                }

                movimenti();//utilizza la funzione movimento

            }
            campo.Invalidate();//refresha il campo

        }

            private void movimenti()
        {
            //il ciclo principale per la testa e le parti del serpente
            for(int i=Snake.Count-1;i>=0;i--)//finchè la testa del serpente contina ad esistere 
            {
                if (i==0)//se esiste la testa del serpente
                {

                    //muove tutto il corpo in accordo con le direzioni della testa
                    switch(Settings.direzione)
                    {
                        case Directions.destra:
                            Snake[i].X++;
                            break;
                        case Directions.sinistra:
                            Snake[i].X--;
                            break;
                        case Directions.sopra:
                            Snake[i].Y--;
                            break;
                        case Directions.sotto:
                            Snake[i].Y++;
                            break;

                    }

                    //restringe i movimenti del serpente all'interno del campo
                    int maxXpos = campo.Size.Width / Settings.larghezza;
                    int maxYpos = campo.Size.Height / Settings.altezza;

                    if(Snake[i].X<0 || Snake[i].Y<0|| Snake[i].X >maxXpos|| Snake[i].Y > maxYpos)
                    {
                        //finisce il gioco
                        morte();//richiamo la funzione morte
                    }
                    //rileva le collisioni col corpo del serpente
                    for(int j=1;j<Snake.Count; j++)
                    {
                        if(Snake[i].X==Snake[j].X && Snake[i].Y == Snake[j].Y)
                        {
                            //finisce il gioco
                            morte();
                        }

                    }
                    //rileva le collisioni tra testa del serpente e cibo
                    if(Snake[0].X==cibo.X && Snake[0].Y == cibo.Y)
                    {
                        //mangia il cibo
                        mangia();
                    }
                    

                }
                else
                {
                    //se non c'è alcun tipo di collisione il serpente continua a muoversi
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;

                }
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            //questo evento cambia lo stato dellaclasse input
            Input.changeState(e.KeyCode, true);

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            //questo evento cambia lo stato dellaclasse input
            Input.changeState(e.KeyCode, false);
        }

       

        private void startGame()
        {
            //questa funzione fà iniziare il gioco
            new Settings();
            Snake.Clear();//azzera l'array del serpente
            Circle testa = new Circle { X = 10, Y = 5 };//crea la testa del serpente            
            Snake.Add(testa);//aggiunge la testa all'array del serpente
            sotto = true;//direzione di partenza il basso
            punteggio.Text = Settings.segnalino.ToString();//mostra il punteggio
            generacibo();
           
        }
        
        private void generacibo()
        {
            int maxXpos = campo.Size.Width / Settings.larghezza;//setta il massimo spazio in cui possono spawnare le mele
            int maxYpos = campo.Size.Height / Settings.altezza;
            Random rnd = new Random();
            //crea il cibo in un punto random
            int melax = rnd.Next(0, maxXpos);
            int melay = rnd.Next(0, maxYpos);
            cibo =new Circle { X=melax ,Y=melay};//crea la mela in un punto random
            //mela.Location = new Point(melax, melay);

        }
        private void mangia()
        {
            //aggiunge una parte di corpo
            Circle corpo = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].X
             };
            Snake.Add(corpo);
            Settings.segnalino += Settings.punti;//aumenta il punteggio
            punteggio.Text = Settings.segnalino.ToString();
            generacibo();//genera altro cibo dopo che veine amngiato
            
        }

        

        private void morte()
        {
            //cambia la variabile booleana gameover in vero finendo il gioco
            Settings.GameOver = true;
            salvataggiopunteggi();
            controlloPunteggigiocatore();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            gameTimer.Start();//serve a far ricominciare il gioco
            timersnake.Start();

        }

        private void home_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();//serve a farti tornare alla home
            home.Show();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void salvataggiopunteggi()
        {
            var classificapunt = File.ReadAllLines(Program.percorsopunteggi);
            

        }

        private void pausa_Click(object sender, EventArgs e)
        {
            gameTimer.Stop(); //mette in pausa il gioco
            timersnake.Stop();
           
        }

        private void updateGraphics(object sender, PaintEventArgs e)
        {
            //qui è dove vedremo il serpetne muoversi
            Graphics campo = e.Graphics;//crea una nuova classe grafica chiamata campo

            if (Settings.GameOver == false)
            {
                //se il gioco non è finito continua
                Brush coloreserpente;//crea una nuova brush classe chiamata coloreserpente
                //un ciclo che controlla le parti del serpente
                for (int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                    {
                        //colora la testa del serpente
                        coloreserpente = Brushes.LightGreen;

                    }
                    else
                    {
                        //colora il corpo del serpente
                        coloreserpente = Brushes.Green;


                    }

                    //disegna la testa ed il corpo del serpente
                    campo.FillEllipse(coloreserpente,
                        new Rectangle(
                        Snake[i].X * Settings.larghezza,
                        Snake[i].Y * Settings.altezza,
                        Settings.larghezza, Settings.altezza));

                    //disegna il cibo
                    campo.FillEllipse(Brushes.Red,
                        new Rectangle(
                            cibo.X * Settings.larghezza,
                            cibo.Y * Settings.altezza,
                            Settings.larghezza, Settings.altezza));
                }

            }
            else
            {
                //questa parte arriverà se il gioco è finito
                Form4 fine = new Form4();
                fine.Show();
                this.Close();
            }

        }
    }
}
