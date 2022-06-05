using System;

public class SalesMan :IEmployee
{
    private string _region;
    private int _empID;
    private string _empName;
    private string _location;
    private DateTime _dateOfBirth;
    public SalesMan(int empId, string empName, string location, string region)
    {
      this._region = region;
    }

    public string GetHealthInsurenceAmount()
    {
        return "The Insured Amount is: 500";
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
   
    public string Region
    {
        set { _region = value; }
        get { return _region; }
    }

    public DateTime DateOfBirth
    {
        set { _dateOfBirth = value; }
        get { return _dateOfBirth; }
    }
    public long GetSalesOfTheCurrentMonth()
    {
        return 500;
    }

    public int GetAge()
    {
        int a = Convert.ToInt32((DateTime.Now - DateOfBirth).TotalDays / 365);
        return a;
    }
}
