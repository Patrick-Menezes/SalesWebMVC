using System.Collections.Generic;
using System.Linq;
using Saleswebmvc.Models;
using Saleswebmvc.Data;

namespace Saleswebmvc.Services

{
    public class SellerService
    {
        private readonly SaleswebmvcContext _context;

        public SellerService(SaleswebmvcContext context)
        {
            _context = context;
        }


        public List<Seller> FindAll()
        {
            return _context.Sellers.ToList();
        }

        public void Insert(Seller obj) 
        {

           
            _context.Add(obj);
            _context.SaveChanges();
           
        }

        public Seller findById(int id) 
        {
            return _context.Sellers.FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        { 
          var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }





    }
}