using FluentAssertions;
using Xunit;
using Xunit.Extensions;

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

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        public void When_live_cell_has_fewer_than_two_live_neigtbours＿＿Then_return_dead(int liveNeighbours)
        {
            var currentState = CellState.Alive;
            var sut = new LifeRules();
            CellState actual = sut.GetNewState(currentState, liveNeighbours);
            var expected = CellState.Dead;
            actual.Should().Be(expected);
        }

        // When live cell has 3 live neighbours Then return alive
        [Fact]
        public void When_live_cell_has_3_live_neighbours＿＿Then_return_alive()
        {
            CellState currentState = CellState.Alive;
            LifeRules sut = new LifeRules();
            var liveNeighbours = 3;

            CellState actual = sut.GetNewState(currentState, liveNeighbours);

            CellState expected = CellState.Alive;

            actual.Should().Be(expected);
        }

        // When live cell has 2 live neighbours Then return alive
        [Fact]
        public void When_live_cell_has_2_live_neighbours＿＿Then_return_alive()
        {
            CellState currentState = CellState.Alive;
            LifeRules sut = new LifeRules();
            var liveNeighbours = 2;

            CellState actual = sut.GetNewState(currentState, liveNeighbours);

            CellState expected = CellState.Alive;

            actual.Should().Be(expected);
        }


        [Fact]
        public void When_dead_cell_has_2_live_neighbours＿＿Then_return_alive()
        {
            CellState currentState = CellState.Dead;
            LifeRules sut = new LifeRules();
            var liveNeighbours = 2;

            CellState actual = sut.GetNewState(currentState, liveNeighbours);

            CellState expected = CellState.Dead;

            actual.Should().Be(expected);
        }

        // When live cell has more than 3 live neighbours Then return dead
        [Fact]
        public void When_live_cell_has_more_than_3_live_neighbours＿＿Then_return_dead()
        {
            var currentState = CellState.Dead;
            var sut = new LifeRules();
            var liveNeighbours = 4;

            CellState actual = sut.GetNewState(currentState, liveNeighbours);

            var expected = CellState.Dead;

            actual.Should().Be(expected);
        }
    }
}