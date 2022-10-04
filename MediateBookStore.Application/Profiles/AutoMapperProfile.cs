using AutoMapper;
using MediateBookStore.Application.Features.Authors.Commands.CreateAuthor;
using MediateBookStore.Application.Features.Authors.Commands.DeleteAuthor;
using MediateBookStore.Application.Features.Authors.Commands.UpdateAuthor;
using MediateBookStore.Application.Features.Authors.Queries.GetAllAuthors;
using MediateBookStore.Application.Features.Authors.Queries.GetAuthorDetails;
using MediateBookStore.Application.Features.Books.Commands.CreateBook;
using MediateBookStore.Application.Features.Books.Commands.DeleteBook;
using MediateBookStore.Application.Features.Books.Commands.UpdateBook;
using MediateBookStore.Application.Features.Books.Queries.GetAllBooks;
using MediateBookStore.Application.Features.Books.Queries.GetBookDetails;
using MediateBookStore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediateBookStore.Application.Profiles
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            //Map Author
            CreateMap<Author, AuthorsVM>().ReverseMap();
            CreateMap<Author, AuthorsDetVM>().ReverseMap();
            CreateMap<Author, CreateAuthorCommand>().ReverseMap();
            CreateMap<Author, UpdateAuthorCommand>().ReverseMap();
            CreateMap<Author, DeleteAuthorCommand>().ReverseMap();

            //Map Book
            CreateMap<Book, GetBooksListViewModel>().ReverseMap();
            CreateMap<Book, GetBookDetailViewModel>().ReverseMap();
            CreateMap<Author, AuthorDto>().ReverseMap();
            CreateMap<Book, CreateBookCommand>().ReverseMap();
            CreateMap<Book, UpdateBookCommand>().ReverseMap();
            CreateMap<Book, DeleteBookCommand>().ReverseMap();


        }
        
    }
}
