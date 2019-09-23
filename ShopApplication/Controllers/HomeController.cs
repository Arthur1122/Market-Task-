using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopApplication.Data;
using ShopApplication.Data.Entities;
using ShopApplication.Models;

namespace ShopApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        public HomeController(IMapper mapper, IProductRepository repository)
        {
            _mapper = mapper;
            _productRepository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var groups = _productRepository.GetAllProducts();
            return View(_mapper.Map<IEnumerable<ProductModel>>(groups));
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([FromForm] ProductModel model)
        {
            var group = _mapper.Map<Product>(model);

            _productRepository.Add(group);
            if (_productRepository.SaveChanges())
            {
                return RedirectToAction("Index", "Group");

            }
            else
            {
                return View("Error while saving data to database");
            }

        }

        public ActionResult GetProduct(int id)
        {
            var product = _productRepository.GetProductById(id);
            return View(_mapper.Map<ProductModel>(product));
        }

        [HttpPost]
        public ActionResult Update([FromForm] ProductModel model)
        {
            var product = _productRepository.GetProductById(model.ProductId);
            _mapper.Map(model, product);
            if (_productRepository.SaveChanges())
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View("Error while saving data to database");
            }

        }
    }
}
