using System.Dynamic;

namespace Task1;

public class Employee
{
    int Id;
    string FirstName;
    string LastName;
    int Salary;
    public Employee(int id,string firstName,string lastName,int salary)
    {
        FirstName=firstName;
        LastName=lastName;
        Salary=salary;
        Id=id;
    }
    public int GEtId(){
        return Id;
    }
    public string GetFirstName(){
        return FirstName;
    }
    public string GetLastName(){
        return LastName;
    }
    public string GetName(){
        return FirstName+" "+LastName;
    }
    public int GetSalary(){
        return Salary;
    }
    public void SetSalary(int r){
        Salary=r;
    }
    public int GetAnuallSalary(){
        return Salary*12;
    }
    public int RaiseSalary(int f){
        return Salary+((f*Salary)/100);
    }
    public string ToString(){
        return "id- "+ Id+ " Name-"+FirstName+","+LastName +", Salary-" +Salary;
    }
}
