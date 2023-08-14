namespace Task3;

public class MyList<T> 
{
    List<T> Mylist=new List<T>();
      public void Add(T t){
Mylist.Add(t);
      }
      public void Remove(T t){
        Mylist.Remove(t);
      }
      public int  Count(){
     return Mylist.Count(); 
      }
      public  bool Comtains(T t){
        return Mylist.Contains(t);
      }
       public void ToString(){
        foreach (var item in Mylist){
            Console.Write($"{item} , ");
        }
      }
}
