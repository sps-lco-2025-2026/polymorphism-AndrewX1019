using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ClassLibrary;

public class Person
{
    string First_name = "";
    string Last_name = "";
    string Email = "";
    DateOnly Date = new DateOnly(2008, 10, 19);
    public Person(){}//?
    public Person(string s1, string s2, string s3, DateOnly s4)
    {
        First_name = s1;
        Last_name = s2;
        Email = s3;
        Date = s4;
    }
    public Person(string s1, string s2, DateOnly s3)
    {
        First_name = s1;
        Last_name = s2;
        Date = s3;
    }
    int age
    {
        get
        {
            if (DateTime.Now.Month > Date.Month)
            {
                return DateTime.Now.Year-Date.Year;
            }
            else{return DateTime.Now.Year-Date.Year-1;}
        }
    }
    public int Age
    {
        get
        {
            return age;
        }
    }
    public bool Valid
    {
        get
        {
            return age<120 && age>=0;
        }
    }
    public bool Adult
    {
        get
        {
            return age > 18;
        }
    }
    //public string Chinese_sign
    public bool Birthday
    {
        get
        {
            return DateTime.Now.Day==Date.Day&&DateTime.Now.Month==Date.Month;
        }
    }
    public virtual void Screen_name()
    {
        Console.WriteLine(First_name+Last_name+Date.Month+Date.Day);
    }
}
