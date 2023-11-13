
using ConsoleApp1;

MyClass myClass = new MyClass();

Console.WriteLine($"Main - Before MyAsyncMethod on thread {Environment.CurrentManagedThreadId}");

// Set MyProperty to true
myClass.MyProperty = true;

// Call MyAsyncMethod with ConfigureAwait(true)
await myClass.MyAsyncMethod();

Console.WriteLine($"Main - After MyAsyncMethod on thread {Environment.CurrentManagedThreadId}");

// Reset MyProperty to false
myClass.MyProperty = false;

// Call MyAsyncMethod with ConfigureAwait(false)
await myClass.MyAsyncMethod();

Console.WriteLine($"Main - After second MyAsyncMethod on thread {Environment.CurrentManagedThreadId}");