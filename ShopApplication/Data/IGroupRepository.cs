using ShopApplication.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApplication.Data
{
    public interface IGroupRepository
    {
        Group[] GetAllGroups();
        Group GetGroupById(int id);
        void Delete(Group group);
        void Add(Group group);
        bool SaveChanges();
    }
}
