using System;
public interface  IEmployee:IPerson 
{
  

    
    int EmpID{set ;get; }  
    string EmpName { set; get; }
    string Location { set; get; }
    
    
    string GetHealthInsurenceAmount();
       

       
}