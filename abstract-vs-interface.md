---
description: In this passage you will reach difference between abstract and interface.
---

# Abstract Vs Interface

## Introduction;

In this article along with the demo project I will discuss Interfaces versus Abstract classes. The concept of Abstract classes and Interfaces is a bit confusing for beginners of Object Oriented programming. Therefore, I am trying to discuss the theoretical aspects of both the concepts and compare their usage. And finally I will demonstrate how to use them with C\#.

## Background;

An Abstract class without any implementation just looks like an Interface; however there are lot of differences than similarities between an Abstract class and an Interface. Let's explain both concepts and compare their similarities and differences.



## What is an Interface?

An interface is not a class. It is an entity that is defined by the word Interface. An interface has no implementation; it only has the signature or in other words, just the definition of the methods without the body. As one of the similarities to Abstract class, it is a contract that is used to define hierarchies for all subclasses or it defines specific set of methods and their arguments. The main difference between them is that a class can implement more than one interface but can only inherit from one abstract class. Since C\# doesn’t support multiple inheritance, interfaces are used to implement multiple inheritance.



| Differences | Interface | Abstract |
| :--- | :--- | :--- |
| 1 | A class may have inherit several interfaces. | A class may inherit only one abstract class. |
| 2 | An interface cannot provide any code,just the signature.\(After C\#8.0 u can use interface like an abstract\). | An abstract class can prodive complete,default code and/or just details that have to be overriden. |
| 3 | An interface cannot have access modifiers for the subs,functions,properties etc everything is assumed as public. | An abstract class can contain access modifiers for the subs,functions,properties. |
| 4 | Interfaces are used to define the peripheral abilities of a class.In other words both Human and Vehicle can inherit from a IMovable interface. | An abstract class defines the core identity of a class and there it is used for objects of the same type. |
| 5 | If various implementations only share method signatures then it is better to use Interfaces. | If various implementations are of the same kind and use common behaviour or status then abstract class is better to use. |
| 6 | In terms of speed; requires more time to find the actual method in the corresponding classes. | Fast |
| 7 | If we add a new method to an Interface then we have to track down all the implementattions of the interface and define implementation for the new method. | If we add a new method to an abstract class then we have the option of providing default implementation and therefore all the existing code might work properly. |

Now let's see this difference at the code behind;  
Firstly we create Abstract class;

```text
public abstract class Worker;

public string id;
public string FirstName;
public string LastName;
//properties

public abstract string ID
{
    get;
    set;
}
public abstract string FirstName
{
    get;
    set;
}

//completed methods

public String Add()
{ 
    return "Worker"+id+""+LastName+""+Firstname+"added";
}      

public String Delete()
{ 
    return "Worker"+id+""+LastName+""+Firstname+"deleted";
}      

public String Update()
{ 
    return "Worker"+id+""+LastName+""+Firstname+"updated";
}              
```

Now we create Interface class;

```text
public interface IWorker
{
//In this fields , just signature of the properties and methods.
setting a rule or contract to be followed by implementations.

String Id
{
  get;
  set;
}

String Firstname
{
  get;
  set;
}

String LastName
{
  get;
  set;
}

//Can not have implementation cannot have modifiers public
all are assumed public.Cannot have virtual

String Update();
String Add();
String Delete();


  

```

Now get an object and inherit from both of them;

Firstly Abstract;

```text
public class WorkerZone : Worker

//uses all the properties of the abstract class 
therefore no properties or fields here!

Public WorkerZone ()
{
}

public ovverride String ID
{
    get
    {
    return id;
    }
    set
    {
    id=value;
    }
}

public override String FirstName
{
    get
    {
    return FirstName;
    }
    set
    {
    FirstName=value
    }
}
///These methods that are implemented in the abstract class

public new String Add()
{
    return base.Add();
}
public new String Update()
{
    return base.Update();
}
public new String Delete();
{
    return base.Delete();
}
}

```

then now by using interface;

```text
public class IWorkerZone : IWorker// "I" is commonly used for interface.
{

//****All the properties and fields defined here!!!***
    public String id;
    public String FirstName;
    public String LastName;
    
    public IWorkerZone()
    {
    
    //TODO:Add constructor logic here
    
    }
    
    public string id
    {
        get
        {
        return id;
        }
        set
        {
        id=value;
        }
    }
    
    public string FirstName
    {
        get 
        {
        return Firstname;
        }
        set
        { 
        Firstname=value;
        }
    }
    
    public string LastName
    {
        get
        {
        return LastName;
        }
        set
        {
        LastName=value;
        }
    }
    
    
        //all the manipulations including Add,Delete, 


        //Search, Update, Calculate are done

        //within the object as there are not 

        //implementation in the Interface entity.
        
        public String Add()
        {
            return "Fulltime Worker" + FirstName + " Added.";
        }
        
        public String Delete()
        {
            return "Fulltime Worker" + FirstName + " Deleted.";
        }
    
        public String Update()
        {
            return "Fulltime Worker" + FirstName + " Updated.";
        }
```

As a conclusion , interface doesn't let to change any properties on the subclasses.Because interface inherit the subclass static rule but in abstract you can override.  
  
Reference :CodeProject/ [Rahman Mahmoodi](https://www.codeproject.com/script/Membership/View.aspx?mid=444844)  
                    guru99/Anonymous  
                    Stackoverflow/  
                     

  


  





