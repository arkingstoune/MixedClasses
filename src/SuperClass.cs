using System;
namespace SRC;
public class SuperClass<T>
{
    public T Nosedive{get; set;}
    public T ToLWitoutIT()
    {
        if(Nosedive.Equals(typeof(string))) Console.WriteLine(" yes it is string type");
        return Nosedive;
    }
}