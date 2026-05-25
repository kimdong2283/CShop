using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {


        AnimalService animalService = new AnimalService();
        
        List<Animal> animals = new List<Animal>();

        Animal animal = new Animal();
        animal.Name = "123";
        Console.WriteLine(animal.Name);
        /*
        Dog dog = new Dog();
        dog.Name = "Test";
        dog.Breed = "  1313";
        dog.Age = 10;
        Console.WriteLine(dog.Breed);
        */
        while (true)
        {
            Console.WriteLine("1. 강아지 등록");
            Console.WriteLine("2. 고양이 등록");
            Console.WriteLine("3. 동물 목록 보기");
            Console.WriteLine("4. 이름 검색");
            Console.WriteLine("0. 종료");

            string menu;

            while (true)
            {
                menu = Console.ReadLine();
                if (menu == "1" || menu == "2" || menu == "3" || menu == "4" || menu == "0")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                }
            }


            if (menu == "1")
            {
                /*
                int count;
                Console.WriteLine("강아지 이름:");
                count = int.Parse(Console.ReadLine());
                animals = animalService.GetAnimals(count);
                */

                string name;
                string breed;
                int age;
                Console.WriteLine("강아지 이름:");
                while(true)
                {
                    name = Console.ReadLine();
                    if (!string.IsNullOrEmpty(name))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("이름은 비어 있을 수 없습니다. 다시 입력해주세요.");
                    }
                }

                Console.WriteLine("강아지 나이:");
                while(true)
                {
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    }
                }
                Console.WriteLine("강아지 품종:");
                while(true)
                {
                    breed = Console.ReadLine();
                    if (!string.IsNullOrEmpty(breed))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("품종은 비어 있을 수 없습니다. 다시 입력해주세요.");
                    }
                }
                Dog dog = new Dog(name, age, breed);

                animalService.AddAnimal(dog);
                
            }
            else if (menu == "2")
            {
                string name;
                string breed;
                int age;

                while (true)
                {
                    Console.WriteLine("고양이 이름:");
                    name = Console.ReadLine();
                    if (string.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("이름을 적어주세요.");
                        continue;
                    }
                    if (int.TryParse(name, out _))
                    {
                        Console.WriteLine("숫자가 아닌 품종을 입력하세요.");
                        continue;
                    }
                    break;
                }

                Console.WriteLine("고양이 나이:");
                while (true)
                {
                    if (int.TryParse(Console.ReadLine(), out age))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                    }
                }
                while(true)
                {
                    Console.WriteLine("고양이 품종:");
                    breed = Console.ReadLine();
                    if (string.IsNullOrWhiteSpace(breed))
                    {
                        Console.WriteLine("품종을 적어주세요.");
                        continue;  // 빈 입력값 들어오면 continue는 다시 while 처음으로간다. 숫자체크 안한다.
                    }
                    if (int.TryParse(breed, out _))
                    {
                        Console.WriteLine("숫자가 아닌 품종을 입력하세요.");
                        continue;
                    }

                    break;
                }
               
                Cat cat = new Cat(name, age, breed);

                animalService.AddAnimal(cat);
            }
            else if (menu == "3")
            {
                animalService.PrintAll();
            }
            else if(menu == "4")
            {
                animalService.SearchByName();
            }
            else if(menu == "0") 
            {
                animalService.EndProgram();
            }
        }    

    }
}
