namespace Pro_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string navn = "none";
            int alder = 0; // Eksempel på en variabel
            bool notExit = true;

            while (notExit)
            {
                Console.Clear();
                Console.WriteLine("dette er en meny hvor du kan ændre dit navn og alder");
                Console.WriteLine("1 for at ændre navn");
                Console.WriteLine("2 for at ændre alder");
                Console.WriteLine("3 for udprint");
                
                string indput = Console.ReadLine();

                switch (indput)

                {
                    case "1":


                        Console.Write("Hvad er dit navn? ");
                        navn = Console.ReadLine();
                        break;

                    case "2":

                        Console.Write("Hvad er din alder? ");
                        alder = int.Parse(Console.ReadLine());
                        break;

                    case "3":

                        //if (alder == 0)
                        //{
                        //    indsæt = "du er lige blevet født";

                        //}
                        //else if (alder < 20)

                        //{
                        //    indsæt = "du er vildt gammel";
                        //}
                        //else
                        //{
                        //    indsæt = "hvorfor er du ikke død?";
                        //}
                        Console.WriteLine($"Hej {navn}, du er {alder} år gammel, velkommen til C# programmering!");
                        Console.ReadLine();


                        break;
                        
                        
                        

                }
            }
            
        }       
    }
}
