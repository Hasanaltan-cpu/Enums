---
description: You can easily reach explanation of class and object in this page.
---

# Class And Object

 **Classes are code blocks which include fields and methods in c\#.** 



For Example;

```text
   Public class Computer
    


```

In this field we ve created a class which name is "Computer" but if u want to use this class you should create an object from this class. Computer is not an object!!This is just a prototype for a new object.Let's create  members of "Computer" class.

```text
public string Brand;
public string CPU;
public int RAMcapacity;
public string DisplayCard;
private int MacAdress ;

```

We ve created members of this class as " Brand & CPU & RAMcapacity &DisplayCard&MacAdress".Why did we use public or private in the beginning of our code?These are The Access Modifiers.The answer of this question is access modifiers gives an opportunity to access the subclass.When we create an object   
we use these and call these members from class.Also we should give a public access modifiers for class row, otherwise, class access modifiers will be "internal".

And the last step of this , creating an object..

```text
 Computer computer_1 = new Computer();
 computer_1.Brand = "Toshiba";
 computer_1.CPU = "i5";
 computer_1.DisplayCard = "5700 Geforce";
 computer_1.MainBoard = "intel";
  MessageBox.Show($"Prototipten yararlanılarak oluşturulan nesne : \nBrand: { computer_1.Brand} \nCPU:{computer_1.CPU} \nDisplayCard:{computer_1.DisplayCard} \nMainBoard:{computer_1.MainBoard}");
```



