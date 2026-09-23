
//CargoServices will be where our logic happens
//This is our kitchen
using Day_Ten_APIs_Continued.Models;

namespace Day_Ten_APIs_Continued.Services
{
    //ICargoServices is  PROMISE that this class will implement Every method within our interface
    public class CargoServices : ICargoServices
    {
       private static List<CargoItem> _manifest = [
         new CargoItem {Id =1, Name = "Rations Packs", Category = "Food", Masskg = 240},
         new CargoItem {Id =2, Name = "Battery Cells", Category = "Energy", Masskg = 1200 },
         new CargoItem {Id =3, Name = "Trauma Kits", Category = "Medical", Masskg = 50 },
         new CargoItem {Id =4, Name = "Healing Potion", Category = "Medical", Masskg = 10 }

       ];

        static int newId = 5;
       public List<CargoItem> GetAll()
        {
            return _manifest;
        }

        public List<CargoItem> GetByCategory(string category)
        {
            //We do not want to mutate our original list
            //We are putting our list in a copy so there isn't a chance we mutate it
            //IEnumerable = List with specific rules you can only iterate through
            IEnumerable<CargoItem> result = _manifest;
            //Linq queries are handy methods that we use to Query Lists/ Databases
            //Language integrated query
            //Where filters out then stores the condition in a list
            //=> is called an arrow function/ LMBDA shorthand for anonymous function
            //this will run once per item c => c.Category == category
            result = result.Where(c => c.Category == category);

            return result.ToList();
        }
        public CargoItem? GetById(int id)
        {
            CargoItem? item = _manifest.FirstOrDefault(c => c.Id == id);

            return item;
        }

        public CargoItem Create(CargoItem item)
        {
            item.Id = newId;
            newId++;

            _manifest.Add(item);

            return item;
        }

        public bool Update(int id, CargoItem item)
        {
            
            //first or default checks the list against the conditions c.Id == id
            //returns the first result or defaults to null
            CargoItem? existing = _manifest.FirstOrDefault(c => c.Id == id);

            if(existing == null)
            {
                return false;
            }

            existing.Name = item.Name;
            existing.Category = item.Category;
            existing.Masskg = item.Masskg;

            return true;
        }

        public bool Delete(int id)
        {
            CargoItem? existingItem = _manifest.FirstOrDefault(c => c.Id == id);
            
            if (existingItem == null)
            {
                
                return false;
            }

            _manifest.Remove(existingItem);

            return true;
        }
    }
}