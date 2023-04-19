using System;

namespace PII_Game_Of_Life;

    public class Logicadeljuego
    {
        public void aplicarLogica(bool[,]gameBoard,int boardWidth,int boardHeight)
        {
            for (int x = 0; x < boardWidth; x++)  
                {
                    for (int y = 0; y < boardHeight; y++)
                    {
                        int aliveNeighbors = 0;
                        for (int i = x-1; i<=x+1;i++)
                        {
                            for (int j = y-1;j<=y+1;j++)
                            {
                                if(i>=0 && i<boardWidth && j>=0 && j < boardHeight && gameBoard[i,j])
                                {
                                    aliveNeighbors++;
                                }
                            }
                        }
                        if(gameBoard[x,y])
                        {
                            aliveNeighbors--;
                        }
                        if (gameBoard[x,y] && aliveNeighbors < 2)
                        {
                            //Celula muere por baja población
                            gameBoard[x,y] = false;
                        }   
                        else if (gameBoard[x,y] && aliveNeighbors > 3)
                        {
                            //Celula muere por sobrepoblación
                            gameBoard[x,y] = false;
                        }
                        else if (!gameBoard[x,y] && aliveNeighbors == 3)
                        {
                            //Celula nace por reproducción
                            gameBoard[x,y] = true;
                        }
                    
    } 
}
        }
    }