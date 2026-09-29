using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Threading.Tasks;
using Day_Sixteen_N_Tier_APIs.Data;
using Day_Sixteen_N_Tier_APIs.Models;

namespace Day_Sixteen_N_Tier_APIs.Repositories
{
    public class SupplyRepository : ISupplyRepository
    {

        private readonly AppDbContext _db;

        //constructor runs once when class is called automatically
        //ASP.NET Core hands us the database connection because we registered it in the Program.cs
        public SupplyRepository(AppDbContext db)
        {
             _db = db;
        }

        public List<Supply> GetAll()
        {
            return _db.Supplies.ToList();
        }

        public Supply? GetById(int id)
        {
            return _db.Supplies.Find(id);
        }

        public Supply Add(Supply supply)
        {
            _db.Supplies.Add(supply);
            _db.SaveChanges();

            return supply;
        }
        public void Update(Supply supply)
        {
            //The supply came out of the db through GetbyID so EFCore is already tracking it
            //We just need to save our changes
            _db.SaveChanges();
        }

        public void Delete (Supply supply)
        {
            _db.Supplies.Remove(supply);
            _db.SaveChanges();
        }
    }
}