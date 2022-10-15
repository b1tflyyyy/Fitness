using Fitness.BL.Model;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Controller
{
    public class EatingController : ControllerBase
    {
        private readonly User user;

        public List<Food> Foods { get; }

        public Eating Eating { get; }

        public EatingController(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.", nameof(user));

            Foods = GetAllFoods();

            Eating = GetEating().FirstOrDefault(t => true);
        }

        public void Add(Food food, double weight)
        {
            var product = Foods.SingleOrDefault(f => f.Name == food.Name);

            if(product == null)
            {
                Foods.Add(food);
                Eating.Add(food, weight);
                Save();
            }
            else
            {
                Eating.Add(product, weight);
                Save();
            }
                
        }

        private List<Eating> GetEating() => Load<Eating>();

        private List<Food> GetAllFoods() => Load<Food>();

        private void Save() => Save();
    }
}
