using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace SNAKEfinale
{
    public enum Directions
    {
        //questa classe di enumerazione permette di creare variabili con un numero limitato di valori
        sinistra,
        destra,
        sopra,
        sotto,

    };
    class Settings
    {

        public static int larghezza { get; set; }//larghezza come classe intera
        public static int altezza  { get; set; }//altezza come classe intera
        public static int Velocità { get; set; }//velocità come classe intera
        public static int segnalino { get; set; }//punteggio come classe intera
        public static int punti { get; set; }//punti come classe intera
        public static bool GameOver { get; set; }//GameOvercome classe booleana
        public static Directions direzione { get; set; }//direzione come classe menzionata prima

        public Settings()
        {
            //queste sono le impostazioni di base
            larghezza = 30;//setta la larghezza a 16
            altezza = 30;//altezza settata a 16
            Velocità = 10;
            segnalino = 0;
            punti = 100;
            GameOver = false;
            direzione = Directions.sotto;//la direzione di default è il basso

            

        }
    }
}
