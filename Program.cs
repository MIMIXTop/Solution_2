
class Program
{
class Crocodile
{
    private string name { get; }
    private char gender { get; }
    private int age { get; }
    private int length = 0;
    private int weight { get; }
    
    public Crocodile(string Name, char Gender, int Age, int Weight, int Length)
    {
        this.name = Name;
        this.age = Age;
        this.gender = Gender;
        this.length = Length;
        this.weight = Weight;
    }

    public override string ToString()
    {
        return "Крокодил:" + this.name + " Пол:" +  this.gender + " Возрост:" + this.age + " Вес:" + this.weight + " Длина:" + this.length + ";";
    }

    public int GetLength()
    {
        return length;
    }
    
    public string GetName()
    {
        return this.name;
    }
    
    public int GetWeight()
    {
        return this.weight;
    }
    
    public int GetAge()
    {
        return this.age;
    }

    public char GetGender()
    {
        return this.gender;
    }
}

class CrocodileService
{
    private List<object> animals = new List<object>();  
    
    public void CreateCrocodile(string Name, char Gender, int Age, int Weight, int Length)
    {
        Crocodile croc = new Crocodile(Name, Gender, Age, Weight, Length);
        animals.Add(croc);
    }

    public void Print_animals()
    {
        foreach (Crocodile animal in animals)
        {
            Console.WriteLine(animal.ToString());
        }
    }

    public void Find_the_most_length(int length)
    {
        List<object> lengthCrocodile = new List<object>();
        
        foreach (Crocodile animal in animals)
        {
            if (length < animal.GetLength())
            {
                lengthCrocodile.Add(animal);
            }
        }
        
        if (lengthCrocodile.Count > 0)
        {
            Console.WriteLine($"Крокодилы длинее: {length}");
            foreach (Crocodile croc in lengthCrocodile)
            {
               Console.WriteLine(croc.ToString());
            }
        }
        else
        {
            Console.WriteLine("Таких крокодилов нет");
        }
    }

    public void oldCrocodile()
    {
        int ageCroc = 0;
        Crocodile Croc = new Crocodile("",'M',0,0,0);

        foreach (Crocodile animal in animals)
        {
            if (animal.GetAge() > ageCroc)
            {
                ageCroc = animal.GetAge();
                Croc = animal;
            }
        }

        if (Croc.GetLength() > 0)
        {
            Console.WriteLine("Самый старый крокодил:");
            Console.WriteLine(Croc.ToString());
        }
        else
        {
            Console.WriteLine("Крокодилов нет");
        }

    }
    
    public void MaxWeinghtCrocodile()
    {
        int WeightCroc = 0;
        Crocodile Croc = new Crocodile("",'M',0,0,0);

        foreach (Crocodile animal in animals)
        {
            if (animal.GetWeight() > WeightCroc)
            {
                WeightCroc = animal.GetWeight();
                Croc = animal;
            }
        }

        if (Croc.GetLength() > 0)
        {
            Console.WriteLine("Самый тяжелый крокодил:");
            Console.WriteLine(Croc.ToString());
        }
        else
        {
            Console.WriteLine("Крокодилов нет");
        }

    }
}

    static void Main()
    {
        CrocodileService service new CrocodileService();
        bool finish = true;
        int input = new();
        int age, length, weight;
        char gender;
        string name;
        
        while (finish)
        {
            Console.Clear();
            Console.WriteLine("""
                              Выберите действие
                              1.Добавить крокодила
                              2.Вывести всех крокодилов
                              3.Вывести всех крокодилов длинее чего-то
                              4.Вывести самого старого крокодила
                              5.Вывести самого тяжелого крокодила
                              6.Закончить работу
                              """);
            
            while (true)
            {
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Не верный ввод необходимо ввести число");
                }
            }

            switch (input)
            {
                case 1:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("Введите имя крокодила:");
                        name = Console.ReadLine();
                        if (name.Length > 0)
                        {
                            break;
                        }
                        Console.WriteLine("Данные введены не верно");
                    }
                    
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Введите пол крокодила(М/Ж):");
                            gender = Convert.ToChar(Console.ReadLine());
                            if (gender != '\n' & gender != ' ' & gender == 'М' | gender == 'Ж')
                            {
                                break;
                            }
                            Console.WriteLine("Данные введены не верно");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Данные введены не верно");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Введите возрост крокодила:");
                        try
                        {
                            age = Convert.ToInt32(Console.ReadLine());
                            if (age > 0)
                            {
                                break;
                            }
                            Console.WriteLine("Данные введены не верно");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Возрост может быть только целым числом и больше нуля");
                        }
                        
                    }
                    while (true)
                    {
                        Console.WriteLine("Введите длину крокодила:");
                        try
                        {
                            length = Convert.ToInt32(Console.ReadLine());
                            if (length > 0)
                            {
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Длина может быть только целым числом и больше нуля");
                        }
                    }
                    while (true)
                    {
                        Console.WriteLine("Введите вес крокодила:");
                        try
                        {
                            weight = Convert.ToInt32(Console.ReadLine());
                            if (weight > 0)
                            {
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Возрост может быть только числом и больше нуля");
                        }
                    }
                    service.CreateCrocodile(name,gender, age, weight, length);
                    break;
                
                case 2:
                    service.Print_animals();
                    Console.ReadKey();
                    break;
                
                case 3:
                    while (true)
                    {
                        Console.WriteLine("Введите длину больше которой должены быть крокодилы:");
                        try
                        {
                            length = Convert.ToInt32(Console.ReadLine());
                            if(length >= 0)
                                break;
                            Console.WriteLine("Число не может быть отрицательным");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Длина может быть только целым числом");
                        }
                    }
                    service.Find_the_most_length(length);
                    Console.ReadKey();
                    break;
                
                case 4:
                    service.oldCrocodile();
                    Console.ReadKey();
                    break;
                
                case 5:
                    service.MaxWeinghtCrocodile();
                    Console.ReadKey();
                    break;
                
                case 6:
                    finish = false;
                    break;
            }
        }
    }
}
