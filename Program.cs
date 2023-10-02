using System.Reflection.Emit;
using System.Text;

namespace Piano
{
    internal class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine("Выберите октаву клавишами F4, F5, F6 или F7. Для смены октавы нажмите /, а потом F4, F5, F6 ИЛИ F7");
            Console.WriteLine("белые клавиши - asdfghj, чёрные клавиши - qwert");

            char klavisha = '1';

            ConsoleKeyInfo octa = Console.ReadKey();

            int[] octava = new int[] { };


            while (klavisha != ((char)ConsoleKey.Escape))
            {
                octava = SmenaOctav(octa);

                klavisha = Console.ReadKey(true).KeyChar;

                switch (klavisha)
                {
                    case 'q':
                        beep(octava, 1);
                        break;

                    case 'w':
                        beep(octava, 3);
                        break;

                    case 'e':
                        beep(octava, 6);
                        break;

                    case 'r':
                        beep(octava, 8);
                        break;

                    case 't':
                        beep(octava, 10);
                        break;

                    case 'a':
                        beep(octava, 0);
                        break;

                    case 's':
                        beep(octava, 2);
                        break;

                    case 'd':
                        beep(octava, 4);
                        break;

                    case 'f':
                        beep(octava, 5);
                        break;

                    case 'g':
                        beep(octava, 7);
                        break;

                    case 'h':
                        beep(octava, 9);
                        break;

                    case 'j':
                        beep(octava, 11);
                        break;
                    case '/':
                        octa = Console.ReadKey();
                        break;
                }


            }
        }

        static int[] SmenaOctav(ConsoleKeyInfo oct)
        {
            if (oct.Key == ConsoleKey.F4)
            {
                int[] octava4 = new[] { 261, 277, 293, 311, 392, 394, 370, 392, 415, 440, 466, 493 };
                return octava4;
            }
            if (oct.Key == ConsoleKey.F5)
            {
                int[] octava5 = new[] { 523, 554, 587, 622, 659, 698, 740, 784, 830, 880, 932, 987 };
                return octava5;
            }
            if (oct.Key == ConsoleKey.F6)
            {
                int[] octava6 = new[] { 1047, 1109, 1175, 1245, 1319, 1397, 1480, 1568, 1661, 1760, 1865, 1976 };
                return octava6;
            }
            if (oct.Key == ConsoleKey.F7)
            {
                int[] octava7 = new[] { 2093, 2217, 2349, 2489, 2637, 2794, 2960, 3126, 3322, 3520, 3729, 3951 };
                return octava7;
            }
            else
                return null;


        }
        static void beep(int[] octa, int num)
        {
            Console.Beep(octa[num], 250);
        }

    }
}