using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SNAKEfinale
{
    class Circle
    {
        //creo le coordinate su cui si baseranno i movimenti del serpente
        public int X { get; set; }//numero int pubblico X
        public int Y { get; set; }//numero intero pubblico Y


        public Circle()
        {
            X = 0;//resettiamo le variabili pubbliche
            Y = 0;

        }
    }
}
