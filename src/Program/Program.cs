using System;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho=10;
            int Largo=10;

            DibujarTablero tablerodeprueba=new DibujarTablero(ancho,Largo);
            bool[,] b= tablerodeprueba.GenerarTablero();

            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<Largo;y++)
                {
                    for (int x = 0; x<ancho; x++)
                    {
                        if(b[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
        }
            Console.WriteLine(s.ToString());
            Thread.Sleep(300);
}
        }
    }
}
