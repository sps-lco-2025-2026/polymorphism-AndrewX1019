namespace PolymorphismExample.Lib;

/// <summary>
/// A base class which implements 2 functions 
/// </summary>
public class BaseClass
{
    #region 5 virtual 
    // step 5 - what effect does the virtual keyword have? 
    // the importance of new vs override in the derived class. 
    public virtual void Method1() 
    {
        Console.WriteLine("Base - Method1");
    }
    #endregion

    #region 2 method 2 - a straight method (not virtual - see later, #5) 
    // step 2 - a straight function - base.method2 is always coming here 
    public void Method2()
    {
        Console.WriteLine("Base - Method2");
    }
    #endregion 

}
