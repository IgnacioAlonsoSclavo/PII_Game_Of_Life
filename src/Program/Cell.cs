namespace Ucu.Poo.GameOfLife;
public class Cell
{ //Atributos: 
    private bool[,] _gameBoard; //Tablero
   
    //-------Constructor de la clase Cell------------
    public Cell(bool[,] initialBoard) 
    {
        _gameBoard = initialBoard;  //Tablero inicial
    }
    //----------------------------------------------------
    public bool[,] NextGeneration() //----Metodo proxima gen---
    {
        //------Asignacion de dimensiones y medidas-----------
        int boardWidth = _gameBoard.GetLength(0);
        int boardHeight = _gameBoard.GetLength(1);
        //---------------Copia del tablero--------------------
        bool[,] cloneboard = new bool[boardWidth, boardHeight];
        //-------------Revisamos vecinos vivos----------------
        for (int x = 0; x < boardWidth; x++) //Revisamos desde 0 hasta el ancho del tablero
        {
            for (int y = 0; y < boardHeight; y++) //Revisamos desde 0 hasta la altura del tablero
            {
                int aliveNeighbors = 0; //Inicializamos los vecinos vivos en 0
                for (int i = x - 1; i <= x + 1; i++) //Revisamos x-1 hasta x+1 por vecinos
                {
                    for (int j = y - 1; j <= y + 1; j++) //Revisamos y-1 hasta y+1 por vecinos
                    {
                        if (i >= 0 && i < boardWidth && j >= 0 && j < boardHeight &&
                            _gameBoard[i, j]) //Si no salimos de los bordes y encontramos un 1:
                        {
                            aliveNeighbors++;
                        }
                    }
                }
                //Falta terminar condicionales de vida o muerte...
                
            }
        }
    }