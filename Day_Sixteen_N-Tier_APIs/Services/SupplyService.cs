
using Day_Sixteen_N_Tier_APIs.DTOs;
using Day_Sixteen_N_Tier_APIs.Models;
using Day_Sixteen_N_Tier_APIs.Repositories;
//The Service is where the rules live and it's where our DTO and Models meet
//Controllers<- DTO -> Services <- Models -> Repository
namespace Day_Sixteen_N_Tier_APIs.Services
{
    public class SupplyService : ISupplyService
    {
        private readonly ISupplyRepository _repository;

        public SupplyService(ISupplyRepository repository)
        {
            _repository = repository;
        }

        public List<SupplyReadDTO> GetAll()
        {
            //list will come out in alphabetical order
            //LINQ Select for every record in our DB we will do x to

            return _repository.GetAll()
            .OrderBy(s => s.Name)
            .Select(s => ToReadDTO(s))//turn every model into a DTO
            .ToList();
        }
        public SupplyReadDTO? GetById(int id)
        {
            Supply? supply = _repository.GetById(id);

            if (supply is null)
            {
                return null;
            }

            return ToReadDTO(supply);
        }
        //Rules: Must have a name and you can't stock fewer than Zero
        //Rules 2 no 2 supplies can have the same name
        public SupplyReadDTO? Create(SupplyCreateDTO dto)
        {

            // if (supply.Quantity <= 0 || string.IsNullOrWhiteSpace(supply.Name))
            // {
            //     return null;
            // }
            // We do not need the above code since the DTO has the [Require] and [Range] requirements

            bool exists = _repository.GetAll().Any(s => s.Name.ToLower() == dto.Name.ToLower());

            if (exists)
            {
                return null;
            }

            //DTO -> Model

            Supply supply = new Supply();

            supply.Name = dto.Name;
            supply.Quantity = dto.Quantity;
            supply.StorageLocation = "Storage Bay";

            //We are creating a new Supply variable and storing our added supply
            Supply created = _repository.Add(supply);

            return ToReadDTO(created);
        }
        //Rules: You must take at least 1, and never more than we have
        public bool Withdraw(int id, int amount)
        {
            Supply? existing = _repository.GetById(id);

            if (existing == null || amount > existing.Quantity || amount <= 0)
            {
                return false;
            }

            existing.Quantity -= amount;
            _repository.Update(existing);
            return true;
        }

        public void Delete(int id)
        {
            Supply? supply = _repository.GetById(id);
            // if not null (i.e is found when ID is entered, will delete record)
            if (supply != null)
            {
                _repository.Delete(supply);
            }
        }
        //Our helper method that takes in our Supply model and outputs to SupplyReadDTO
        private static SupplyReadDTO ToReadDTO(Supply supply)
        {
            SupplyReadDTO outputDTO = new SupplyReadDTO();
            outputDTO.Id = supply.Id;
            outputDTO.Name = supply.Name;
            outputDTO.Quantity = supply.Quantity;

            return outputDTO;

        }

    }

}
