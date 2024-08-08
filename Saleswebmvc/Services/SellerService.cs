using System.Collections.Generic;
using System.Linq;
using Saleswebmvc.Models;
using Saleswebmvc.Data;
using Microsoft.EntityFrameworkCore;
using Saleswebmvc.Services.Exception;
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
            return _context.Sellers.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        { 
          var obj = _context.Sellers.Find(id);
            _context.Sellers.Remove(obj);
            _context.SaveChanges();
        }



        public void Update(Seller obj)
        {
            if (!_context.Sellers.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not Found");
            }

            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException ex)
            {
                {
                    throw new DbConcurrencyException(ex.Message);
                }



            }





        }



    }
}