using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ClassLibrary;

public class Student : Person
{
    Person p;
    string year = "";
    public Student(Person P)
    {
        p=P;
        year = "Y" + Convert.ToString(Age-5);
    }
    public Student(Person P, string s)
    {
        p = P;
        year = s;
    } 
    public override void Screen_name()
    {
        Console.Write(year);
        p.Screen_name();
    }
}