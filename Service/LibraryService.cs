using AxCrypt_v2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AxCrypt_v2.Service
{
    public class LibraryService
    {
         private readonly LibraryContext _context;
        public LibraryService(LibraryContext context)
        {
            _context = context; 
        }
         
        /// <summary>
        /// To get the books which are due more than 30 days ago
        /// </summary>
        /// <returns></returns>
        public async Task<List<Book>> GetOverdueAysncBooks()
        {
            try
            {
                var thirtyDaysAgo = DateTime.UtcNow.AddDays(-30);
                return await _context.Books.Where(b => b.DueDate <= thirtyDaysAgo)
                    .OrderByDescending(b => b.DueDate)
                    .ToListAsync();
            }
            catch (Exception ex) {
                Console.WriteLine($"Message : {ex.Message}");
                throw;
            }
            
        }
    }
}
