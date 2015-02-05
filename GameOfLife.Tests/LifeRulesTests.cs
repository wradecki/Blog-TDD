using FluentAssertions;
using Xunit;

namespace GameOfLife.Tests
{
    public class LifeRulesTests
    {
        // When dead cell with exactly 3 live neightburs Then return alive
        [Fact]
        public void When_dead_cell_with_exactly_3_live_neightburs＿＿Then_return_alive()
        {
            CellState currentState = CellState.Dead;
            LifeRules sut = new LifeRules();
            var liveNeighbours = 3;

            CellState actual = sut.GetNewState(currentState, liveNeighbours);
            
            CellState expected = CellState.Alive;

            actual.Should().Be(expected);
        }
    }
}