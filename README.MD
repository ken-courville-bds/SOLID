# SOLID

> A repository for practicing and demonstrating SOLID OO principles


## The Principles Summary

* S: Single responsibility principle (SRP). A class should do one thing and have only on reason to be changed.
* O: Open closed principle (OCP). Opened to extension, closed to modification.
* L: Liskov Substitution principle (LSP). How polymorphism should work.
* I: Interface segregation Principle (ISP). How interface should be designed.
* D: Dependency inversion principle (DIP). Describes principle between abstraction and concrete types.

## Calculator Library

The Calculator Library demonstrates SOLID principles without introducing an overly complex 
application.

### Requirements

Provide a shared library that can perform these mathamatical operations against provided numbers.
For now, all number parameters and results must be of type `double`. 

To ensure maintainability, the library must follow
SOLID principles.  

1. Add: a + b = ?
2. Substract: a - b = ?
3. Multiple: a * b = ?
4. Divide: a / b = ?
5. Power: a ^ b = ?

WARNING: Additional functions will be added to the calculator later!

The library should take an initial value and then have operations applied against it
with an optional second value. The result should be chainable.  The response should include the 
computed value and log the operations applied.

**Example Usage:**

```csharp
    var result = new Calculator(4)
        .Input("+", 4)
        .Input("+", 2)
        .Input("SQUARE")
        .Result();
    // result = 100
```

### Iteration 1 Review

1. SRP: violated `Calculator` performs computations and returns results.
2. OCP: 


## References

* [SOLID Design principles with C# practical examples](http://www.dotnetforall.com/solid-design-principles-examples/)
