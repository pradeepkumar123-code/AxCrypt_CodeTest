using AxCrypt_v2.Models;
using AxCrypt_v2.Service;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace AxCrypt_v2
{

    public class Program
    {
        static async Task Main(string[] args)
        {
            //a C# method that reads a file with numbers
            FileRead res = new FileRead();
            Console.WriteLine("Output : " + res.AddNumbersInFile("Content/Numbers.txt") + "");


            //to ge the list of books which are due more than 30 days ago
            var serviceProvider = new ServiceCollection()
            .AddDbContext<LibraryContext>(options => options.UseInMemoryDatabase("LibraryDb"))
            .BuildServiceProvider();

            using var context = serviceProvider.GetRequiredService<LibraryContext>();
            context.Database.EnsureCreated();

            var libraryService = new LibraryService(context);
            var overdueBooks = await libraryService.GetOverdueAysncBooks();
            foreach (var book in overdueBooks) { 
                Console.WriteLine($"Book : {book.Title} , DueDate : {book.DueDate}"); 
            }
        }

    }
}

