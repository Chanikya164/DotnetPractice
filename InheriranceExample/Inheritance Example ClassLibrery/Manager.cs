using System;

public class Manager : IEmployee,IPerson
{
    private string _department;
    private int _empID;
    private string _empName;
    private string _location;
    private DateTime _dateOfBirth;

    public Manager(int empId, string empName, string location, string department)
    {
        
        this._department = department;
        this._empID = empId;
        _empName = empName;
        _location = location;

    }

    public string GetHealthInsurenceAmount()
    {
        return "The Insured Amount is: 1000";
    }

    public int EmpID
    {
        set { _empID = value; }
        get { return _empID; }
    }
    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }

    public string Location
    {
        set { _location = value; }
        get { return _location; }
    }
   
    public string Department
    {
        set { _department = value; }
        get { return _department; }
    }

    public DateTime DateOfBirth
    {
        set { _dateOfBirth = value; }
        get { return _dateOfBirth; }
    }
    public long GetTotalSalesOfTheYear()
    {
        return 1000;
    }
    public string GetFullDepartmentName()
    {
        return Department + " at " + Location;
    }

    public int GetAge()
    {
      int a=  Convert.ToInt32((DateTime.Now - DateOfBirth).TotalDays / 365);
        return a;
    }
}


