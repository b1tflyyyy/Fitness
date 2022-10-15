using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Food
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        /// <summary>
        /// Белки.
        /// </summary>
        public double Proteins { get; set; }

        /// <summary>
        ///  Жиры.
        /// </summary>
        public double Fats { get; set; }
        
        /// <summary>
        /// Углеводы.
        /// </summary>
        public double Carbohydrates { get; set; }

        /// <summary>
        /// Калории за 100 грамм продукта.
        /// </summary>
        public double Calories { get; set; }

        public Food() { }

        public Food(string name) : this(name, 0, 0, 0, 0) { }

        public Food(string name, 
                    double calories, 
                    double proteins, 
                    double fats, 
                    double carbohydrates)
        {
            // TODO: проверка.


            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Carbohydrates = carbohydrates / 100.0;
        }

        public override string ToString() => Name;
    }
}
