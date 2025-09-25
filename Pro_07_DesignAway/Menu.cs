using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MenuSystem;


namespace MenuSystem
{
    internal class Menu //stilesering?
    {
        public string Title;
        public MenuItem[] MenuItems;
        public int ItemCount = 0;
        public void Show()
        {
            Console.WriteLine(Title);
            Console.WriteLine();
            for (int i = 0; i < ItemCount; i++)
            {
                Console.WriteLine("   " + MenuItems[i].Title);
                
            }
            Console.WriteLine();
            Console.WriteLine("(Tryk menupunkt eller 0 for at afslutte)");

        }

        
        

    }
}
