using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;
using System.Windows.Forms;

namespace SNAKEfinale
{
    class Input
    {

        
        private static Hashtable keyTable = new Hashtable();
        //creiamo una tabella ash per ottimizzare gli inserimenti

        public static bool KeyPress( Keys key)
        {
            //questa funzione farà tornare una chiave alla classe
            if(keyTable[key]==null)
            {
                //se la tabella è vuota ritorna falso
                return false;
            }
            //se la tabella sh non è vuota ritornerà vero
            return (bool)keyTable[key];


        }

        public static void changeState(Keys key,bool state)
        {
            //questa funzione cambierà lo satto della chiave e del giocatore
            //inoltre ha due argomenti, chiave e stato
            keyTable[key] = state;


        }

    

    }
}
