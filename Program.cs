
using System.Threading.Channels;
using Crocodile;

class Program
{
    static void Main()
    {   
        CrocodileService service = new CrocodileService();
        bool finish = true;
        int input;
        int age, length, weight;
        char gender;
        string name;
        
        //Хардкод крородилов
        service.CreateCrocodile("Витя",'М',10,100,43);
        service.CreateCrocodile("Дима",'М',15,73,36);
        service.CreateCrocodile("Катя",'Ж',9,58,24);
        service.CreateCrocodile("Оля",'Ж',18,64,41);
        service.CreateCrocodile("Коля",'М',12,66,49);
        service.CreateCrocodile("Саша",'Ж',11,54,47);
        
        while (finish)
        {
            Console.Clear();
            Console.WriteLine("""
                              1.Добавить крокодила
                              2.Вывести всех крокодилов
                              3.Вывести всех крокодилов длинее чего-то
                              4.Вывести самого старого крокодила
                              5.Вывести самого тяжелого крокодила
                              6.Закончить работу
                              Выберите действие:
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
                            Console.WriteLine("Данные введены не верно ");
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