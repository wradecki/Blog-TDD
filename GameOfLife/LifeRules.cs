namespace GameOfLife
{
    public class LifeRules
    {
        public Cell GetNewState(CellState currentState, int liveNeighbours)
        {
            if (liveNeighbours == 3)
            {
                return CellState.Alive;
            }
            if (liveNeighbours == 2)
            {
                return currentState;
            }
            return CellState.Dead;
        }
    }
}