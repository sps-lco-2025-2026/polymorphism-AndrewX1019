using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ClassLibrary;

public class Student : Person
{
    string year = "";
    public Student()
    {
        year = Convert.ToString(Age-5);
    }
    public Student(string s)
    {
        year = s;
    } 
    public override void Screen_name()
    {
        Console.Write(year);
        base.Screen_name();
    }
}