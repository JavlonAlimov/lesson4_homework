namespace lesson4_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber, maxAnswer = 0;
            int repetition = 1, maxRepetition = 0;
            Console.WriteLine("Eng kop takrorlangan sonni topish oyini");
            Console.Write("Son kiriting :");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine();
            while (inputNumber != 0) 
            {
                maxNumber = inputNumber;
                Console.Write("Son kiriting :");
                inputNumber = int.Parse(Console.ReadLine());

                if (inputNumber == maxNumber)
                {
                    repetition++;
                }
                else
                {
                    if (repetition >= maxRepetition)
                    {
                        maxRepetition = repetition;
                        maxAnswer = maxNumber;
                    }
                    maxNumber = inputNumber;
                    repetition = 1;
                }
            }
            Console.WriteLine($"Kiritilgan sonlar ichida eng ko'p takrorlangan son " +
                $" {maxAnswer} soni va u {maxRepetition} marta takrorlandi!");
            
        }
    }
}