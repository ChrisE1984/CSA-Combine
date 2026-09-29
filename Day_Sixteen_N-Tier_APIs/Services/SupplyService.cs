using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Day_Sixteen_N_Tier_APIs.Models;
using Day_Sixteen_N_Tier_APIs.Repositories;

namespace Day_Sixteen_N_Tier_APIs.Services
{
    public class SupplyService : ISupplyService
    {
        private readonly ISupplyRepository _repository;

        public SupplyService(ISupplyRepository repository)
        {
            _repository = repository;
        }

        public List<Supply> GetAll()
        {
            //list will come out in alphabetical order
            return _repository.GetAll().OrderBy(s => s.Name).ToList();
        }
        public Supply? GetById(int id)
        {
            return _repository.GetById(id);
        }
        //Rules: Must have a name and you can't stock fewer than Zero
        public Supply? Create(Supply supply)
        {

            if (supply.Quantity <= 0 || string.IsNullOrWhiteSpace(supply.Name))
            {
                return null;
            }

            return _repository.Add(supply);
        }
        //Rules: You must take at least 1, and never more than we have
        public bool Withdraw(Supply supply, int amount)
        {
            if (amount > supply.Quantity || amount <= 0)
            {
                return false;
            }

            supply.Quantity -= amount;
            _repository.Update(supply);
            return true;
        }

        public void Delete(Supply supply)
        {
            _repository.Delete(supply);
        }
    }
}
