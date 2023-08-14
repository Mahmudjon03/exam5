namespace Task;

public class Point
{
    int _x;
    int _y;
    public Point()
    {
    }
    public Point(int x, int y)
    {
        _x=x;
        _y=y;
    }
    public int GetX(){
        return _x;
    }
    public int GetY(){
        return _y;
    }
    public void SetX(int x){
        _x=x;
    }
    public void SetY(int y){
        _y=y;
    }
    public string ToString(){
        return " " + _x + " , "+_y;
    }
    public int[] GetXY(){
var Xy = new int[2]{_x,_y};
   return Xy;
   }
   public void SetXY(int x,int y){
    x=22;
    _x=x;
    y=33;
    _y=y;
   }
   public double Distanse(int x,int y){
    double d;
   return d=(x-_x)+(y-_y);
   }
   public double Distansee(Point w){
    double d;
    return d=(w.GetX()-_x)+(w.GetY()-_y);
   }
   public double Distans(){
    return 0.0;
   }
}
