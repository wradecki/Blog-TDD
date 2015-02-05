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

        [Fact]
        public void When_live_cell_has_fewer_than_two_live_neigtbours＿＿Then_return_dead()
        {
            var currentState = CellState.Alive;
            var sut = new LifeRules();

            var liveNeighbours = 1;
            CellState actual = sut.GetNewState(currentState, liveNeighbours);

            var expected = CellState.Dead;

            actual.Should().Be(expected);
        }
    }
}