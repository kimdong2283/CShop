using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

Console.Write("리스트 인원수: ");
int listCount = int.Parse(Console.ReadLine());
int listAvg=0;

List<Person> people = new List<Person>();

for(int i =  0; i < listCount; i++ )
{
    Person p = new Person();
    Console.Write("이름: ");
    p.Name = Console.ReadLine();

    Console.Write("나이: ");
    p.Age = int.Parse(Console.ReadLine());
    
    people.Add(p);
}

for(int i = 0;i < people.Count;i++ )
{
    Console.WriteLine($"이름: {people[i].Name}, 나이: {people[i].Age}");
}

Console.Write("리스트 평균 나이: ");
foreach(Person p in people)
{
    listAvg += p.Age;
}
Console.WriteLine($"{listAvg/listCount}");

Console.Write("찾을 이름: ");
string indexName = Console.ReadLine();
Console.Write("몇살 이상부터 찾으시나요: ");
string ageFilter = Console.ReadLine();

bool found = false;

if (string.IsNullOrEmpty(ageFilter))
{
    for (int i = 0; i < listCount; i++)
    {
        if (indexName == people[i].Name)
        {
            Console.WriteLine($"이름: {people[i].Name}, 나이: {people[i].Age}");
            found = true;
        }
    }
}
else
{
    int minAge = int.Parse(ageFilter);

    for (int i = 0; i < listCount; i++)
    {
        if (indexName == people[i].Name && people[i].Age >= minAge)
        {
            Console.WriteLine($"이름: {people[i].Name}, 나이: {people[i].Age}");
            found = true;
        }
    }
}

if(!found)
{
    Console.WriteLine("찾을 내용이 없습니다.");
}








