# Andre Lacquement
### C# Ch.15 Homework
---

1. A property is a cross between a field and a method, it looks like a field but acts as a method. 

1. A property can contain only 2 blocks of code starting with the get and set keywords. 

1. Hiding the behavior of an object

1. Case sensitivity can distinguish between private fields and public properties. I do not think it is sufficient to distinguish them. 

1. You would use read-only when you want the compiler to translate your code into a call to the get accessor of that property and you would use write-only when you want the compiler to call to the set accessor of that property. 

1. You would make getters and setters private if they are static values.

1. You can assigns value through a property of structure or class only after the structure or class has been initialized, You can't use a property as a ref or an out argument to a method, a property can contain at most one get accessor and one set accessor, a property cannot contain other methods, fields or properties, get and set cannot take parameters, can't declare properties by using const

1. Object objectname = new Object {params};

