using Microsoft.EntityFrameworkCore;
using LibrarySystem.Data;
using LibrarySystem.Models;

namespace LibrarySystem.Services
{
    
    public class AuthorService
    {
        private readonly AppDbContext _context;

        public  AuthorService (AppDbContext context)
        {
            _context = context;
        }
    }
}
