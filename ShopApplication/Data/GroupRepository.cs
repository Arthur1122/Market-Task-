using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApplication.Data.Entities;

namespace ShopApplication.Data
{
    public class GroupRepository : IGroupRepository
    {
        private readonly MarketContext _context;

        public GroupRepository(MarketContext context)
        {
            this._context = context;
        }
        public void Add(Group group)
        {
            _context.Add(group);
        }

        public void Delete(Group group)
        {
            _context.Remove(group);
        }

        public Group[] GetAllGroups()
        {
            IQueryable<Group> query = _context.Groups;
            return query.ToArray();
        }

        public Group GetGroupById(int id)
        {
            IQueryable<Group> query = _context.Groups;
            query = query.Where(q => q.GroupId == id);
            return query.FirstOrDefault();
        }

        public bool SaveChanges()
        {
            return _context.SaveChanges()>0;
        }
    }
}
