using System.Runtime;

namespace lesson4_homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int maxNumber, maxAnswer = 0;
            //int repetition = 1, maxRepetition = 0;
            //Console.WriteLine("Eng kop takrorlangan sonni topish oyini");
            //Console.Write("Son kiriting :");
            //int inputNumber = int.Parse(Console.ReadLine());
            //Console.WriteLine();
            //while (inputNumber != 0) 
            //{
            //    maxNumber = inputNumber;
            //    Console.Write("Son kiriting :");
            //    inputNumber = int.Parse(Console.ReadLine());

            //    if (inputNumber == maxNumber)
            //    {
            //        repetition++;
            //    }
            //    else
            //    {
            //        if (repetition >= maxRepetition)
            //        {
            //            maxRepetition = repetition;
            //            maxAnswer = maxNumber;
            //        }
            //        maxNumber = inputNumber;
            //        repetition = 1;
            //    }
            //}
            //Console.WriteLine($"Kiritilgan sonlar ichida eng ko'p takrorlangan son " +
            //    $" {maxAnswer} soni va u {maxRepetition} marta takrorlandi!");


            Console.Write("Son kiriting(1 000 000) :");
            int son = int.Parse(Console.ReadLine());
            int birlar = son % 10, onlar = son / 10 % 10, yuzlar = son / 100 % 10,
                minglar = son / 1000 % 10, onminglar = son / 10000 % 10, yuzminglar = son / 100000 % 10;
            switch (yuzminglar)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("Bir yuz ");
                    break;
                case 2:
                    Console.Write("Ikki yuz ");
                    break;
                case 3:
                    Console.Write("Uch yuz ");
                    break;
                case 4:
                    Console.Write("To'rt yuz ");
                    break;
                case 5:
                    Console.Write("Besh yuz ");
                    break;
                case 6:
                    Console.Write("Olti yuz ");
                    break;
                case 7:
                    Console.Write("Yetti yuz ");
                    break;
                case 8:
                    Console.Write("Sakkiz yuz ");
                    break;
                case 9:
                    Console.Write("To'qqiz yuz ");
                    break;
            }
            switch (onminglar)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("o'n ");
                    break;
                case 2:
                    Console.Write("yigirma ");
                    break;
                case 3:
                    Console.Write("o'ttiz ");
                    break;
                case 4:
                    Console.Write("qirq ");
                    break;
                case 5:
                    Console.Write("ellik ");
                    break;
                case 6:
                    Console.Write("oltmish ");
                    break;
                case 7:
                    Console.Write("yetmish ");
                    break;
                case 8:
                    Console.Write("sakson ");
                    break;
                case 9:
                    Console.Write("to'qson ");
                    break;
            }
            switch (minglar)
            {
                case 0:
                    if(onminglar != 0 || yuzminglar != 0)
                    Console.Write("ming ");
                    else
                    {
                        Console.Write("");
                    }
                    break;
                case 1:
                    Console.Write("bir ming ");
                    break;
                case 2:
                    Console.Write("ikki ming ");
                    break;
                case 3:
                    Console.Write("uch ming ");
                    break;
                case 4:
                    Console.Write("to'rt ming ");
                    break;
                case 5:
                    Console.Write("besh ming ");
                    break;
                case 6:
                    Console.Write("olti ming ");
                    break;
                case 7:
                    Console.Write("yetti ming ");
                    break;
                case 8:
                    Console.Write("sakkiz ming ");
                    break;
                case 9:
                    Console.Write("to'qqiz ming ");
                    break;
            }
            switch (yuzlar)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("bir yuz ");
                    break;
                case 2:
                    Console.Write("ikki yuz ");
                    break;
                case 3:
                    Console.Write("uch yuz ");
                    break;
                case 4:
                    Console.Write("to'rt yuz ");
                    break;
                case 5:
                    Console.Write("besh yuz ");
                    break;
                case 6:
                    Console.Write("olti yuz ");
                    break;
                case 7:
                    Console.Write("yetti yuz ");
                    break;
                case 8:
                    Console.Write("sakkiz yuz ");
                    break;
                case 9:
                    Console.Write("to'qqiz yuz ");
                    break;
            }
            switch (onlar)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("o'n ");
                    break;
                case 2:
                    Console.Write("yigirma ");
                    break;
                case 3:
                    Console.Write("o'ttiz ");
                    break;
                case 4:
                    Console.Write("qirq ");
                    break;
                case 5:
                    Console.Write("ellik ");
                    break;
                case 6:
                    Console.Write("oltmish ");
                    break;
                case 7:
                    Console.Write("yetmish ");
                    break;
                case 8:
                    Console.Write("sakson ");
                    break;
                case 9:
                    Console.Write("to'qson ");
                    break;
            }
            switch (birlar)
            {
                case 0:
                    Console.Write("");
                    break;
                case 1:
                    Console.Write("bir");
                    break;
                case 2:
                    Console.Write("ikki");
                    break;
                case 3:
                    Console.Write("uch");
                    break;
                case 4:
                    Console.Write("to'rt");
                    break;
                case 5:
                    Console.Write("besh");
                    break;
                case 6:
                    Console.Write("olti");
                    break;
                case 7:
                    Console.Write("yetti");
                    break;
                case 8:
                    Console.Write("sakkiz");
                    break;
                case 9:
                    Console.Write("to'qqiz");
                    break;
            }
        }
    }
}