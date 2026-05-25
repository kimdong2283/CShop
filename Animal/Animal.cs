public class Animal
{
    private int _age;
    private string _name;

    public string Name
    {
        get { return _name; }

        set
        {
            if (string.IsNullOrEmpty(value))
            {
                return;
            }

            if (int.TryParse(value, out _))
            {
                return;
            }

            _name = value;
        }
    }
    public int Age
    {
        get { return _age; }
        set
        {
            if (value >= 0)
            {
                _age = value;
            }
        }
    }
    public Animal()
    {

    }
    public Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}");
    }
}

class Dog : Animal
{
    private string _breed = string.Empty;
    public string Breed
    {
        get { return _breed; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }
            if (int.TryParse(value, out _))
            {
                return;
            }

            _breed = value;
        }
    }

    public Dog() { }
    public Dog(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[강아지] 이름: {Name}, 나이: {Age}, 품종: {Breed}");
    }
}

class Cat : Animal
{
    private string _breed = string.Empty;
    public string Breed
    {
        get { return _breed; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return;
            }
            if (int.TryParse(value, out _))
            {
                return;
            }

            _breed = value;
        }

    }

    public Cat(string name, int age, string breed) : base(name, age)
    {
        Breed = breed;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"[고양이] 이름: {Name}, 나이: {Age}, 품종: {Breed};");
    }
}


