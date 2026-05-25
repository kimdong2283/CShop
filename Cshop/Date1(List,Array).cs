using System.Diagnostics.CodeAnalysis;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

Console.Write("몇개 입력할겁니까?");
int count = int.Parse(Console.ReadLine());

List<int> nums = new List<int>();


for (int i = 0; i < count; i++)
{
    Console.Write("숫자 입력: ");
    int n = int.Parse(Console.ReadLine());
   if(n%2 == 0)
    {
        Console.WriteLine("짝수");
    }
    else
    {
        Console.WriteLine("홀수");
    }
    nums.Add(n);
}

int max = nums.Max();
Console.Write("리스트 최대치: ");
Console.WriteLine(max);

int sum = nums.Sum();
Console.Write("리스트 합: ");
Console.WriteLine(sum);

int SumAvg=0;
for(int i = 0;i < nums.Count;i++)
{
    SumAvg += nums[i];

}

double Avg = (double)SumAvg/nums.Count;
Console.Write("리스트 평균: ");
Console.WriteLine($"{Avg:F2}");


    



