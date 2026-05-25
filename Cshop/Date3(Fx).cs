using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
static List<Person> InputPeople(int count)
{
    List<Person> people = new List<Person>();

    for(int i = 0; i < count; i ++)
    {
        Person p = new Person();

        Console.Write("이름: ");
        p.Name = Console.ReadLine();

        Console.Write("나이: ");
        p.Age = int.Parse(Console.ReadLine());

        people.Add(p);
    }

    return people;
}

static void listAvg(List<Person> people)
{
    int sum = people.Sum(p => p.Age);
    double avg = (double)sum / people.Count;   
    Console.WriteLine($"{avg:F2}");
}

static void printPeople(List<Person> people)
{
    foreach (Person person in people)
    {
        Console.WriteLine($"이름: {person.Name} 나이:{person.Age}");
    }
}

static void indexPeople(List<Person> people)
{
    Console.Write("찾을 이름: ");
    string indexName = Console.ReadLine();
    int check = 0;
    for (int i = 0; i < people.Count(); i++)
    {
        if (people[i].Name == indexName)
        {
            check++;
        }
    }

    if(check == 0) { Console.WriteLine("해당하는 사람이 없습니다"); return; }

    Console.Write("몇살 이상이신가요? ");
    string ageFilter = Console.ReadLine();

    bool found = false;

    if(string.IsNullOrEmpty(ageFilter))
    {
        for(int i = 0;i < people.Count; i++)
        {
            if (people[i].Name == indexName)
            {
                Console.Write($"찾는 사람 이름: {people[i].Name} 찾는 사람 나이: {people[i].Age}");
                found = true;
            }
        }
    }
    else
    {
        int age = int.Parse(ageFilter);
        for (int i = 0; i < people.Count(); i++)
        {
            if (people[i].Name == indexName && people[i].Age >= age)
            {
                Console.Write($"찾는 사람 이름: {people[i].Name} 찾는 사람 나이: {people[i].Age}");
                found = true;
            }
        }
    }

    if (!found)
    {
        Console.Write("해당하는 사람이 없습니다.");
    }
}

List<Person> a = InputPeople(2);
printPeople(a);
indexPeople(a);

