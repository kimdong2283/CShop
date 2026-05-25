using System;
using System.Collections.Generic;
using System.Text;

public class AnimalService
{
    private List<Animal> Doganimals = new List<Animal>();
    private List<Animal> Catanimals = new List<Animal>();

    public void AddAnimal(Animal animal)
    {
        if (animal is Dog)
        {
            Doganimals.Add(animal);
        }
        else if (animal is Cat)
        {
            Catanimals.Add(animal);
        }
    }

    public List<Animal> GetAnimals(int count)
    {
        List<Animal> animalsList = new List<Animal>();

        for (int i = 0; i < count; i++)
        {
            Animal animal = new Animal();
            Console.Write("이름: ");
            animal.Name = Console.ReadLine();

            Console.Write("나이: ");
            animal.Age = int.Parse(Console.ReadLine());

            //animals.Add(animal);  전에 추가했던거 안사라지게
            animalsList.Add(animal); // 전에했던거 사라지게
        }
        return animalsList;
        //return animals; 전에 추가했던거 안사라지게
    }


    public void PrintAll()
    {
        string selectAnimal;
        while(true)
        {
            Console.Write("출력할 동물 종류를 선택하세요 (Dog/Cat): ");
        selectAnimal = Console.ReadLine();
            if (selectAnimal == "Dog")
            {
                if (Doganimals.Count == 0)
                {
                    Console.WriteLine("등록된 동물이 없습니다.");
                    return;
                }

                foreach (Animal animal in Doganimals)
                {
                    animal.PrintInfo();
                    
                }

                break;
            }
            else if (selectAnimal == "Cat")
            {
                if (Catanimals.Count == 0)
                {
                    Console.WriteLine("등록된 동물이 없습니다.");
                    return;
                }

                foreach (Animal animal in Catanimals)
                {
                    animal.PrintInfo();
                    
                }
                break;
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다. Dog 또는 Cat을 입력하세요.");
            }
        }
    }

    public void SearchByName()
    {
        string indexDogCat;
        string indexDogName;
        string indexCatName;
        bool dogFound = false;
        bool catFound = false;

        /*
        foreach (Animal animal in animals)
        {
            animal.PrintInfo();
        }
        */

        if (Doganimals.Count == 0 && Catanimals.Count == 0)
        {
            Console.WriteLine("등록된 동물이 없습니다.");
            return;
        }
        while (true)
        {
            Console.Write("검색할 동물의 이름을 입력하세요 (Dog/Cat): ");
            indexDogCat = Console.ReadLine();
            if(string.IsNullOrEmpty(indexDogCat) || (indexDogCat != "Dog" && indexDogCat != "Cat"))
            {
                Console.WriteLine("잘못된 입력입니다. Dog 또는 Cat을 입력하세요.");
            }
            else
            {
                break;
            }
        }

        while(true)
        {
            if (indexDogCat == "Dog")
            {
                Console.WriteLine("검색할 강아지 이름을 입력하세요:");
                indexDogName = Console.ReadLine();
                if(string.IsNullOrWhiteSpace(indexDogName))
                {
                    Console.WriteLine("잘못된 입력입니다. 이름을 입력하세요.");
                    continue;
                }
                if(int.TryParse(indexDogName, out _))
                {
                    Console.WriteLine("잘못된 입력입니다. 이름을 입력하세요.");
                    continue;
                }

                for (int i = 0; i < Doganimals.Count; i++)
                {
                    if (indexDogName == Doganimals[i].Name)
                    {
                        Console.WriteLine("동물을 찾았습니다:");
                        
                        Doganimals[i].PrintInfo();
                        dogFound = true;
                        return;
                    }
                }

                if (!dogFound)
                {
                    Console.WriteLine($"'{indexDogName}'을 찾지 못했습니다.");
                }
                break;
            }
        }
        
        while(true)
        {
            if (indexDogCat == "Cat")
            {
                Console.WriteLine("검색할 고양이 이름을 입력하세요:");
                indexCatName = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(indexCatName))
                {
                    Console.WriteLine("잘못된 입력입니다. 이름을 입력하세요.");
                    continue;
                }
                if (int.TryParse(indexCatName, out _))
                {
                    Console.WriteLine("잘못된 입력입니다. 이름을 입력하세요.");
                    continue;
                }

                for (int i = 0; i < Catanimals.Count; i++)
                {
                    if (indexCatName == Catanimals[i].Name)
                    {
                        Console.WriteLine("동물을 찾았습니다:");
                        Catanimals[i].PrintInfo();
                        catFound = true;
                        return;
                    }
                }
                if (!catFound)
                {
                    Console.WriteLine($"'{indexCatName}'을 찾지 못했습니다.");
                }

                break;
            }
        }
     }

    public void EndProgram()
    {
        Console.WriteLine("프로그램을 종료합니다.");
        Environment.Exit(0);
    }

}