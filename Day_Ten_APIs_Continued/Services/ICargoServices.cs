//THis is our Menu
//Interface as a contract
//Is is a list of what our CargoServices MUST do. THis is not where the data is kept
using Day_Ten_APIs_Continued.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_Ten_APIs_Continued.Services
{
    public interface ICargoServices
    {
        // We are CRUD from our cargo database (CargoServices.cs)
        List<CargoItem> GetAll();

        List<CargoItem> GetByCategory(string Category);

        CargoItem GetById(int id);

        CargoItem Create(CargoItem item);

        bool Update(int id, CargoItem item);

        bool Delete(int id);
    }
}