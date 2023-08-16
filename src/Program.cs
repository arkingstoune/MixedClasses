using System;
using System.Collections.Generic;
using SRC;
string i = "so what will happen, .... well we will see";
string OutOfRich = "HAHAHAHA";
iDWanna<string>(ref i,ref OutOfRich);
SuperClass<string> superClass = new SuperClass<string>();
superClass.Nosedive = i;
Console.WriteLine(superClass.ToLWitoutIT());
void iDWanna<T>(ref T BLonely,ref T Cold) //Where T : notnull
{ 
    T Future;
    Future = BLonely;
    BLonely = Cold;
    Cold = Future;
}