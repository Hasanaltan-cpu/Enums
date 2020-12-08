---
description: 'Difference between String and String Builder C#'
---

# String vs String Builder\(C\#\)

## Strings in C\#

String is immutable in C\# that would mean you couldn’t modify it after it is created. It creates a new object of string type in memory if you will perform any operation.

```text
string str1 = "Welcome!";
// creates a new string instance
str1 += "Hello";
str1 += "World”;
```

## StringBuilder is mutable in C\#.

 This means that if an operation is performed on the string, it will not create a new instance every time. With that, it will not create new space in memory, unlike Strings.

```text
StringBuilder str1 = new StringBuilder("");
str1.Append("Welcome!");
str1.Append("Hello World!");
string str2 = str1.ToString();
```

