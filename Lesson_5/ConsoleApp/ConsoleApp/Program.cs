/*using System;

namespace CSharpEssentials
{
    public class Car
    {
        public string Name = "Toyota Camry 3";
        public int Age = 1;
    }

    class Program
    {
        static void Main()
        {
            Car myCar = new Car();
          
            // Допишите здесь код
            Console.WriteLine(myCar.Name + " ");
        }
    }
}*/

using System;
using System.Xml.Linq;

namespace CSharpEssentials
{
    public class Animal
    {
        public string Name = "Волк";
        public int Age;
        public double Speed;
        public double Weight;
    }
    class Program
    {
        static void Main()
        {
            // 1. Создайте объект класса Animal

            Animal Volk = new Animal();


            // 2. Инициализируете поля 

            Volk.Name = "Волк";
            Volk.Age = 5;
            Volk.Speed = 8.4;
            Volk.Weight = 37.5;
            // 3. выведите значения полей

            Console.WriteLine(Volk.Name + " " + Volk.Age + " " + Volk.Speed + " " + Volk.Weight);
        }

    }
}

