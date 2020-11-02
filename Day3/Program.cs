using System;
using System.Drawing;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //ForEachLoop();
            //Padiki(4, 5, 10);
            //PadikiFancy(4, 15, 10);
            Germany(4, 15, 10);
            Switzerland(4, 17, 9);
            Israel(3, 23, 21);
            //MethodWithParams(5, "Hello World");
            //Scope();
        }

        static void ForLoop()
        {
            for (int j = 2; j <= 10; j++)
            {
                for (int i = 1; i <= 10; i += 2)
                {
                    Console.Write($"{i} * {j} = {i * j} \t");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= 34; i++)
            {
                if (i == 34)
                {
                    Console.WriteLine("I'm uncle Chernomor");
                }
                else
                {
                    Console.WriteLine($"I'm Bogatyr #{i}");
                }
            }
        }

        static void ForEachLoop()
        {
            string[] stringArray = new string[5];
            stringArray[0] = "Porter";
            stringArray[1] = "Pilsner";
            stringArray[2] = "Wheat Beer";
            stringArray[3] = "Lager";
            stringArray[4] = "IPA";

            foreach (string beer in stringArray)
            {
                Console.Write(beer);
                if (beer == "Wheat Beer")
                {
                    Console.Write(" Fu bliat");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i == stringArray.Length - 1)
                {
                    Console.Write("And the last on out table ");
                }
                Console.WriteLine($"Beer #{i} is {stringArray[i]}");
            }
        }

        // Summary:
        //     There's a house with 5 padikis and 9 floors. Each floor has 3 flats
        //     We need to tell everyone which ligth to turn on (red or white)
        //     To show correct flag
        //     desired output: "Flat 1 - turn on white"...
        static void Padiki(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floors doesn't be lit");

            }
            else
            {
                Console.WriteLine("aLL flats work");
            }
            int flatnumber = 1;
            for (int padik = 1; padik <= padikiCount; padik++)
            {
                for (int floor = 1; floor <= floorCount; floor++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <= ostatok)
                        {
                            Console.WriteLine($"Flat{flatnumber} is off");
                        }
                        else
                        {
                            if (floor >= ((floorCount - ostatok) / 3 * 2 + ostatok - ((floorCount - ostatok) / 3 - 1)) && (floor <= ((floorCount - ostatok) / 3 * 2 + ostatok)))
                            {
                                Console.WriteLine($"Flat{flatnumber} is red");
                            }
                            else
                            {
                                Console.WriteLine($"Flat{flatnumber} is white");
                            }
                        }
                        flatnumber++;

                    }

                }
            }
        }

        static void Germany(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            int ger = (floorCount - ostatok) / 3;
            int sc = 1;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floor(s) is(are) not lit and {ger}");
            }
            else
            {
                Console.WriteLine($"aLL flats work {ger}");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <= ostatok)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {

                            if (floor <= ger + ostatok)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                                Console.Write("*");
                            }
                            if ((ger + ostatok < floor) && (floor <= (ger * 2 + ostatok)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                            if ((ger * 2 + ostatok) < floor)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write("*");
                            }
                        }
                        flatnumber++;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
            int kvartirayellow = 1;
            int kvartirasecondyellow = ger * flatPerFloor;
            int gavno = floorCount * flatPerFloor;
            for (int i = 0; i < padikiCount; i++)
            {
                if (i != 0)
                {
                    kvartirayellow = kvartirayellow + gavno; kvartirasecondyellow = kvartirasecondyellow + gavno;
                    Console.Write($"Квартира {kvartirayellow} по {kvartirasecondyellow} цвет желтый \n");
                }
                else { Console.Write($"Квартира {kvartirayellow} по {kvartirasecondyellow} цвет желтый \n"); }
            }
            Console.ForegroundColor = ConsoleColor.Red;
            int kvartirared = ger * flatPerFloor + 1;
            int kvartirasecendred = (ger * flatPerFloor) * 2;
            for (int i = 0; i < padikiCount; i++)
            {
                if (i != 0)
                {
                    kvartirared = kvartirared + gavno; kvartirasecendred = kvartirasecendred + gavno;
                    Console.Write($"Квартира {kvartirared} по {kvartirasecendred} цвет красный \n");
                }
                else { Console.Write($"Квартира {kvartirared} по {kvartirasecendred} цвет красный \n"); }
            }
            Console.ForegroundColor = ConsoleColor.DarkGray;
            int kvartirablack = (ger * flatPerFloor) * 2 + 1;
            int kvartirasecendblack = (ger * flatPerFloor) * 3;
            for (int i = 0; i < padikiCount; i++)
            {
                if (i != 0)
                {
                    kvartirablack = kvartirablack + gavno; kvartirasecendblack = kvartirasecendblack + gavno;
                    Console.Write($"Квартира {kvartirablack} по {kvartirasecendblack} цвет черный \n");
                }
                else { Console.Write($"Квартира {kvartirablack} по {kvartirasecendblack} цвет черны \n"); }
            }
        }

        static void Israel(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 21;
            int ostpadik = padikiCount % 13;
            int coef1 = floorCount / 8;
            int coef2 = padikiCount / 13;
            int coeficient = 1;
            if (coef1 == coef2)
            {
                coeficient = coef1;
            }
            int ger = (floorCount - ostatok) / 3;
            int sc = 1;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {coeficient} floor(s) is(are) not lit and {ger}");
            }
            else
            {
                Console.WriteLine($"aLL flats work {ostatok}");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floorCount < 21 || padikiCount < 23)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {
                            if (floor <= ostatok)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;

                            }

                            if (floor >= 1 && floor <= 2)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (floor >= 3 && floor <= 6)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor >= 6 && floor <= 7)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (floor == 7 && padik == 12)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 8 && (padik == 11 || padik == 13))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 9 && (padik >= 6 && padik < 19))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 10 && (padik == 7 || padik == 9 || padik == 15 || padik == 17))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 11 && (padik == 8 || padik == 16))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 12 && (padik == 7 || padik == 9 || padik == 15 || padik == 17))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 13 && (padik >= 6 && padik < 19))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 15 && padik == 12)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor == 14 && (padik == 11 || padik == 13))
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor >= 17 && floor <= 19)
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }

                            if (floor >= 20 && floor <= 21)
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            Console.Write("*");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        flatnumber++;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void Switzerland(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 8;
            int ostpadik = padikiCount % 13;
            int coef1 = floorCount / 8;
            int coef2 = padikiCount / 13;
            int coeficient = 1;
            if (coef1 == coef2)
            {
                coeficient = coef1;
            }
            int ger = (floorCount - ostatok) / 3;
            int sc = 1;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {coeficient} floor(s) is(are) not lit and {ger}");
            }
            else
            {
                Console.WriteLine($"aLL flats work {ostatok}");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floorCount < 8 || padikiCount < 13)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (floor <= ostatok)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            if (padik > padikiCount - ostpadik - 1)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            if (((floor >= 3) && (padik > 5)) && (padik <= 7 && floor < floorCount))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if ((floor >= 5 && padik > 2) && (padik < 11 && floor < 7))
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            Console.Write("*");
                        }
                        flatnumber++;
                    }
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void PadikiFancy(int flatPerFloor, int padikiCount, int floorCount)
        {
            Console.WriteLine($"We have a {floorCount}-storey house with {padikiCount} padiks and {flatPerFloor} flats per floor");
            Console.WriteLine($"flats In Houes:{flatPerFloor * floorCount * padikiCount}");
            int ostatok = floorCount % 3;
            if (ostatok != 0)
            {
                Console.WriteLine($"Your first {ostatok} floor(s) is(are) not lit");

            }
            else
            {
                Console.WriteLine("aLL flats work");
            }
            int flatnumber = 1;
            for (int floor = 1; floor <= floorCount; floor++)
            {
                for (int padik = 1; padik <= padikiCount; padik++)
                {
                    for (int flatFloor = 1; flatFloor <= flatPerFloor; flatFloor++)
                    {
                        if (floor <= ostatok)
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.Write("*");
                        }
                        else
                        {
                            if (floor >= ((floorCount - ostatok) / 3 * 2 + ostatok - ((floorCount - ostatok) / 3 - 1)) && (floor <= ((floorCount - ostatok) / 3 * 2 + ostatok)))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write("*");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Write("*");
                            }
                        }
                        flatnumber++;

                    }

                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }

        static void MethodWithParams(int number, string text)
        {
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(text);
            }
        }

        static void Scope()
        {
            int x = 5;
            if (x > 3)
            {
                int z = 12;
                Console.WriteLine(x);
                Console.WriteLine(z);
            }
            Console.WriteLine(x);
            // Console.WriteLine(z); will not build: out of scope
        }
    }
}

