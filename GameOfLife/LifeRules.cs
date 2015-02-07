namespace GameOfLife
{
    public class LifeRules
    {
        public Cell GetNewState(Cell currentCell, int liveNeighbours)
        {
            if (liveNeighbours == 3)
            {
                return new Cell(CellState.Alive);
            }
            if (liveNeighbours == 2)
            {
                return currentCell;
            }
            return new Cell(CellState.Dead);
        }
    }
}