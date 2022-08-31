﻿using Fitness.BL.Model;
using System;
using System.Runtime.Serialization.Formatters.Binary;

namespace Fitness.BL.Controller
{
    public class EatingController : ControllerBase
    {
        private const string pathFood = "foods.dat";

        private const string pathEatings = "eatings.dat";

        private readonly User user;

        public List<Food> Foods { get; }

        public Eating Eating { get; }

        public EatingController(User user)
        {
            this.user = user ?? throw new ArgumentNullException("Пользователь не может быть пустым.", nameof(user));

            Foods = GetAllFoods();

            Eating = GetEating();
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

        private Eating GetEating() => Load<Eating>(pathEatings) ?? new Eating(user);

        private List<Food> GetAllFoods() => Load<List<Food>>(pathFood) ?? new List<Food>();

        private void Save() { Save(pathFood, Foods); Save(pathEatings, Eating); }
    }
}
