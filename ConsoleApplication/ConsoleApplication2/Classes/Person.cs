using System;

namespace ConsoleApp1
{
    [AgeValidation(18)]
    partial class Person : IDisposable
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
