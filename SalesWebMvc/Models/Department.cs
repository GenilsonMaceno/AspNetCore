using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int id { get; set; }
        public string name { get; set; }
        public ICollection<Seller> Seller { get; set; } = new List<Seller>();

        public Department()
        {

        }

        public Department(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public void AddSaller(Seller seller)
        {
            Seller.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            return Seller.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
