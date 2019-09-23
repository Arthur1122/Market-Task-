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
                return RedirectToAction("Index","Group");
            }
            else         
            {
                return View("Error while saving data to database");
            }
            
        }

        public ActionResult GetGroup(int id)
        {
            var group = _groupRepository.GetGroupById(id);
            return View(_mapper.Map<GroupModel>(group));
        }

        [HttpPost]
        public ActionResult Put([FromForm] GroupModel model)
        {
            var groupv = _groupRepository.GetGroupById(model.GroupId);
            _mapper.Map(model, groupv);
            _mapper.Map<Group>(groupv);
            if (_groupRepository.SaveChanges())
            {
                return RedirectToAction("Index","Group");
            }
            else
            {
                return View("Error while saving data to database");
            }
        }
    }
}

        

    
