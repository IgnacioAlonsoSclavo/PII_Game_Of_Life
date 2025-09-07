using Ucu.Poo.GameOfLife;

Board Tablero = new Board(); //Creamos una intancia de tablero
Cell Celulas = new Cell(Tablero.leer_archivo()); //Creamos una intancia de celulas
Tablero.Print(Tablero.leer_archivo(), Celulas); //Imprimos el tablero