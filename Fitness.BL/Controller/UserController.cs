using System;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Formatters.Binary;
using Fitness.BL.Model;


namespace Fitness.BL.Controller
{
    /// <summary>
    /// Контроллер пользователя.
    /// </summary>
    public class UserController
    {
        /// <summary>
        /// Пользователь приложения.
        /// </summary>
        public User User { get; }

        /// <summary>
        /// Создание нового контроллера пользователя.
        /// </summary>
        /// <param name="user"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UserController(string userName, 
                              string genderName,
                              DateTime birthDay,
                              double weight,
                              double height)
        {
            // TODO: Проверка

            var gender = new Gender(genderName);
            var user = new User(userName, 
                                gender,
                                birthDay,
                                weight,
                                height);
        }

        /// <summary>
        /// Сохранить данные пользователя.
        /// </summary>
        public void Save()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, User);
            }
        }

        /// <summary>
        /// Получить данные пользователя.
        /// </summary>
        /// <returns> Пользователь приложения. </returns>
        public UserController()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("data.json", FileMode.OpenOrCreate))
            {
                if (formatter.Deserialize(fs) is User user)
                    User = user;

                // TODO: Что делать, если пользователя не прочитали
            }
        }
    }
}
