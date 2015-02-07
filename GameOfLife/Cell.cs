namespace GameOfLife
{
    public class Cell
    {
        public CellState State { private set; get; }

        public Cell(CellState state)
        {
            State = state;
        }
    }
}