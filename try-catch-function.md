---
description: You will see how and why we use this function.
---

# Try---Catch Function

This function uses for the exceptional circumstances.For instance ,in one application,can be waited some failures or can be created some problems.In this circumstance we use try---catch function to find where the problem begun and also we can repair that with this function.

## Types of Errors:

#### \*User Errors =&gt; Errors made by the user, such as trying to upload a CV through the profile picture upload panel.

#### \*Software-İnduced Errors=&gt; Bugs in the software and every software has its own bugs.Why do u think the world's giant software companies or game companies are goint through a patch \( update \) ? In order  to patch these bugs.

#### \*Login Originated Errors =&gt; Errors caused by the developer.Logiv errors made by the software on a process are shown here as an example.



```text
 try
  {
  int number1= int.Parse(textbox1.Text);
  int number2 = int.Parse(textbox2.Text);
  int result= number1 / number2 ;
  MessageBox.Show($"Result : {Result}");

  }
  catch (DivideByZeroException) 

 {
 MessageBox.Show("Random Number can not divided by Zero..!");

                
 }
 catch (Exception ex)

{
 MessageBox.Show(ex.ToString());
 MessageBox.Show("Oops..Something went wrong..!");
```





