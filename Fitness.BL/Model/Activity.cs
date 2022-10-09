using System;

namespace Fitness.BL.Model
{
    [Serializable]
    public class Activity
    {
        public string Name { get; }
        
        public double CloriesPerMinute { get; }

        public Activity(string name, double caloriesPerMinute)
        {
            // TODO: Проверка

            Name = name;
            CloriesPerMinute = caloriesPerMinute;
        }

        public override string ToString() => Name;
    }
}
