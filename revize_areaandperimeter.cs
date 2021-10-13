using System;
class Program
{

    static void Main(string[] args)
    {
        bool working = true;
        double answer = 0;
        do
        {
            double num1;
            double num2;
            int num3;
            string operand;

            Console.Write("Please enter an operand 1.Addition,2.Subtraction,3.Multiplication,4.Division,5.Modulus, 0.Exit:\n"); //1.Addition,2.Subtraction,3.Multiplication,4.Division,5.Modulus, 0.Exit
            operand = Console.ReadLine();
            while (!(int.TryParse(operand, out num3) && num3 > -1 && num3 < 6))
            {

                Console.Write("Please enter an operand 1.Addition,2.Subtraction,3.Multiplication,4.Division,5.Modulus, 0.Exit:\n"); //1.Addition,2.Subtraction,3.Multiplication,4.Division,5.Modulus, 0.Exit
                operand = Console.ReadLine();
            }

            if (num3 == 0)
            {
                Console.WriteLine("İyi günler.");
                Environment.Exit(0);
            }

            Console.Write("Please enter the first integer: ");
            string kosul1 = Console.ReadLine();
            while (!double.TryParse(kosul1, out num1))
            {
                Console.WriteLine("Please enter integer: ");
                kosul1 = Console.ReadLine();
            }

            Console.Write("Please enter the second integer: ");
            string kosul2 = Console.ReadLine();
            while (!double.TryParse(kosul2, out num2))
            {
                Console.WriteLine("Please enter integer: ");
                kosul2 = Console.ReadLine();
            }

            switch (operand)
            {

                case "1":
                    answer = num1 + num2;
                    Console.WriteLine(num1.ToString() + "+" + num2.ToString() + " = " + answer.ToString());
                    break;

                case "2":
                    answer = num1 - num2;
                    Console.WriteLine(num1.ToString() + "-" + num2.ToString() + " = " + answer.ToString());
                    break;

                case "3":
                    answer = num1 * num2;
                    Console.WriteLine(num1.ToString() + "*" + num2.ToString() + " = " + answer.ToString());
                    break;

                case "4":
                    if (num2 == 0)
                    {
                        string kosul3 = Console.ReadLine();
                        while (!double.TryParse(kosul3, out num2) || num2 == 0)
                        {
                            Console.WriteLine("sıfırdan farklı gir: ");
                            kosul3 = Console.ReadLine();
                        }
                    }
                    answer = num1 / num2;
                    Console.WriteLine(num1.ToString() + "/" + num2.ToString() + " = " + answer.ToString());
                    break;

                case "5":
                    if (num2 == 0 && (!(num2%1 == 0)))
                    {
                        int num4;
                        string kosul4 = Console.ReadLine();
                        while (!int.TryParse(kosul4, out num4) || num4 == 0)
                        {
                            Console.WriteLine("Sıfırdan farklı gir: ");
                            kosul4 = Console.ReadLine();
                        }
                    }
                    answer = num1 % num2;
                    Console.WriteLine(num1.ToString() + "%" + num2.ToString() + "=" + answer.ToString());
                    break;

                case "0":
                    working = false;
                    break;

                default:
                    answer = 0;
                    break;
            }

        }
        while (working);





    }

}