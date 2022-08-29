using Fitness.BL.Controller;
using Fitness.BL.Model;
using System;

namespace Fitness.CMD
{
	public class Program
	{
		private static void Main(string[] args)
		{
			Console.WriteLine("Вас приветсвует приложение Fitness!");
			
			Console.WriteLine("Введите имя пользователя");
			var name = Console.ReadLine();

			Console.WriteLine("Введите пол");
			var gender = Console.ReadLine();

			Console.WriteLine("Введите дату рождения");
			var birthdate = DateTime.Parse(Console.ReadLine()); // TODO: переписать

            Console.WriteLine("Введите вес");
            var weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите рост");
            var height = double.Parse(Console.ReadLine());

			var userController = new UserController(name,
													gender,
													birthdate,
													weight,
													height);

			userController.Save();




        }
	}
}
