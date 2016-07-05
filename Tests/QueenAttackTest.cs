using Xunit;
namespace QueenAttack
{
  public class TestQueenTest
  {
    [Fact]
    public void CanAttack_ForXis0_true()
    {
      Queen testQueen = new Queen(4,2,6,4);
      Assert.Equal(true, testQueen.canAttack());
    }
  }
}
