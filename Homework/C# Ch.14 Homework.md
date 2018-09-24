# Andre Lacquement
### C# Ch.14 Homework
---

1. Managed resources are managed by the garbage collector. Unmanaged resources have to be controlled by yourself. 

1. Memory is allocated when you use the new keyword. It is deallocated when you use garbage collection. 

1. You use a destructor to tidy up after an object is garbage collected. 

1. Destructors have the tilde(~) before them and they only apply to reference types, you cannot specify an access modifier, cannot take any parameters.

1. Some scarce resources are memory, database connections or file handles. You would want to manage them because they are limited. 

1. Exception-safe disposal ensures that a disposal method is always called regardless of whether there is an exception by using a finally block.

1. A variable defined in the using statement will stay in scope as long as it is true. 

1. Trying to dispose of something that has already been disposed could throw an error.

1. Threads are a way to isolate code so that it may not be run concurrently with a similar thread.

1. There's no point in disposing of resources that have already been disposed. 
