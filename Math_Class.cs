using System;

namespace Math_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 Grades separated by new lines: ");
            Console.Write("Grade #no1: "); double _grade_01 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grade #no2: "); double _grade_02 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grade #no3: "); double _grade_03 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grade #no4: "); double _grade_04 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Grade #no5: "); double _grade_05 = Convert.ToDouble(Console.ReadLine());
            double total = _grade_01 + _grade_02 + _grade_03 + _grade_04 + _grade_05;
            double ftotal = total / 5;
            Console.WriteLine("The average is "+ total/5 + " and round off to "+Math.Round(ftotal));
        }
    }
}
