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
  
}
