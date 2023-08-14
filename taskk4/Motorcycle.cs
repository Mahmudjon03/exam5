namespace taskk4;

public class Motorcycle : Ivehicle
{
    public int Speed { get; set; }

    public bool IsRunning()
    {
        return false;
    }

    public void Start()
    {
              System.Console.WriteLine("Starting motorcicle enige");


    }

    public void Stop()
    {
      System.Console.WriteLine("Stoping motorcicle enige");
    }
    public string DriveC(){
        return $"Driving at { Speed } mph";
    }


}
