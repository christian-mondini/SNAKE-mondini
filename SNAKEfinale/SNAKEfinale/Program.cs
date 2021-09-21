using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNAKEfinale
{
    static class Program
    {
        public static string percorsopunteggi = "";//creo una stringa per il percorso dei punteggi
        public static string globalString = "";//creo una stringa per il nome del giocatore
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
