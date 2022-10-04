using MediateBookStore.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Persistence
{
    public class BookStoreDBContext:DbContext
    {
        public BookStoreDBContext(DbContextOptions<BookStoreDBContext> options)
   : base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var AuthorGuid = Guid.Parse("{B0788D2F-8003-43C1-92A4-EDC76A7C5DDE}");
            var BookGuid = Guid.Parse("{6313179F-7837-473A-A4D5-A5571B43E6A6}");
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = AuthorGuid,
                FullName = "New Author"
            });

            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = BookGuid,
                Title = "Test Title",
                Description = "Test Description",
                ImageUrl = "http://stage.cp.todoor.com.sa/Attachments/c52e292f-9d77-43cd-b0e6-59d033d61005.png",
                AuthorId = AuthorGuid
            });

        }
    }
}
