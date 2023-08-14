using System.Net.NetworkInformation;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;


namespace Task;

public class Circle:Point
{
    Point Center=new Point();
    double Radius;
    public Circle()
    {
    }
    public Circle(int a,int b,double Radius)
    {
        Center.SetX(a);
        Center.SetY(b);
        this.Radius = Radius;
    }
    public Circle(Point center,double Radius){
        this.Center = center;
        this.Radius = Radius;
    }
    public void SetRadius(double radius){
        this.Radius = radius;
    }
    public double GetRadius(){
        return this.Radius;
    }
    public Point GetSenter(){
        return Center; 
    }
   public void SetSenter(Point center){
    Center=center;
   }
   public int GetSenterX(){
    return Center.GetX();
   } 
   public int GetCenterY(){
    return Center.GetY();
   }
   public void SetCenterX(int x){
    Center.SetX(x);
   }
   public void SetCenterY(int y){
    Center.SetY(y);
   }
   public int [] GetCenterXY(){
    return Center.GetXY();
     }
     public void SetCenterXY(int x,int y){
         Center.SetXY(x,y);
     }
     public string ToString(){
        return $"Circle-center {Center.GetX()} , {Center.GetY()},radius {Radius} ";
     }
     public double GetArea(){
        return Radius*Radius*3.14;
     }
     public double Getcircumfrense(){
        return Radius*2*3.14;
     }
     public double DistanseCenter(Circle circle){
        return Center.Distansee(circle);

     }

     }




        
    


