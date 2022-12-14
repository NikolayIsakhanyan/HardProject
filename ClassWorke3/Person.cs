using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWorke3
{
  public class Person
    {
        public string name;
        public int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public Person()
        {

        }
    }
    public struct Car
    {
        public CarBrand c=CarBrand.Lada;
        public int Year = 0;
        public Car(CarBrand cb, int y)
        {
            c= cb;
            Year = y;
        }
        public Car()
        {

        }
    }

    public enum CarBrand
    {
        BMW,
        Audi,
        Mercedes,
        Opel,
        Lada,
    }
}
