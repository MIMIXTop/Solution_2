namespace Crocodile
{
    class Crocodile
    {
        private string Name;
        private char Gender;
        private int Age;
        private int Length;
        private int Weight;

        public string name
        {
            get { return Name; }
            set { Name = value; }
        }

        public char gender
        {
            get { return Gender; }
            set { Gender = value; }
        }

        public int age
        {
            get { return Age; }
            set { Age = value; }
        }

        public int length
        {
            get { return Length; }
            set { Length = value; }
        }

        public int weight
        {
            get { return Weight; }
            set { Weight = value; }
        }

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
            return "Имя:" + this.Name + " Пол:" + this.Gender + " Возрост:" + this.Age + " Вес:" + this.Weight +
                   " Длина:" + this.Length + "";
        }
    }

    class CrocodileService
    {
        private List<object> animals = new();

        public void CreateCrocodile(string Name, char Gender, int Age, int Weight, int Length)
        {
            Crocodile croc = new Crocodile(Name, Gender, Age, Weight, Length);
            animals.Add(croc);
        }

        public void Print_animals()
        {
            Console.WriteLine("Список крокодилов:");
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
                if (length < animal.length)
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
            Crocodile Croc = new Crocodile("", 'M', 0, 0, 0);

            foreach (Crocodile animal in animals)
            {
                if (animal.age > ageCroc)
                {
                    ageCroc = animal.age;
                    Croc = animal;
                }
            }

            if (Croc.length > 0)
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
            Crocodile Croc = new Crocodile("", 'M', 0, 0, 0);

            
            foreach (Crocodile animal in animals)
            {
                if (animal.weight > WeightCroc)
                {
                    WeightCroc = animal.weight;
                    Croc = animal;
                }
            }

            if (Croc.length > 0)
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
}