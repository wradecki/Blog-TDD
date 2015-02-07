namespace GameOfLife
{
    public class Cell
    {
        public static Cell Alive
        {
            get { return _alive; }
        }

        public static Cell Dead
        {
            get { return _dead; }
        }

        private static readonly Cell _alive = new Cell(CellState.Alive);
        private static readonly Cell _dead = new Cell(CellState.Dead);

        public CellState State { private set; get; }

        protected Cell(CellState state)
        {
            State = state;
        }

        public Cell Evolve(int liveNeighbours)
        {
            if (liveNeighbours == 3)
            {
                return Alive;
            }
            if (liveNeighbours == 2)
            {
                return this;
            }
            return Dead;
        }
    }
}