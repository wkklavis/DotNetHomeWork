using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    [Serializable]
   public  class Customer
    {

       public String Name { get; set; }
       public int Age { get; set; }
       public char Sex { get; set; }

        public Customer()
        {
        }

        public Customer(string name, int age, char sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   Name == customer.Name &&
                   Age == customer.Age &&
                   Sex == customer.Sex;
        }

        public override int GetHashCode()
        {
            int hashCode = 127581993;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Sex.GetHashCode();
            return hashCode;
        }

        public override String ToString()
        {
            return $"顾客{Name} 性别{Sex} 年龄{Age}";
        }

    }
}
