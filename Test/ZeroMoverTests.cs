using FluentAssertions;
using MoveZeroesToTheEndRerun;

namespace Test;

public class ZeroMoverTests
{
    [Fact(DisplayName = "Array with only a zero is returned as is")]
    public void ArrayWithOnlyZero_ShouldBeReturnedAsIs()
    {
        // act
        var result = ZeroMover.MoveZeroes([0]);
        
        // assert
        result.Should().BeEquivalentTo([0]);
    }

    [Theory(DisplayName = "Array in order is returned as is")]
    [InlineData(new[] {1})]
    [InlineData(new[] {2})]
    [InlineData(new[] {5,1,3})]
    public void ArrayInOrder_ShouldBeReturnedAsIs(int[] ints)
    {
        // act
        var result = ZeroMover.MoveZeroes(ints);
        
        // assert
        result.Should().Equal(ints);
    }

    [Theory(DisplayName = "Zeroes are moved to the end")]
    [InlineData(new[] {0,0,1}, new[] {1,0,0})]
    [InlineData(new[] {0,1,0,12,3}, new[] {1,12,3,0,0})]
    public void Zeroes_ShouldBeMovedToTheEnd(int[] ints, int[] expectedInts)
    {
        // act
        var result = ZeroMover.MoveZeroes(ints);
        
        // assert
        result.Should().Equal(expectedInts);
    }
}