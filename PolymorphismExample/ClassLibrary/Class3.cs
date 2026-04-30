using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace ClassLibrary;

public class Teacher : Person
{
    Person p;
    string subject = "";
    public Teacher(Person P, string S)
    {
        p = P;
        subject = S;
    }
    public override void Screen_name()
    {
        Console.Write(subject+"-");
        p.Screen_name();
    }
}