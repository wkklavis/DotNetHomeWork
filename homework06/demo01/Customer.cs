using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo01
{
    class Customer
    {
        String name;
        int age;
        char sex;

        public Customer(string name, int age, char sex)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   name == customer.name &&
                   age == customer.age &&
                   sex == customer.sex;
        }

        public override int GetHashCode()
        {
            int hashCode = 127581993;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + age.GetHashCode();
            hashCode = hashCode * -1521134295 + sex.GetHashCode();
            return hashCode;
        }

        public override String ToString()
        {
            return $"顾客{name} 性别{sex} 年龄{age}";
        }

    }
}
