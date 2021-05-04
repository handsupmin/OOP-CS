using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zookeeper
{
    class Mammal
    {
        public void Nurse() { }
    }

    class Dog : Mammal
    {
        public void Bark() { }
    }
    class Cat : Mammal
    {
        public void Meow() { }
    }
    class Elephant : Mammal
    {
        public void Pou() { }
    }
    class Lion : Mammal
    {
        public void Crow() { }
    }

    class Zookeeper
    {
        public void Wash(Mammal mammal) { Console.WriteLine("{0} 동물을 wash합니다.", mammal); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Cat cat = new Cat();
            Elephant elephant = new Elephant();
            Lion lion = new Lion();

            Zookeeper zookeeper = new Zookeeper();
            zookeeper.Wash(dog);
            zookeeper.Wash(cat);
            zookeeper.Wash(elephant);
            zookeeper.Wash(lion);
        }
    }
}
