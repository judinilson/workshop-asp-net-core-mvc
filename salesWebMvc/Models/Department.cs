using System;
using System.Collections.Generic;
using System.Linq;
namespace salesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Seller> Sellers { get; set; } = new List<Seller>();

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSaller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime Initial, DateTime final)
        {
            //somando utlizando sum de linq 
            return Sellers
                .Sum(sl => sl.TotalSales(Initial, final));
                
        }
    }
}
