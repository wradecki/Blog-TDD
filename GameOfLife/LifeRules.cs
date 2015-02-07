namespace GameOfLife
{
    public class LifeRules
    {
        public Cell GetNewState(Cell currentCell, int liveNeighbours)
        {
            return currentCell.Evolve(liveNeighbours);
        }
    }
}