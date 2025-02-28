namespace MoveZeroesToTheEndRerun;

public class ZeroMover
{
	public static int[] MoveZeroes(int[] ints) => ints
			.Where(i => i != 0)
			.Concat(ints.Where(i => i == 0))
			.ToArray();
}