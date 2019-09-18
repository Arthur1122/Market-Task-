using AutoMapper;
using ShopApplication.Data.Entities;
using ShopApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public class MarketProfile : Profile
    {
        public MarketProfile()
        {
            this.CreateMap<Product, ProductModel>()
                .ForMember(c => c.ProductId, m => m.MapFrom(n => n.ProductId))
                .ForMember(c => c.ProductName, o => o.MapFrom(m => m.ProductName))
                .ForMember(c => c.ProductPrice, m => m.MapFrom(n => n.ProductPrice))
                .ForMember(c => c.CodeProduct, m => m.MapFrom(n => n.CodeProduct))
                .ForMember(c => c.GroupId, m => m.MapFrom(n => n.Group.GroupId))
                .ReverseMap();

            this.CreateMap<ProductModel, Product>()
               .ForMember(c => c.ProductId, m => m.MapFrom(n => n.ProductId))
               .ForMember(c => c.ProductName, o => o.MapFrom(m => m.ProductName))
               .ForMember(c => c.ProductPrice, m => m.MapFrom(n => n.ProductPrice))
               .ForMember(c => c.CodeProduct, m => m.MapFrom(n => n.CodeProduct))
               .ForPath(c => c.Group.GroupId, m => m.MapFrom(n => n.GroupId))
               .ReverseMap();

            this.CreateMap<Group, GroupModel>()
               .ForMember(c => c.GroupId, o => o.MapFrom(m => m.GroupId))
               .ForMember(c => c.GroupName, o => o.MapFrom(m => m.Name))
               .ForMember(c => c.GroupCode, m => m.MapFrom(n => n.GroupCode))
               .ForMember(c => c.GroupColor, m => m.MapFrom(n => n.Color))
               .ReverseMap();

            this.CreateMap<GroupModel, Group>()
               .ForMember(c => c.GroupId, o => o.MapFrom(m => m.GroupId))
               .ForMember(c => c.Name, o => o.MapFrom(m => m.GroupName))
               .ForMember(c => c.GroupCode, m => m.MapFrom(n => n.GroupCode))
               .ForMember(c => c.Color, m => m.MapFrom(n => n.GroupColor))
               .ReverseMap();

            this.CreateMap<SaleModel, Sale>()
               .ForMember(c => c.SaleId, m => m.MapFrom(n => n.SaleId))
               .ForMember(c => c.dateTime, o => o.MapFrom(m => m.dateTime))
               .ForPath(c => c.Group.GroupId, m => m.MapFrom(n => n.GroupId))
               .ForPath(c => c.Product.ProductId, m => m.MapFrom(n => n.ProductId))
               .ForMember(c => c.Count, m => m.MapFrom(n => n.Count))
               .ReverseMap();

            this.CreateMap<Sale, SaleModel>()
               .ForMember(c => c.SaleId, m => m.MapFrom(n => n.SaleId))
               .ForMember(c => c.dateTime, o => o.MapFrom(m => m.dateTime))
               .ForPath(c => c.GroupId, m => m.MapFrom(n => n.Group.GroupId))
               .ForPath(c => c.ProductId, m => m.MapFrom(n => n.Product.ProductId))
               .ForMember(c => c.Count, m => m.MapFrom(n => n.Count))
               .ReverseMap();

            this.CreateMap<HistoryModel, History>()
               .ForMember(c => c.Date, m => m.MapFrom(n => n.Date))
               .ForPath(c => c.Product.ProductId, o => o.MapFrom(m => m.ProductId))
               .ForPath(c => c.Group.GroupId, m => m.MapFrom(n => n.GroupId))
               .ForPath(c => c.Product.ProductId, m => m.MapFrom(n => n.ProductId))
               .ForPath(c => c.Sale.SaleId, m => m.MapFrom(n => n.SaleId))
               .ReverseMap();

            this.CreateMap<History, HistoryModel>()
               .ForMember(c => c.Date, m => m.MapFrom(n => n.Date))
               .ForPath(c => c.ProductId, o => o.MapFrom(m => m.Product.ProductId))
               .ForPath(c => c.GroupId, m => m.MapFrom(n => n.Group.GroupId))
               .ForPath(c => c.ProductId, m => m.MapFrom(n => n.Product.ProductId))
               .ForPath(c => c.SaleId, m => m.MapFrom(n => n.Sale.SaleId))
               .ReverseMap();
        }
    }
}
