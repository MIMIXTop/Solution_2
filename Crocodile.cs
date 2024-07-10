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
}