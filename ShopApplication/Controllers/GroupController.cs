using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopApplication.Data;
using ShopApplication.Data.Entities;
using ShopApplication.Models;

namespace ShopApplication.Controllers
{

    public class GroupController : Controller
    {
        private readonly IGroupRepository _groupRepository;
        private readonly IMapper _mapper;
        public GroupController(IMapper mapper, IGroupRepository repository)
        {
            _mapper = mapper;
            _groupRepository = repository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var groups = _groupRepository.GetAllGroups();
            return View(_mapper.Map<IEnumerable<GroupModel>>(groups));
        }
        
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add([FromForm] GroupModel model)
        {
            var group = _mapper.Map<Group>(model);
            
            _groupRepository.Add(group);
            if (_groupRepository.SaveChanges())
            {
                return Ok();
            }
            else         
            {
                return View("Error while saving data to database");
            }
            
        }
    }
}

        

    
