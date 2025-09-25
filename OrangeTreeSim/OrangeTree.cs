using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrangeTreeSim
{
    public class OrangeTree
    {
        private int age;
        private int height; // angiver træets højde
        private bool treeAlive; // angiver (med sand/falsk), om træet er i live
        private int numOranges; // antal appelsiner på træet
        private int orangesEaten; // antal spiste appelsiner fra træe

        public int Age// angiver og retunere træets alder. (Træet kan dog kun være 0 år eller ældre.
        {
            get { return age; }
            set 
            {
                
                if (value >= 0)
                {
                    age = value;
                }
                else
                {
                    age = 0;
                }
            }
        }

        public int Height // angiver og retunere træets højde.
        {
            get { return height; }
            set { height = value; }
        }

        public bool TreeAlive // angiver og retunere om træet er i live. 
        {
            get { return treeAlive; }
            set { treeAlive = value; }
        }
        public int NumOranges // retunere antallet af appelsiner
        {
            get { return numOranges; }
        }
        public int OrangesEaten // retunere antal spiste appelsiner
        {
            get { return orangesEaten; }
        }

        /*public void SetAge(int age)
        {
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }*/

        /*public void SetHeight(int height)
        {
            this.height = height;
        }
        public int GetHeight()
        {
            return this.height;
        }*/

        /*public void SetTreeAlive(bool treeAlive)
        {
            this.treeAlive = treeAlive;
        }

        public bool GetTreeAlive()
        {
            return this.treeAlive;
        }*/

        /*public int GetNumOranges()
        { 
            return this.numOranges; 
        }

        public int GetOrangesEaten()
        {
            return this.orangesEaten;
        }*/

        public void OneYearPasses()
        {
            /*
o Træets alder øges med 1 (age-feltet)

o Træet højde øges med 2, hvis træets alder er under 80, ellers ikke (height-feltet)

o Træet er i live, hvis træets alder er under 80, ellers dødt (treeAlive)

o Træet giver ikke frugt første år, men derefter øges dets produktion med 5 appelsiner for hvert år 
  (dvs. 5 appelsiner 2. år, 10 appelsiner det 3. år, 15 appelsiner det 4. år osv.).
  Frugt fra forrige år føres ikke med over til et nyt år (numOranges-feltet)

             */
            orangesEaten = 0;
            age++;
            if (treeAlive == true)
            {                
                if (age < 80)
                {
                    height += 2;
                    if (age > 0)
                    {                       
                        numOranges = (age - 1) * 5;
                    }
                }
                else
                {
                    treeAlive = false;
                    numOranges = 0;
                }
            }                        
        }

        public void EatOrange(int count) // Count er det antal appelsiner der prøver at blive spist fra træet.
        {
            if (count <= numOranges) // hvis antallet af appelsiner på træet skal være højrer eller det samme.
            {
                orangesEaten += count; // antallet af spiste appelsiner.
                numOranges -= count; // antallet af appelsiner der er tilbage.
            }
        }
        
    }
}


