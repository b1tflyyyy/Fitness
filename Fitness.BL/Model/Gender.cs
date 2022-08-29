using System;

namespace Fitness.BL.Model
{
    /// <summary>
    /// Пол.
    /// </summary>
    [Serializable]
    public class Gender
    {
        /// <summary>
        /// Название.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Создать новый пол.
        /// </summary>
        /// <param name="name"> Имя пола. </param>
        public Gender(string name)
        {
            if(string.IsNullOrEmpty(name))
                throw new ArgumentNullException("Имя пола не может быть пустым или null", nameof(name));

            Name = name;
        }

        public override string ToString() => Name;
    }
}
