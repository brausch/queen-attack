using System;

namespace QueenAttack
{
  public class Queen
  {
    private int _xq;
    private int _yq;
    private int _x;
    private int _y;

    public Queen(int xq, int yq, int x, int y)
    {
      _xq = xq;
      _yq = yq;
      _x = x;
      _y = y;
    }

    public int GetXq()
    {
      return _xq;
    }
    public void SetXq(int newXq)
    {
      _xq = newXq;
    }
    public int GetYq()
    {
      return _yq;
    }
    public void SetYq(int newYq)
    {
      _yq = newYq;
    }
    public int GetX()
    {
      return _x;
    }
    public void SetX(int newX)
    {
      _x = newX;
    }
    public int GetY()
    {
      return _y;
    }
    public void SetY(int newY)
    {
      _y = newY;
    }

    public bool canAttack()
    {
      if(_xq == _x){
        return true;
      }
      if(_yq == _y){
        return true;
      }
      if(Math.Abs((_yq-_y)/(_xq-_x)) == 1){
        return true;
      }
      return false;
    }
  }
}
