using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApi
{
    [Serializable]
   public class Customer
    {
       public int CustomerId { get; set; } 
       public String Name { get; set; }
       public int Age { get; set; }
       public String Sex { get; set; }

        [ForeignKey("OrderNo")]
        public int OrderId { get; set; }
        public Customer()
        {
        }

        public Customer(int customerId, string name, int age, String sex)
        {
            CustomerId = customerId;
            Name = name;
            Age = age;
            Sex = sex;
        }

        public Customer(string name, int age, String sex)
        {           
            this.Name = name;
            this.Age = age;
            this.Sex = sex;
        }


        public override String ToString()
        {
            return $"{CustomerId}号顾客{Name} 性别{Sex} 年龄{Age}";
        }

        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                   CustomerId == customer.CustomerId &&
                   Name == customer.Name &&
                   Age == customer.Age &&
                   Sex == customer.Sex;
        }

        public override int GetHashCode()
        {
            int hashCode = -663392123;
            hashCode = hashCode * -1521134295 + CustomerId.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + Sex.GetHashCode();
            return hashCode;
        }
    }
}
