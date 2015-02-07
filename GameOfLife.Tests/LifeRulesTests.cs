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
            var currentCell = new Cell(CellState.Dead);
            var sut = new LifeRules();
            var liveNeighbours = 3;

            Cell result = sut.GetNewState(currentCell, liveNeighbours);
            
            var expected = CellState.Alive;

            result.State.Should().Be(expected);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        public void When_live_cell_has_fewer_than_two_live_neigtbours＿＿Then_return_dead(int liveNeighbours)
        {
            var currentCell = new Cell(CellState.Alive);
            var sut = new LifeRules();
            Cell result = sut.GetNewState(currentCell, liveNeighbours);
            var expected = CellState.Dead;
            result.State.Should().Be(expected);
        }

        // When live cell has 3 live neighbours Then return alive
        [Fact]
        public void When_live_cell_has_3_live_neighbours＿＿Then_return_alive()
        {
            var currentCell = new Cell(CellState.Alive);
            var sut = new LifeRules();
            var liveNeighbours = 3;

            Cell result = sut.GetNewState(currentCell, liveNeighbours);

            var expected = CellState.Alive;

            result.State.Should().Be(expected);
        }

        // When live cell has 2 live neighbours Then return alive
        [Fact]
        public void When_live_cell_has_2_live_neighbours＿＿Then_return_alive()
        {
            var currentCel = new Cell(CellState.Alive);
            var sut = new LifeRules();
            var liveNeighbours = 2;

            Cell result = sut.GetNewState(currentCel, liveNeighbours);

            var expected = CellState.Alive;

            result.State.Should().Be(expected);
        }


        [Fact]
        public void When_dead_cell_has_2_live_neighbours＿＿Then_return_alive()
        {
            Cell currentCell = new Cell(CellState.Dead);
            var sut = new LifeRules();
            var liveNeighbours = 2;

            Cell result = sut.GetNewState(currentCell, liveNeighbours);

            var expected = CellState.Dead;

            result.State.Should().Be(expected);
        }

        // When live cell has more than 3 live neighbours Then return dead
        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void When_live_cell_has_more_than_3_live_neighbours＿＿Then_return_dead(int liveNeighbours)
        {
            Cell currentCell = new Cell(CellState.Dead);
            var sut = new LifeRules();
            Cell result = sut.GetNewState(currentCell, liveNeighbours);
            var expected = CellState.Dead;
            result.State.Should().Be(expected);
        }
    }
}