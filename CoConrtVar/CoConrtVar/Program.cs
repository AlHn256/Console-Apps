using System;
using System.Collections.Generic;

namespace CoConrtVar
{
    class Program
    {
        class Account
        {
            public virtual void DoTransfer(int sum)
            {
                Console.WriteLine($"Клиент положил на счет {sum} долларов");
            }
        }
        class DepositAccount : Account
        {
            public override void DoTransfer(int sum)
            {
                Console.WriteLine($"Клиент положил на депозитный счет {sum} долларов");
            }
        }

        interface IBank<out T>
        {
            void CreateAccount(int sum);
        }

        class Bank<T> : IBank<T> where T : Account, new()
        {
            public void CreateAccount(int sum)
            {
                T acc = new T();  // создаем счет
                acc.DoTransfer(sum);
               // return acc;
            }
        }

        interface ITransaction<in T>
        {
            void DoOperation(T account, int sum);
        }

        class Transaction<T> : ITransaction<T> where T : Account, new()
        {
            public void DoOperation(T account, int sum)
            {
                account.DoTransfer(sum);
                T animal = new T();
            }
        }

        static void Main(string[] args)
        {
            // Ковариантные интерфейсы
            Console.WriteLine("Ковариантные интерфейсы");
            IBank<DepositAccount> depositBank = new Bank<DepositAccount>();
            depositBank.CreateAccount(35);

            //IBank<Account> ordinaryBank = new Bank<Account>();
            // или так
            IBank<Account> ordinaryBank = depositBank;
            ordinaryBank.CreateAccount(45);

            // Контравариантные интерфейсы
            Console.WriteLine("Контравариантные интерфейсы");
            ITransaction<Account> accTransaction = new Transaction<Account>();
            accTransaction.DoOperation(new Account(), 400);

            ITransaction<DepositAccount> depAccTransaction = new Transaction<Account>();
            depAccTransaction.DoOperation(new DepositAccount(), 450);

            //List<Animal> animalcat = new List<Cat>(); -- Err Пример инвариантности

            //Пример ковариантности интерфейса IEnumerable
            List<Animal> animal = new List<Animal>();
            List<Cat> cat = new List<Cat>();
            IEnumerable<Cat> cats = cat;
            IEnumerable<Animal> animals = cat;
            //Console.Read();

            Lada lada = new Lada();
            ICar<V8Engine> vEngin = lada;
            ICar<Engine> sfsd = lada;

            Ipushable<V8Engine> ipushable = new Stack<Engine>(); // без контравариантности не работает
        }


        public class Animal
        {

        }

        public class Cat : Animal
        {

        }

        abstract class Engine
        {

        }

        class V8Engine : Engine
        {

        }


        //interface ICar<T> where T:Engine
        //{
        //    T GetEngin();
        //}

        //Переделываем в ковариантный
        interface ICar<out T> where T : Engine
        //interface ICar<in T> where T : Engine //контр вариантный варивнт
        {
            T GetEngin();
            //void Set(T edeff); // Err Роботает только с контр вариантным варивнтом
            //T EnginProp { set; } // Err Роботает только с контр вариантным варивнтом
            //T Engine { get; }
        }


        class Lada : ICar<V8Engine>
        {
            public V8Engine GetEngin()
            {
                return new V8Engine();
            }
            //V8Engine ICar<V8Engine>.Engine { get; }
        }

        //interface Ipushable<T> where T : Engine
        //Переделываем в контрвариантный вариант
        interface Ipushable<in T> where T : Engine
        {
            void Push(T obj);
        }

        class Stack<T> : Ipushable<T> where T: Engine
        {
            void Ipushable<T>.Push(T obj) { }
        }
    }
}
