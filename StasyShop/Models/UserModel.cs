using System;
namespace StasyShop
{
    public class User
    {
        private string name;
        private int id;

        public User(string name)
        {
            this.name = name;
            this.id = IdGenerator();
        }

        private int IdGenerator()
        {
            return new Random().Next(1, 100);
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}
