using Saleswebmvc.Models;
using System.Collections.Generic;
namespace Saleswebmvc.Data
{
    public class DepartmentService
    {
        private SaleswebmvcContext _context;

        public DepartmentService(SaleswebmvcContext context)
        {
            _context = context;
        }

        public List<Department>  FindAll()
        {
            return _context.Department.OrderBy(x => x.Name).ToList();
        }



    }
}
