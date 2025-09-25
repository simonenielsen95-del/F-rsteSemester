using Microsoft.VisualBasic;

namespace Pro_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool notExit = true;
            while (notExit)
            {
                Console.Clear(); // nået til øvelse 2.10
                Console.WriteLine("from this menue you can print out all the chars from a string, with all the index:");
                Console.WriteLine("type 1 for use with while:");
                Console.WriteLine("type 2 for use with do-while:");
                Console.WriteLine("type 3 for divition with reminder");
                Console.WriteLine("type 4 for printing every other char from a texst");
                Console.WriteLine("type 5 for finding int in a string");
                Console.WriteLine("type 6 for finding int and operators like + and - in a string");
                Console.WriteLine("type 8 for calculate a problem with int from 0-9 and with operators + and -");
                Console.WriteLine("type 9 for exit");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1": // write all char from texst
                        Console.WriteLine("insert text:");
                        string text = Console.ReadLine();
                        int length = text.Length;
                        int i = 0;
                        while (length > i)
                        {
                            Console.WriteLine($"{i}: {text[i]}");
                            i++;

                        }

                        Console.WriteLine("Press Enter to return to the main menu");
                        Console.ReadLine();
                        //Main(args);
                        break;

                    case "2": // write all char from texst
                        Console.WriteLine("insert texst:");
                        string text1 = Console.ReadLine();
                        int length1 = text1.Length;
                        int i1 = 0;
                        do
                        {
                            Console.WriteLine($"{i1}: {text1[i1]}");
                            i1++;
                        }
                        while (length1 > i1);
                        Console.ReadLine();
                        break;

                    case "3":// divide two int and print the number and the reminder.
                        Console.WriteLine("a/b");
                        Console.WriteLine("insert numirator a:");
                        int a = int.Parse(Console.ReadLine());
                        Console.WriteLine("insert denominator b");
                        int b = int.Parse(Console.ReadLine());
                        int divition = a / b;
                        int reminder = a % b;

                        Console.WriteLine($"the divition is:{divition}, the remainder is: {reminder}");
                        Console.ReadLine();

                        break;

                    case "4"://print every other char from txt. 

                        Console.WriteLine("insert texst:");
                        string text2 = Console.ReadLine();
                        int length2 = text2.Length;
                        int i2 = 0;
                        while (length2 > i2)
                        {
                            if (i2 % 2 == 0)
                            {
                                Console.WriteLine($"{i2}: {text2[i2]}");
                                i2++;
                            }
                            else
                            {
                                i2++;
                            }
                        }
                        Console.ReadLine();
                        break;

                    case "5":

                        Console.WriteLine("insert texst:");
                        string text3 = Console.ReadLine();
                        int length3 = text3.Length;
                        int i3 = 0;

                        while (length3 > i3)
                        {
                            int temp;
                            if (int.TryParse(text3[i3].ToString(), out temp))
                            {

                                Console.WriteLine(temp);
                            }
                            i3++;
                        }

                        Console.ReadLine();

                        break;


                    case "6":

                        Console.WriteLine("insert texst:");
                        string text4 = Console.ReadLine();
                        int length4 = text4.Length;
                        int i4 = 0;

                        while (length4 > i4)
                        {
                            int temp;
                            string temp2;
                            if (int.TryParse(text4[i4].ToString(), out temp))
                            {

                                Console.WriteLine(temp);

                            }
                            else if (text4[i4] == '+' || text4[i4] == '-')
                            {
                                Console.WriteLine(text4[i4]);
                            }
                            i4++;
                        }

                        Console.ReadLine();
                        break;

                    case "7":

                        Console.WriteLine("insert texst:");
                        string text5 = Console.ReadLine();
                        int length5 = text5.Length;
                        int i5 = 0;

                        int final = 0;
                        int Result = 0;
                        int x = 0;

                        while (length5 > i5)
                        { 
                            int temp;

                            if (int.TryParse(text5[i5].ToString(), out temp))
                            {
                                x = temp;                               
                            }
                            else if (text5[i5] == '+' || text5[i5] == '-')
                            {
                                switch (text5[i5])
                                {
                                    case '+':
                                        Result = +x;
                                        break;
                                }
                            }
                            final = Result + x;
                            i5++;
                        }
                        Console.WriteLine(final);
                        Console.ReadLine();
                        break;

                    case "8":

                        Console.WriteLine("insert texst:");
                        string text6 = Console.ReadLine();
                        int length6 = text6.Length;
                        int i6 = 0;
                        int x1 = int.Parse(text6[i6].ToString());
                        i6++;
                    
                        while (length6 > i6)
                        {
                            int temp;

                            if (text6[i6]== '+')
                            {
                                x1 += int.Parse(text6[i6+1].ToString());
                            }
                            else if (text6[i6] == '-')
                            {
                                x1 -= int.Parse(text6[i6 + 1].ToString());
                            }
                            i6 += 2;
                        }
                        Console.WriteLine(x1);
                        Console.ReadLine();
                        break;

                    case "9":
                        notExit = false;
                        break;


                    default:
                        Console.WriteLine("invalid input. please try again.");
                        Console.ReadLine();

                        break;

                }
            }
        }

    }
}
