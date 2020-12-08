---
description: You will see what abstraction means and how we use it.
---

# Abstraction

If we want to abstract one class we should point out by writing "abstract" before class name:

```text
public abstract class Enstrumants{}
```

As i said before, we can not product instance at the Base\(Parent\)Class.In this abstract class is the similar like a BaseClass.We can not take a instance from an abstract class.Beside that;in this class,writing abstract is optional for members.How?

```text
public string Description{ get; set; }//prop+Tab+Tab
public abstract string Cal();

```

As u see these examples, first one should not be overrided but the second one which is begun with "public abstract string" should be override.

```text
 public class Guitar: Enstrumants
    {
        private const string V = "Guitar Sound";

        public override string Cal()
        {
           
            return "Guitar sound";
        }
```

Now we created a new class which name is Guitar and as u see "Enstrumans" is Base\(Parent\) class for "Guitar" class.At this step, our method which was written "abstract" is on our screen.It means automatically, it doesn't allow us to next step before overriding this rule.

#### Why don't we use body on the abstract row?

\*\*Because it  effects speed of working and we will override this code on the subclasses.That's why creating body is not logical.

#### Let's see the other properties of abstract ;

\*\*Abstract structure must have include properties that wanted to should use on the Subclasses.Due to this principle, the members which created on the  abstract class should be implemented on the subclasses.

\*\*We don't need to "virtual using" because abstract form prodives us same logic as virtual.

As a conclusion;

by using abstract we create new rules for the other classes.



