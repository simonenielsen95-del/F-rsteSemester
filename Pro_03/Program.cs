namespace Pro_03
{
    internal class Program

    {
        static void Main(string[] args)
        {

            Console.WriteLine("from this menue you can calculate different problems:");
            Console.WriteLine("type 1 for rectangle area:");
            Console.WriteLine("type 2 for slope between two points:");
            Console.WriteLine("type 3 for calculate the length of texst:");
            Console.WriteLine("type 4 for substring:");
            Console.WriteLine("type 5 for looking for a char:");
            Console.WriteLine("type 6 for write all char from texst:");

            string input = Console.ReadLine();

            int a = 0;

            switch (input)

            {



                case "1": // Rectangel area

                    Console.WriteLine("insert lenth:");
                    float length = float.Parse(Console.ReadLine());

                    Console.WriteLine("insert width:");
                    float width = float.Parse(Console.ReadLine());

                    float area = length * width;
                    Console.WriteLine($"Area is: {area}");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    Main(args);
                    break;

                case "2": // Slope between two points

                    Console.WriteLine("insert X1:");
                    float X1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("insert Y1:");
                    float Y1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("insert X2:");
                    float X2 = float.Parse(Console.ReadLine());
                    Console.WriteLine("insert Y2:");
                    float Y2 = float.Parse(Console.ReadLine());

                    float slope = (Y2 - Y1) / (X2 - X1);

                    Console.WriteLine($"the slope is: {slope}");

                    Console.ReadLine();
                    Main(args);
                    break;


                case "3": // Length of string/texst

                    Console.WriteLine("insert text:");
                    string texst = Console.ReadLine();
                    int lenth = texst.Length;
                    Console.WriteLine($"the length of the sring is: {lenth}");

                    Console.ReadLine();
                    Main(args);
                    break;



                case "4": // Substring

                    Console.WriteLine("insert texst:");
                    string texst1 = Console.ReadLine();
                    Console.WriteLine("insert begining index:");
                    int begining = int.Parse(Console.ReadLine());
                    Console.WriteLine("insert length of index:");
                    int end = int.Parse(Console.ReadLine());

                    Console.WriteLine($"this is the substring: {texst1.Substring(begining, end)}" + texst1.Substring(begining, end));
                    Console.ReadLine();
                    Main(args);
                    break;


                case "5": // Looking for a char in a string

                    Console.WriteLine("insert texst:");
                    string texst2 = Console.ReadLine();
                    Console.WriteLine("insert char to look for:");
                    char chr = Convert.ToChar(Console.ReadLine());

                    bool found = false;

                    //while (i < ¨texst2.Length)
                    //    {
                    //    if (texst2[i] == chr)
                    //    {
                    //        Console.WriteLine($"index: {i}");
                    //        found = true;
                    //    }
                    //    i++;
                    //}

                    for (int i = 0; i < texst2.Length; i++) // Loop through each character in the string

                        if (texst2[i] == chr)
                        {
                            Console.WriteLine($"index: {i}");

                            found = true;
                        }

                    if (!found)
                    {
                        Console.WriteLine("Character not found in the string.");
                    }




                    Console.ReadLine();
                    Main(args);
                    break;

                case "6": // write all char from texst
                    Console.WriteLine("insert texst:");
                    string texst3 = Console.ReadLine();
                    for (int i1 = 0; i1 < texst3.Length; i1++) // Loop through each character in the string
                    {
                        Console.WriteLine($"index {i1}: {texst3[i1]}");
                    }
                    Console.ReadLine();
                    Main(args);
                    break;


                default:
                    Console.WriteLine("your choise for menue was not valid");
                    Console.WriteLine("Press Enter to return to the main menu");
                    Console.ReadLine();
                    
                        Main(args);
                        break;
                    
                    
                    
                    
                    
                    
            }
            Console.ReadLine();
        }
    }
}
