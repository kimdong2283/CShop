using System;
using System.Collections.Generic;
using System.Text;

class CustomerService
{
    public void InputCustomers(List<Customer> customers, int count)
    {
        for (int i = 0; i < count; i++)
        {
            string name;
            while (true)
            {
                Console.Write("고객 이름: ");
                name = Console.ReadLine();
                if (string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("이름을 입력하세요");
                }
                else
                {
                    break;
                }
            }

            Console.Write("고객 나이: ");
            int age;
            while(true)
            {
                if (int.TryParse(Console.ReadLine(), out age))
                {
                   // Console.WriteLine(age);
                    break;
                }
                else
                {
                    Console.WriteLine("숫자만 입력하세요");
                    Console.Write("고객 나이: ");
                }
            } 
            customers.Add(new Customer(name,age));
        }
    }

    public void PrintCustomers(List<Customer> customers)
    {
       foreach(Customer customer in customers)
        {
            Console.WriteLine($"이름: {customer.name} 나이:{customer.age}");
        }
    }

    public void AgeAvg(List<Customer> customers)
    {
        int ageSum = 0;
        double ageAvg;

        foreach(Customer customer in customers)
        {
            ageSum += customer.age;
        }
        ageAvg = (double)ageSum / customers.Count;
        Console.WriteLine(ageAvg);
    }

    public void IndexCustomer(List<Customer> customers)
    {
        Console.Write("찾으실 고객 이름을 입력해주세요. ");
        string indexName = Console.ReadLine();
        int check = 0;
        for(int i = 0 ; i < customers.Count ; i++)
        {
            if(customers[i].name == indexName)
            {
                check++;
            }
        }

        if(check == 0)
        {
            Console.Clear();
            Console.WriteLine("해당되는 데이터가 없습니다.");
            return;
        }

        Console.WriteLine("나이 필터를 설정해주세요.");
        Console.WriteLine("1.이상 2.이하 3.설정한 나이 4.나이필터 사용하지 않음");
        int filterNumber = int.Parse(Console.ReadLine());
        int ageIndex = 0;
        if (filterNumber <=3)
        {
            Console.Write("찾으실 나이: ");
            ageIndex = int.Parse(Console.ReadLine());
        }

        bool found = false;

        if(filterNumber == 4)
        {
            Console.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                if(customers[i].name == indexName)
                {
                    Console.WriteLine($"이름: {customers[i].name} 나이: {customers[i].age}");
                    found = true;
                }
            }
        }
        else if(filterNumber == 1) 
        {
            Console.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].name == indexName && customers[i].age >= ageIndex)
                {
                    Console.WriteLine($"이름: {customers[i].name} 나이: {customers[i].age}");
                    found = true;
                }
            }
        }
        else if (filterNumber == 2)
        {
            Console.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].name == indexName && customers[i].age <= ageIndex)
                {
                    Console.WriteLine($"이름: {customers[i].name} 나이: {customers[i].age}");
                    found = true;
                }
            }
        }
        else if (filterNumber == 3)
        {
            Console.Clear();
            for (int i = 0; i < customers.Count; i++)
            {
                if (customers[i].name == indexName && customers[i].age == ageIndex)
                {
                    Console.WriteLine($"이름: {customers[i].name} 나이: {customers[i].age}");
                    found = true;
                }
            }
        }

        if(!found)
        {
            Console.Clear();
            Console.WriteLine("해당되는 데이터가 없습니다.");
        }

    }

    public void DeleteDate(List<Customer> customers)
    {
        if(customers.Count == 0)
        {
            Console.WriteLine("삭제할 데이터가 없습니다. 데이터를 추가해주세요");
            return;
        }

        int deleteNumber;
        int indexNumber;
        for(indexNumber = 1; indexNumber < customers.Count+1; indexNumber++)
        {
            Console.WriteLine($"{indexNumber}. 이름: {customers[indexNumber - 1].name} 나이:{customers[indexNumber - 1].age}");
        }

        Console.Write("삭제할 데이터의 번호: ");
        
        while(true)
        {
            if (int.TryParse(Console.ReadLine(), out deleteNumber) && deleteNumber < indexNumber)
            {
                break;
            }
            else if(deleteNumber > indexNumber - 1)
            {
                Console.WriteLine("없는 번호입니다.");
                Console.Write("삭제할 데이터의 번호: ");
            }
            else
            {
                Console.WriteLine("숫자만 입력하세요");
                Console.Write("삭제할 데이터의 번호: ");
            }
        }

        customers.RemoveAt(deleteNumber-1);

    }

    public void UpDate(List<Customer> customers)
    {
        string changeName;
        int changeAge;
        int selectNumber;
        int indexNumber;
        if(customers.Count == 0)
        {
            Console.WriteLine("수정할 데이터가 없습니다.");
            return;
        }

        for (indexNumber = 0; indexNumber < customers.Count; indexNumber++)
        {
            Console.WriteLine($"{indexNumber+1}. 이름: {customers[indexNumber].name} 나이:{customers[indexNumber].age}");
        }

        while(true)
        {
            Console.Write("업데이트할 데이터의 번호: ");
            if (int.TryParse(Console.ReadLine(), out selectNumber) && selectNumber <= indexNumber && selectNumber >= 1)
            {
                break;
            }
            else if(selectNumber > indexNumber)
            {
                Console.WriteLine("없는 번호입니다.");
            }
            else
            {
                Console.WriteLine("숫자만 입력하세요");
            }

        }

        while(true)
        {
            Console.Write("수정할 이름: ");
                   
            changeName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(changeName))
            {
                Console.WriteLine("이름을 적어주세요.");
                continue;  // 빈 입력값 들어오면 continue는 다시 while 처음으로간다. 숫자체크 안한다.
            }
            if (int.TryParse(changeName, out _))
            {
                Console.WriteLine("숫자가 아닌 이름을 입력하세요.");
                continue;
            }

            break;

            
        }

        while(true)
        {
            Console.Write("수정할 나이: ");

            if(int.TryParse(Console.ReadLine(),out changeAge) && changeAge >= 0)
            {
                break;
            }
            else if(changeAge < 0)
            {
                Console.WriteLine("정확한 나이를 입력하세요.");
            }
            else
            {
                Console.WriteLine("숫자만 입력하세요.");
            }
        }    

        customers[selectNumber-1].name = changeName;
        customers[selectNumber-1].age = changeAge;

    }
}
