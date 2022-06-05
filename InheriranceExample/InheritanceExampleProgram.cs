using System;
class Program
{
    static void Main()
    {
        //reference of abstract class
        IEmployee emp;
        emp = new Manager(102, "Malli", "Bangalore", "Accounting");
        emp.DateOfBirth = Convert.ToDateTime("1995-04-01");
        Console.WriteLine("Age is:" + emp.GetAge());
        /* Manager m1 = new Manager(102, "Malli","Bangalore","Accounting");              
         Console.WriteLine("Objects of Child  Class Manager : ");
         Console.WriteLine(m1.EmpID);
         Console.WriteLine(m1.EmpName);
         Console.WriteLine(m1.Location);
         Console.WriteLine(m1.Department );
         Console.WriteLine(m1.GetTotalSalesOfTheYear() );
         Console.WriteLine(m1.GetFullDepartmentName ());*/
        Console.WriteLine(emp.GetHealthInsurenceAmount());

        Console.WriteLine();

        IPerson p;
        p = new Manager(102, "Malli", "Bangalore", "Accounting");
        p.DateOfBirth = Convert.ToDateTime("1995-04-01");
        Console.WriteLine("Age is: " + p.GetAge());

        emp = new SalesMan(103,"Chari","hyderabad","Begampet");       
       /* Console.WriteLine("Objects of child Class SalesMan : ");
        Console.WriteLine(s1.EmpID);
        Console.WriteLine(s1.EmpName);
        Console.WriteLine(s1.Location);
        Console.WriteLine(s1.Region );
        Console.WriteLine(s1.GetSalesOfTheCurrentMonth ());*/
        Console.WriteLine(emp.GetHealthInsurenceAmount());
        Console.WriteLine();
        Console.ReadKey();
    }
   
}
