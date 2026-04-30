namespace PolymorphismExample.Lib;

/// <summary>
/// a derived class, which inherits from the base class 
/// </summary>
public class DerivedClass : BaseClass
{
    #region 6 override 
    // // #6
    public override void Method1()
    {
        Console.WriteLine("Derived - Method1");
    }
    #endregion

    #region 4 new 
    // #4 new 
    public new void Method2() 
    {                
        Console.WriteLine("Derived - Method2");
    }
    #endregion

    public void Method3()
    {
        Console.WriteLine("Derived - Method3");

    }
}