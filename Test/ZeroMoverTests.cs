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
}