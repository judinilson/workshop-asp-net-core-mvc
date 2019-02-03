using System;
using System.Collections.Generic;
using System.Linq;


namespace salesWebMvc.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SellesRecord> sales { get; set; } = new List<SellesRecord>();

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthday, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            Birthday = birthday;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSeles(SellesRecord sr)
        {
            sales.Add(sr);
        }

        public void RemoveSeles(SellesRecord sr)
        {
            sales.Remove(sr);
        }

        public double TotalSales(DateTime Initial, DateTime final)
        {
            //filtrando utlizando where de linq 
            return sales
                .Where(sr => sr.Date >= Initial && sr.Date <= final)
                .Sum(sr => sr.Amount);
        }

    }
}
