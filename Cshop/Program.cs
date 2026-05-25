using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        CustomerService customerService = new CustomerService();
        List<Customer> customers = new List<Customer>();
        int count = 0;
        while (true)
        {
            Console.WriteLine("1. 입력");
            Console.WriteLine("2. 전체 출력");
            Console.WriteLine("3. 평균");
            Console.WriteLine("4. 검색");
            Console.WriteLine("5. 종료");
            Console.WriteLine("6. 데이터 삭제");
            Console.WriteLine("7. 데이터 수정");

            string menu = Console.ReadLine();

            if(menu == "1")
            {
                Console.Clear();

                Console.Write("몇명을 추가 하시겠습니까?");
                count = int.Parse(Console.ReadLine());

                customerService.InputCustomers(customers, count);

                Console.Clear();
            }
            else if(menu == "2")
            {
                Console.Clear();
                customerService.PrintCustomers(customers);

                Console.WriteLine("\n엔터 누르면 메뉴로 돌아감");
                Console.ReadLine();

                Console.Clear();
            }
            else if(menu == "3")
            {
                Console.Clear();
                customerService.AgeAvg(customers);

                Console.WriteLine("\n엔터 누르면 메뉴로 돌아감");
                Console.ReadLine();

                Console.Clear();
            }
            else if (menu == "4")
            {
                Console.Clear();
                customerService.IndexCustomer(customers);

                Console.WriteLine("\n엔터 누르면 메뉴로 돌아감");
                Console.ReadLine();

                Console.Clear();
            }
            else if (menu == "5")
            {
                break;
            }
            else if (menu == "6")
            {
                Console.Clear();
                customerService.DeleteDate(customers);

                Console.WriteLine("\n엔터 누르면 메뉴로 돌아감");
                Console.ReadLine();
                Console.Clear();
            }
            else if (menu == "7")
            {
                Console.Clear();
                customerService.UpDate(customers);

                Console.WriteLine("\n엔터 누르면 메뉴로 돌아감");
                Console.ReadLine();
                Console.Clear();
            }

        }

    }

}