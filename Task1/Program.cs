using System.Formats.Asn1;
using Task1;
var emp=new Employee(1,"Asad","ahmadow",2000);
System.Console.WriteLine(emp.GEtId());
System.Console.WriteLine(emp.GetFirstName());
System.Console.WriteLine(emp.GetLastName());

System.Console.WriteLine(emp.GetName());
System.Console.WriteLine(emp.GetSalary());
emp.SetSalary(2500);
System.Console.WriteLine(emp.GetSalary());
System.Console.WriteLine(emp.GetAnuallSalary());
System.Console.WriteLine(emp.RaiseSalary(10));
System.Console.WriteLine(emp.ToString());
