# SOLID

> A repository for practicing and demonstrating SOLID OO principles


## The Principles Summary

* S: Single responsibility principle (SRP). 
  - A class should do one thing and have only one reason to be changed.
  - Code smells: 
    * Code file is larger that ~300 lines.
    * Difficult to unit test the class.
    * Difficult to identify the purpose of a class.
    * Recurring code conflicts and/or regressions.
* O: Open closed principle (OCP). Opened to extension, closed to modification. 
  - If a class requires extensibility, the class itself should not not have
to be modified to add new functionality.
  - Code smells:
    * Large blocks of `switch` and/or `if` statements that are sometimes repeated within
the class or a function in the class.    
* L: Liskov Substitution principle (LSP). An implementation of an abstraction breaks the system.
    - Code Smells
      * Receiving `NotSupportedException` in normal system runtime
      * Checking/Casting to the implementation type to work around issues.
* I: Interface segregation Principle (ISP). Clients should not depend on methods they do not use.
  - Code Smells
    - Fat interface files
    - Implementations with empty methods/properties put there just to fullfil the interface.
    - Unnecessary biolerplate/bloated files for implementations.
* D: Dependency inversion principle (DIP). Describes principle between abstraction and concrete types.
 - Code Smells
   - Class is difficult to unit test due to hard-coded dependencies
   - Dependency cannot be swapped out without modifying the class.

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
    ICalculator calc = factory.GetCalculator();
    var result = calc
        .Input(4)
        .Input("+", 4)
        .Input("+", 2)
        .Input("SQUARE")
        .Result();
    // result = 100
```

### Iteration 1 Review

1. SRP: `Calculator` performs computations, formats logs, and appends logs to the console.
   1. Logging cannot be easily verified via unit testing.
   1. Log formatting cannot be adjusted without modifying `Calculator`
2. OCP: `Calculator` cannot be extended without modifying it. To add an operation, the switch statement
must be extended.  Considering the desire to add more operations, this is a priority fix!
3. LSP: Polymorphism is not in use... yet.
4. ISP: Interfaces are not in use... yet.
5. DIP: No abstractions have been created... yet.

### Iteration 2 Review

1. SRP: `Calculator` now only performs computations.  `ConsoleLogger`
require modification to change the output format as well as output method.
2. OCP: `Calculator` cannot be extended without modifying it. Based on the size of the dev
team and desire to add numerous computations, this should be changed. `ConsoleLogger` logging
format cannot be changed without modifying the class.
3. LSP: Polymorphism is not in use... yet.
4. ISP: All interfaces a fully used by implementations.
5. DIP: ILog instance is hard-coded into ConsoleLogger

### Iteration 3 Review

1. SRP: `Calculator` has all computations moved to seperate classes per operator.
2. OCP: New operators can now be added without modifying `Calculator`. 
3. LSP: No violations.  All `IComputation` instances fullfil all members of the interface.
4. DIP: `Calculator` no longer depends on a specific logging implementation.
5. New logging services needs implementation and unit test.
6. Should each `IComputation` have its own testing class?


### Iteration 4 Review

1. SRP: `LogService` performs log formatting and appending. Consider extracting log formatting.
2. OCP: `LogService` can be customized by injecting any number of `ILogAppender` and/or `ILogPropertyProvider`
via `LogServiceConfig`.
3. LSP: No violations.
4. DIP: `LogService` template engine cannot be subsituted.  Leaving as is for now.

## References

* [SOLID Design principles with C# practical examples](http://www.dotnetforall.com/solid-design-principles-examples/)
