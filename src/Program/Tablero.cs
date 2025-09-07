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

}//---------------------------------------------------------------------------------