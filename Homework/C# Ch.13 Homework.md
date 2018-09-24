# Andre Lacquement
### C# Ch.13 Homework
---

1. An interface does not contain any code or data. It just specifies the methods and properties that a class inherits.

1. You define an interface using the interface keyword similar to a class. 

1. No

1. Prefaced by the 'int' keyword, method names and return types match, parameters match exactly, methods must be publicly accessible. 

1. No, but you can reference them using the 'is' keyword.

1. No

1. An object can use multiple interfaces, and a class can use multiple interfaces. 

1. Explicitly implementing an interface is done by specifying which instance of a method to use in your implementation. 

1. Not allowed to define any fields, constructors, destructors. Cannot specify access modifiers, cannot nest types, and cannot inherit from a structure or a class. 

1. An abstract classes sole purpose is to be a class from which to inherit. Abstract classes can contain code or data.

1. An abstract method is similar to a virtual method. A derived class must override the method. It's useful if it does not make sense to provide a default implementation in the abstract class. 

1. A sealed class prevents a class from being used as a base class. 

1. A sealed method cannot be overridden in a derived class. you declare the method as 'sealed override'