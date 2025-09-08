using System;
using System.Threading;

namespace Ucu.Poo.GameOfLife;
using System.Text;

using System.IO;
public class Board //------------------------------------------------------------
{
    public bool[,] leer_archivo()
    {
        string url = "board.txt"; //Ubicacion de board.txt
        string content = File.ReadAllText(url); //Abrimos board.txt 
        string[] contentLines = content.Split('\n'); //Separamos en lineas
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length]; //Contamos número de lineas y su largo
        for (int  y=0; y<contentLines.Length;y++) //Por cada línea
        {
            for (int x=0; x<contentLines[y].Length; x++) //Por cada carácter
            {
                if(contentLines[y][x]=='1')// Si encotramos un 1 en esa posición 
                {
                    board[x,y]=true; 
                }
            }
        }
        return board; 
    }

    public void Print(bool[,] tablero_,Cell celulas)//Mostrar tablero
    {
     
        while (true) //Bucle infinito
        {
            bool[,] tablero = tablero_;
            int width = tablero.GetLength(0);//variabe que representa el ancho del tablero
            int height = tablero.GetLength(1); 
            Console.Clear();
            StringBuilder s = new StringBuilder();
            for (int y = 0; y<height;y++) //revisamos el eje Y
            {
                for (int x = 0; x<width; x++) //revisamos el eje X
                {
                    if(tablero[x,y]) //Si true:
                    {
                        s.Append("|X|");
                    }
                    else //Si false:
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n"); //saltamos a la siguiente linea
            }
            Console.WriteLine(s.ToString()); //Imprimimos tablero
            tablero_ = celulas.NextGeneration(); //Igualamos tablero_ a cloneboard
            Thread.Sleep(300); //Ponemos un delay
        }
    }
}//---------------------------------------------------------------------------------