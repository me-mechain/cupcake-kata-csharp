---
CUPCAKE KATA
---

*Source : [codingdojo.org](https://codingdojo.org/kata/cupcake/)*

## About this kata
This kata was originally made to implement the [decorator](https://en.wikipedia.org/wiki/Decorator_pattern) and [composite](https://en.wikipedia.org/wiki/Composite_pattern) pattern.

With the **decorator pattern**, if you want to build an aluminium bike with a sport package, the implementation will look like :
``` c#
public interface IBike
{
    string GetDetails();
    double GetPrice();
}

public class AluminiumBike : IBike
{
    public double GetPrice() => 100.0;

    public string GetDetails() => "Aluminium Bike";
}

public abstract class BikeAccessories : IBike
{
    private readonly IBike _bike;

    public BikeAccessories(IBike bike) { _bike = bike; }

    public virtual double GetPrice() => _bike.GetPrice();

    public virtual string GetDetails() => _bike.GetDetails();
}

public class SportPackage : BikeAccessories
{
    public SportPackage(IBike bike) : base(bike) { }

    public override string GetDetails() => base.GetDetails() + " + Sport Package";

    public override double GetPrice() => base.GetPrice() + 10;
}
```

**Output** : ```Bike: 'Aluminium Bike + Sport Package' Cost: 110```

## Problem Description
The aim of this kata is to use **decorator pattern** to write a program that can build many cakes with many toppings.  

In pseudocode to build a Cupcake with chocolate, nuts and sugar you will write :

```var myCake = Sugar(Nuts(Chocolate(Cupcake())))```

## Implementation

Write a method that can show **the name of a cake**.  
***Example:** The method has to return "🧁 with 🍫" for a cupcake with chocolate topping.*

Write a method that can show **the price of a cake**. The price is composed of base cake price and topping price.  
***Example:** For "🧁 with 🍫", the method will return "1,1$".*

**Bundle of non fresh cakes** :  
Now it’s possible to make **a bundle of cakes.**  
It’s possible to build **a bundle of bundle** with singles cakes.

## Specifications

###### About name method

The **name method** should return :
- “🧁” for a cupcake.
- “🍪” for a cookie.
- “🧁 with 🍫” for a cupcake with chocolate.
- “🍪 with 🍫” for a cookie with chocolate.
- “🍪 with 🍫 and 🥜” for a cookie with chocolate and nuts.
- “🧁 with 🥜 and 🍫” for a cupcake with nuts and chocolate.

###### About price function or method

The **price method** should return :
- "1$" for “🧁”
- "2$" for “🍪”
- "1.1$" for “🧁 with 🍫”
- "2.2$" for “🍪 with 🍬”
- "2.2$" for “🍪 with 🥜”


###### Bundles
A bundle has a **name**, a **price** and a **description**.  
The price of a bundle is **10% less than prices of each cake.**

We can build : 
- A Bundle with 1 Cupcake 
- A Bundle with 1 Cupcake and 1 Cookie
- A Bundle with 2 Cupcake and 1 Cookie
- A bundle with 1 bundle of 2 cakes and 1 Cupcake
- A bundle with many bundles of bundles and many cakes  

and check its **price**, its **description** and its **name**.

***Example:***  
*A bundle of a cookie and a cupcake will have the following characteristics :*
- ***Name** : "Bundle of (1 🍪 + 1 🧁)"*
- ***Description** : "1 🍪 + 1 🧁"*
- ***Price** : "2,7$"*
