namespace taskk4;

public class Car : Ivehicle
{
    public int Speed { get; set; }


    public bool IsRunning()
    {
        return true;
    }

    public void Start()
    {
      System.Console.WriteLine("Starting car enige");
    }

    public void Stop()
    {
        System.Console.WriteLine("Stoping car enige");
    }
    public string DriveM(){
        return $"Driving at {Speed}mph";
    }


}
