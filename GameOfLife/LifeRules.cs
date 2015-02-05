namespace GameOfLife
{
    public class LifeRules
    {
        public CellState GetNewState(CellState currentState, int liveNeighbours)
        {
            return CellState.Alive;
        }
    }
}