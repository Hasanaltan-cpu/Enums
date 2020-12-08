# Sealed Class in C\#

###  What is the main purpose of Sealed Class? _**Sealed classes are used to restrict the inheritance feature of object oriented programming. Once a class is defined as a sealed class, this class cannot be inherited.**_ 

```text
using System;  
class Class1  
{  
    static void Main(string[] args)  
    {  
        SealedClass sealedCls = new SealedClass();  
        int total = sealedCls.Add(4, 5);  
        Console.WriteLine("Total = " + total.ToString());  
    }  
}  
// Sealed class  
sealed class SealedClass  
{  
    public int Add(int x, int y)  
    {  
        return x + y;  
    }  
}   
```

### Why Sealed Classes?

We just saw how to create and use a sealed class in C\#. The main purpose of a sealed class is to take away the inheritance feature from the class users so they cannot derive a class from it. One of the best usage of sealed classes is when you have a class with static members.



reference : c-sharpcorner.com\Mahes Chand 

