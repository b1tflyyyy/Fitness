using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Activity
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
       
        public virtual ICollection<Exercise> Exercises { get; set; }
        
        public double CloriesPerMinute { get; set; }

        public Activity() { }

        public Activity(string name, double caloriesPerMinute)
        {
            // TODO: Проверка

            Name = name;
            CloriesPerMinute = caloriesPerMinute;
        }

        public override string ToString() => Name;
    }
}
