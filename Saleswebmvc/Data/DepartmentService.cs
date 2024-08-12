using Saleswebmvc.Models;
using System.Collections.Generic;
namespace Saleswebmvc.Data;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


public class DepartmentService
{
    private SaleswebmvcContext _context;

    public DepartmentService(SaleswebmvcContext context)
    {
        _context = context;
    }

   public async Task<List<Department>> FindAllAsync()
        
    {
        return await _context.Department.OrderBy(x => x.Name).ToListAsync();
    }



}
