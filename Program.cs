using System;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Angle angle;
            do
            {
                Console.WriteLine("Введите данные");
                int gradus_ = Convert.ToInt32(Console.ReadLine());
                int min_ = Convert.ToInt32(Console.ReadLine());
                int sec_ = Convert.ToInt32(Console.ReadLine());

                angle = new Angle(gradus_, min_, sec_);
            }
            while (angle.isCorrect == false);

            double radians = angle.ToRadians();
            Console.WriteLine(radians);
            Console.ReadKey();
        }

    }
}
