using System;

namespace PII_Game_Of_Life;

public class DibujarTablero
{
    private string RutaArchivo;
 
    public int Ancho {get;set;}

    public int Largo {get;set;}

    public DibujarTablero(int ancho,int largo)
    {
        this.Ancho=ancho;
        this.Largo=largo;
    }
    public bool[,] GenerarTablero()
    {
        bool[,] board;

        if (RutaArchivo== null)
        {
            board=new bool[Ancho,Largo];

            Random posrandom=new Random();

            for (int x=0; x< Ancho; x++)
            {
                for (int y=0; y<Largo;y++)
                {
                    board[x,y]=posrandom.Next(2)==0;
                }
            }
        }

        else
        {
            Archivo nuevoarchivo=new Archivo();
            board=nuevoarchivo._Archivo(RutaArchivo);
        }

        Logicadeljuego logica=new Logicadeljuego();
        logica.aplicarLogica(board,Ancho,Largo);

        return board;
    }
}