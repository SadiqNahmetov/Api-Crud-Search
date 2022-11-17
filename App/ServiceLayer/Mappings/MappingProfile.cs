using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Book;
using ServiceLayer.DTOs.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<ProductCreateDto, Product>();
            CreateMap<Product, ProductListDto>();
            CreateMap<ProductUpdateDto, Product>().ReverseMap();


            CreateMap<BookCreateDto, Book>();
            CreateMap<Book, BookListDto>();
            CreateMap<BookUpdateDto, Book>().ReverseMap();


        }
    }
}
