using PolymorphismExample.Lib;

// based on the example here: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/knowing-when-to-use-override-and-new-keywords 

#region 1
// Step 1 create the instances of the objects 
BaseClass bc = new BaseClass();
DerivedClass dc = new DerivedClass();

// this is the one that's going to mess with your heads. 
BaseClass bcdc = new DerivedClass();


Console.WriteLine("bc 1/2");
bc.Method1();
bc.Method2();

Console.WriteLine("\ndc 1/2");
dc.Method1();
dc.Method2();

Console.WriteLine("\nbcdc 1/2");
bcdc.Method1();
#endregion

#region 3 predict the output 
// #3            
bcdc.Method2();

#endregion

#region 7 lists

// step 7 - putting them in a list 

IList<BaseClass> lb = new List<BaseClass> { bc, dc, bcdc };
IList<DerivedClass> ld = new List<DerivedClass> {  dc};
// ld.Add(bc);
// #8 You can cast the (actual) derived class 
// ld.Add((DerivedClass)bcdc);

#endregion


#region 8 
// step 9 method 3 - will work with ld, but not with lb
// it will work with dc (or the casted bcdc) but never with bc 
foreach(DerivedClass d in ld)
    d.Method3();
#endregion

#region 9 abstract
// step 10 note we've not even talked about abstract ... 
#endregion

