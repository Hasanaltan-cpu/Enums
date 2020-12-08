---
description: Differences between Stack and Heap
---

# Stack vs Heap fields\(RAM\)

     Stack is used for static memory allocation and Heap for dynamic memory allocation, both stored in the computer's RAM .  
      Variables allocated on the stack are stored directly to the memory and access to this memory is very fast, and it's allocation is dealt with when the program is compiled. When a function or a method calls another function which in turns calls another function etc., the execution of all those functions remains suspended until the very last function returns its value. The stack is always reserved in a LIFO order, the most recently reserved block is always the next block to be freed. This makes it really simple to keep track of the stack, freeing a block from the stack is nothing more than adjusting one pointer.  
       Variables allocated on the heap have their memory allocated at run time and accessing this memory is a bit slower, but the heap size is only limited by the size of virtual memory . Element of the heap have no dependencies with each other and can always be accessed randomly at any time. You can allocate a block at any time and free it at any time. This makes it much more complex to keep track of which parts of the heap are allocated or free at any given time.

![](.gitbook/assets/stack-heap.png)

You can use the stack if you know exactly how much data you need to allocate before compile time and it is not too big. You can use heap if you don't know exactly how much data you will need at runtime or if you need to allocate a lot of data.

In a multi-threaded situation each thread will have its own completely independent stack but they will share the heap. Stack is thread specific and Heap is application specific. The stack is important to consider in exception handling and thread executions.



### Garbage Collector

Garbage collector is the main different between .NET\(c\#,Java\) and c,c++ code languages.It has numerous advantages for developer in terms of memory management.How?

For instance,you created an immutable string value and as i mentioned before it went to stack part of RAM and can not be changeable.On the other side,you produced an mutable object by using a class.At this step,this object goes to heap part of RAM.This means that when references of object is null\(0\),Garbage collector works and throw this object out of RAM and developer can reach this field for replace.What does it give advantage?Garbage collector, prevent application from object which is not used and also effect application about perform.

```text
STACK MEMORY
///*Developer can not control stack part.

int number =15
string name = "Hasan";
float height = 1.83;

///All of them now occured on the Stack Part
 and u can not manage this.
 
 
 
 HEAP MEMORY
 ///*Objects which are created by New  occure Heap Part.
 
 Student student1=new Student();
 student1.name ="Hasan";
 
 ///Reference is student1 => Stack
 //Value is Hasan => Heap
 
  GARBAGE COLLECTOR
  
   Student student1=new Student();
   student1.name ="Hasan";
   
   if (true)
    {  
     Student student2=new Student();    
    }

 When if blocks over, object's reference will be "0" at that moment 
 Garbage collector works and Heap will be clear. 
```





## Differencess Dispose & Finalize Usage

| Dispose | Finalize |
| :--- | :--- |
| It is used to free unmanaged resources like files, database connections etc. at any time. | It can be used to free unmanaged resources \(when you implement it\) like files, database connections etc. held by an object before that object is destroyed. |
| Explicitly, it is called by user code and the class which is implementing dispose method, must has to implement IDisposable interface. | Internally, it is called by Garbage Collector and cannot be called by user code. |
| It belongs to IDisposable interface. | It belongs to Object class. |
| It's implemented by implementing IDisposable interface Dispose\(\) method. | It's implemented with the help of destructor in C++ & C\#. |
| There is no performance costs associated with Dispose method. | There is performance costs associated with Finalize method since it doesn't clean the memory immediately and called by GC automatically. |



Reference :net-informations.com;  
                    c-sharpcorner.com/Pankaj Patel;  
                    guru99,/dotnettrick.com

  

