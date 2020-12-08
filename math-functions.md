---
description: You will see how math function uses
---

# Math Functions

## Pi;

 is commonly used in math \(3.14\)  


```text
this.Text = Math.PI.ToString();//This refer to Form1
```

## Absolute Value;

```text
int AbsoluteValue= Math.Abs(int.Parse(txtbirinci.Text));
            this.Text = AbsoluteValue.ToString();
```

## Floor;

Rounds the given decimal value to the next lower integer.

```text
double value=Convert.ToDouble(Textbox1.Text);
    this.Text=Math.Floor(value).ToString();

```

## Ceiling;

Complements the given decimal value to the next higher integer.

```text

 
Math.Ceiling(Convert.ToDouble(Textbox1.Text)).ToString());
```

## Round;

It rounds more than half of the number to an upper value and less than half to the lower value.

Note:The number before. completes to a lower value if the number is even, and to the upper value if odd.

```text
Math.Round(Convert.ToDouble(Textbox1.Text)).ToString());
```

## Truncate;

It doesn't look at the decimal part of the number,but just hand over the full part to you.



```text
Math.Truncate(Convert.ToDecimal(text.Text)).ToString());
```

## Max,Min;

Min , it brings us the lowest value entered.

Max, it bring us the highest value entered. 



\*\*Note : If entered value more than 2;



```text
("TheLowest Value :{Math.Min(Math.Min(int.Parse(TextBox1.Text), int.Parse(Textbox2.Text)), int.Parse(TextBox3.Text))}")
```



\($"Girilen Değerlerden En kücüğü:{Math.Min\(Math.Min\(int.Parse\(txtbirinci.Text\), int.Parse\(txtikinci.Text\)\), int.Parse\(txtucuncu.Text\)\)}"\)

```text
Math.Min(Convert.ToInt32(textbox1.Text), Convert.ToInt32(textbox2.Text)).ToString());
Math.Max(Convert.ToInt32(textbox1.Text), Convert.ToInt32(textbox2.Text)).ToString());
```

## Sqrt; Takes the square root of an entered value.

```text
Math.Sqrt(Convert.ToDouble(txtbirinci.Text)).ToString();

```

## Sign;

It notifies about whether a number is negative positive or equal to 0. Returns -1 if number is negative, 0 if neutral, +1 if positive.

```text
Math.Sign(Convert.ToInt32(txtbirinci.Text)).ToString();
```



