using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class MyClass
    {
        public bool MyProperty { get; set; } = false;

        public async Task MyAsyncMethod()
        {
            Console.WriteLine($"MyAsyncMethod - Before asynchronous operation on thread {Environment.CurrentManagedThreadId}");

            // Simulate an asynchronous operation
            await SomeAsyncOperation().ConfigureAwait(MyProperty);

            Console.WriteLine($"MyAsyncMethod - After asynchronous operation on thread {Environment.CurrentManagedThreadId}");
        }

        public Task SomeAsyncOperation()
        {
            Console.WriteLine($"SomeAsyncOperation - Before delay on thread {Environment.CurrentManagedThreadId}");

            // Simulate an asynchronous operation (e.g., I/O, database query)
            var task = Task.Delay(1000);

            Console.WriteLine($"SomeAsyncOperation - After delay on thread {Environment.CurrentManagedThreadId}");

            return task;
        }
    }
}


public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int PublicationYear { get; set; }
    public bool IsRead { get; set; } = false;

    public Book(string title, string author, int publicationYear)
    {
        this.Title = title;
        this.Author = author;
        this.PublicationYear = publicationYear;
    }

    public void MarkAsRead()
    { 
        this.IsRead = true;
    }


    public override string ToString() 
    {
        return $"{Title} автора {Author} ({PublicationYear}){(IsRead ? "" : string.Empty())}";
    }
}