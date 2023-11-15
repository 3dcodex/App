// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel;
namespace MyFirstCalculator
{
    class MyFirstCalculator
    {
        private double data1;
        private double data2;
        private double add;
        private double sub;
        private double div;
        private double mult;
        private double mod;

            public void EnterData(double data1new, double data2new)
            {
                data1 = data1new;
                data2 = data2new;
            }

            public double Addition()
            {
                return add = data1 + data2;
            }
            public double Subtration()
            {
                return sub = data1 - data2;
            }
            public double Multiplicatin()
            {
                return  mult = data1 * data2;
            }
            public double Division()
            {
                return div = data1 / data2;
            }
            public double Modulus()
            {
                return mod = mult / 2;
            }

            public void ComputeAddition()
            {
                Console.WriteLine("results {0}", Addition());
            }

            public void ComputeSubtration()
            {
                Console.WriteLine("results {0}", Subtration());
            }

            public void ComputeMultiplicatin()
            {
                Console.WriteLine("results {0}", Multiplicatin());   
            }

            public void ComputeDivision()
            {
                Console.WriteLine("results {0}", Division());    
            }

             public void ComputeModulus()
            {
                Console.WriteLine("results {0}", Modulus());
            }

    }
/*this is here for you*/
/*Test Change*/
class Calculator
{
    static void Main(string[] args)
    {

            MyFirstCalculator calculate = new MyFirstCalculator();
        {
            Console.WriteLine("\nSelect an operation:");
            Console.WriteLine(">> Addition (+)");
            Console.WriteLine(">> Subtraction (-)");
            Console.WriteLine(">> Multiplication (*)");
            Console.WriteLine(">> Division (/)");

            Console.Write("\nEnter your choice >> ");
            string choice = Convert.ToString(Console.ReadLine());
            Console.WriteLine("enter the first number: ");
            double data1new = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("enter the second number:");
            double data2new = Convert.ToDouble(Console.ReadLine());
            
            switch (choice){
                case "Addition":
                    calculate.EnterData(data1new, data2new);
                    calculate.ComputeAddition();
                    break;
                case "Subtraction":
                    calculate.EnterData(data1new, data2new);
                    calculate.ComputeSubtration();
                    break;
                case "Multiplication":
                    calculate.EnterData(data1new, data2new);
                    calculate.ComputeMultiplicatin();
                    break;
                case "Division":
                    calculate.EnterData(data1new, data2new);
                    calculate.ComputeDivision();
                    break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }


            }
        }


    }
}


