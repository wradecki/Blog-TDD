using FluentAssertions;
using Xunit;
using Xunit.Extensions;

namespace GameOfLife.Tests
{
    public class CellTests
    {
        // When dead cell with exactly 3 live neightburs Then return alive
        [Fact]
        public void When_dead_cell_with_exactly_3_live_neightburs＿＿Then_return_alive()
        {
            const int threeLiveNeighbours = 3;

            Cell result = Cell.Dead.Evolve(threeLiveNeighbours);
            
            result.State.Should().Be(CellState.Alive);
        }

        [Theory]
        [InlineData(1)]
        [InlineData(0)]
        public void When_live_cell_has_fewer_than_two_live_neigtbours＿＿Then_return_dead(int liveNeighbours)
        {
            Cell result = Cell.Alive.Evolve(liveNeighbours);

            result.State.Should().Be(CellState.Dead);
        }

        // When live cell has 3 live neighbours Then return alive
        [Fact]
        public void When_live_cell_has_3_live_neighbours＿＿Then_return_alive()
        {
            const int threeLiveNeighbours = 3;

            Cell result = Cell.Alive.Evolve(threeLiveNeighbours);

            result.State.Should().Be(CellState.Alive);
        }

        // When live cell has 2 live neighbours Then return alive
        [Fact]
        public void When_live_cell_has_2_live_neighbours＿＿Then_return_alive()
        {
            const int twoLiveNeighbours = 2;

            Cell result = Cell.Alive.Evolve(twoLiveNeighbours);

            result.State.Should().Be(CellState.Alive);
        }


        [Fact]
        public void When_dead_cell_has_2_live_neighbours＿＿Then_return_alive()
        {
            var twoLiveNeighbours = 2;

            Cell result = Cell.Dead.Evolve(twoLiveNeighbours);

            result.State.Should().Be(CellState.Dead);
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
            Cell result = Cell.Dead.Evolve(liveNeighbours);

            result.State.Should().Be(CellState.Dead);
        }
    }
}