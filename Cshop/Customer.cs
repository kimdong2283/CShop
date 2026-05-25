using System;
using System.Collections.Generic;
using System.Text;

class Customer
{
    private int _age;
    public string name {  get; set; }
    public int age 
    { get { return _age; } 
      set
        {
            if(value >= 0)
            {
                _age = value;
            }
        }
    } 
    
    public Customer(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}