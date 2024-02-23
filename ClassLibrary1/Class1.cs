using System;
public class Employee
{
    //fields
    private int _empId;
    private string _empName;
    private char _jobCode;

    //instance properties
    public int EmpId
    {
        set
        {
            if (value >= 100)
            {
                _empId = value;
            }
        }
        get { return _empId; }
    }
    public string EmpName
    {
        set { _empName = value; }
        get { return _empName; }
    }
    public char JobCode
    {
        set { _jobCode = value; }
        get { return _jobCode; }

    }

    //static fields
    private static string _companyName;

    //static property
    public static string CompanyName
    {
        set
        {
            if (value.Length <= 20)
            {
                _companyName = value;
            }
        }
        get { return _companyName; }
    }

    // instance constructor
    public Employee()
    {
        _empId = 1;
    }
    public Employee(int EmpId, string EmpName, char JobCode)
    {
        //current object
        this._empId = EmpId;
        this._empName = EmpName;
        this._jobCode = JobCode;
    }

    public Employee(int EmpId, string EmpName)
    {
        //current object
        this._empId = EmpId;
        this._empName = EmpName;
    }
    //static constructor
    static Employee()
    {
        _companyName = "Merv Industries";
    }

}