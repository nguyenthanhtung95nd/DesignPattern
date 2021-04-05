using CreationalDesignPattern.AbstractFactory;
using CreationalDesignPattern.FactoryMethod;
using CreationalDesignPattern.FluentInterface;
using CreationalDesignPattern.Singleton;
using System;
using CreationalDesignPattern.Builder;
using CreationalDesignPattern.Prototype;

namespace DesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // TestSingletonPattern();
            // TestFactoryMethod();
            // TestAbstractFactory();
            // TestFluentInterface();
            // TestBuiderPattern();

            TestPrototypePattern();

            Console.WriteLine("Hello World!");
        }

        private static void TestPrototypePattern()
        {
            Person person1 = new Person();
            person1.Id = 1;
            person1.Name = "Tung";

            Person person2 = person1.GetClone();
            person2.Name = "Bach";

            Console.WriteLine("Person 1: ");
            Console.WriteLine("Name: " + person1.Id + ", Name: " + person1.Name);
            Console.WriteLine("Person 2: ");
            Console.WriteLine("Name: " + person2.Id + ", Name: " + person2.Name);

            Console.Read();
        }

        private static void TestBuiderPattern()
        {
            Report report;
            ReportDirector reportDirector = new ReportDirector();
            // Construct and display Reports
            PDFReport pdfReport = new PDFReport();
            report = reportDirector.MakeReport(pdfReport);
            report.DisplayReport();
            Console.WriteLine("-------------------");
            ExcelReport excelReport = new ExcelReport();
            report = reportDirector.MakeReport(excelReport);
            report.DisplayReport();

            Console.ReadKey();
        }

        private static void TestFluentInterface()
        {
            Student obj = new Student();

            obj.BuildListCourse("Math")
                .Born("10/10/1995")
                .WorkingOn("IT")
                .StaysAt("VietNam");

            Console.Read();
        }

        private static void TestAbstractFactory()
        {
            IAnimal animal = null;
            AnimalFactory animalFactory = null;
            string SpeakSound = null;
            // Create the Sea Factory object by passing the factory type as Sea
            animalFactory = AnimalFactory.CreateAnimalFactory("Sea");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Octopus Animal object by passing the animal type as Octopus
            animal = animalFactory.GetAnimal("Octopus");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            SpeakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + SpeakSound);
            Console.WriteLine();
            Console.WriteLine("--------------------------");

            // Create Land Factory object by passing the factory type as Land
            animalFactory = AnimalFactory.CreateAnimalFactory("Land");
            Console.WriteLine("Animal Factory type : " + animalFactory.GetType().Name);
            Console.WriteLine();

            // Get Lion Animal object by passing the animal type as Lion
            animal = animalFactory.GetAnimal("Lion");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            SpeakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + SpeakSound);
            Console.WriteLine();

            // Get Cat Animal object by passing the animal type as Cat
            animal = animalFactory.GetAnimal("Cat");
            Console.WriteLine("Animal Type : " + animal.GetType().Name);
            SpeakSound = animal.Speak();
            Console.WriteLine(animal.GetType().Name + " Speak : " + SpeakSound);
            Console.Read();
        }

        private static void TestFactoryMethod()
        {
            ICreditCard creditCard = new PlatinumFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.WriteLine("--------------");
            creditCard = new MoneyBackFactory().CreateProduct();
            if (creditCard != null)
            {
                Console.WriteLine("Card Type : " + creditCard.GetCardType());
                Console.WriteLine("Credit Limit : " + creditCard.GetCreditLimit());
                Console.WriteLine("Annual Charge :" + creditCard.GetAnnualCharge());
            }
            else
            {
                Console.Write("Invalid Card Type");
            }

            Console.ReadLine();
        }

        private static void TestSingletonPattern()
        {
            var instance1 = Singleton.Instance();
            var instance2 = Singleton.Instance();
            if (instance1.Equals(instance2))
                Console.WriteLine("Instance 1 and instance 2 are the same instance of Singleton.");

            instance1.PrintDetails("Message 1");
            instance2.PrintDetails("Message 2");

            Console.ReadKey();
        }
    }
}