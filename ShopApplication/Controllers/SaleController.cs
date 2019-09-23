using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopApplication.Data;

namespace ShopApplication.Controllers
{
    public class SaleController : Controller
    {
        private readonly IMapper _mapper;
        private readonly ISaleRepository _saleRepository;
        private readonly IProductRepository _productRepository;
        private readonly IGroupRepository _groupRepository;

        public SaleController( IMapper mapper,ISaleRepository saleRepository,
                              IProductRepository productRepository,
                              IGroupRepository groupRepository
                             )
        {
            this._mapper = mapper;
            this._saleRepository = saleRepository;
            this._productRepository = productRepository;
            this._groupRepository = groupRepository;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}