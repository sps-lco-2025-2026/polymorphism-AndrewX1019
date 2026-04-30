using System.ComponentModel;
using ClassLibrary;

namespace TestProject;

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestConstructors()
    {
        Person P = new Person();

        DateOnly d = new DateOnly(2008, 10, 19);
        Person p1 = new Person("Andrew", "Xiang", "xianga@stpaulsschool.org", d);

        Person p2 = new Person("Andrew", "Xiang", d);

        Person S1 = new Student(p1);
        Person S2 = new Student(p1, "12");
        Console.WriteLine("Constructors ☑️");
    }
    [TestMethod]
    public void TestAge()
    {
        DateOnly d = new DateOnly(2008, 10, 19);
        Person P = new Person("Andrew", "Xiang", "xianga@stpaulsschool.org", d);
        Assert.AreEqual(17, P.Age);
    }
    [TestMethod]
    public void TestAdult()
    {
        DateOnly d1 = new DateOnly(2008, 10, 19);
        Person P1 = new Person("Andrew", "Xiang", "xianga@stpaulsschool.org", d1);
        Assert.IsFalse(P1.Adult);

        DateOnly d2 = new DateOnly(2007, 1, 1);
        Person P2 = new Person("", "", "", d2);
        Assert.IsTrue(P2.Adult);
    }
    [TestMethod]
    public void TestChinese_sign()
    {
        DateOnly d1 = new DateOnly(2008, 10, 19);
        Person P1 = new Person("Andrew", "Xiang", "xianga@stpaulsschool.org", d1);
        Assert.AreEqual("Rat", P1.Chinese_sign);
    }
    [TestMethod]
    public void TestValid()
    {
        DateOnly d1 = new DateOnly(2008, 10, 19);
        Person P1 = new Person("Andrew", "Xiang", "xianga@stpaulsschool.org", d1);
        Assert.IsTrue(P1.Valid);

        DateOnly d2 = new DateOnly(1900, 1, 1);
        Person P2 = new Person("", "", "", d2);
        Assert.IsFalse(P2.Valid);
    }
    [TestMethod]
    public void TestBirthday()
    {
        DateOnly d1 = new DateOnly(2008, 4, 30);
        Person P1 = new Person("", "", "", d1);
        Assert.IsTrue(P1.Valid);

        DateOnly d2 = new DateOnly(1900, 1, 1);
        Person P2 = new Person("", "", "", d2);
        Assert.IsFalse(P2.Valid);
    }
    [TestMethod]
    public void TestScreen_name()
    {
        DateOnly d = new DateOnly(2008, 10, 19);
        Person p1 = new Person("Andrew", "Xiang", "xianga@stpaulsschool.org", d);
        p1.Screen_name();

        Person p2 = new Student(p1, "Y12");
        p2.Screen_name();

        Person p3 = new Student(p1);
        p3.Screen_name();

        Person p4 = new Teacher(p1, "Maths");
        p4.Screen_name();
    }
}
