namespace GameOfLife
{
    public class LifeRules
    {
        public CellState GetNewState(CellState currentState, int liveNeighbours)
        {
            if (liveNeighbours == 1)
            {
                return CellState.Dead;
            }
            return CellState.Alive;
        }
    }
}