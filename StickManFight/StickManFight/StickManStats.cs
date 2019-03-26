using System;

namespace StickManFight
{
    class StickManStats : StickManInfo
    {
        //Properties
        
        public int Health { get; set; }

        private int AttackMax { get; set; }

        private int BlockMax { get; set; }


        //Constructor
        //Hvis intet navn indtastes og ingen nationalitet vælges
        //tildeles Fighteren navnet: Unknown Fighter from Nowhere.
        //Standardværdier for stats sættes her
        public StickManStats(string name, string nationality)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                Name = "Unknown Fighter";
            }
            else
            {
                Name = name;
            }

            if (string.IsNullOrWhiteSpace(nationality))
            {
                Nationality = "Nowhere";
            }
            else
            {
            Nationality = nationality;
            }

            Health = 100;
            AttackMax = 30;
            BlockMax = 5;
        }

        //Methods
        //Intastede stats tilføjes til de enkelte StickMen
        public static void AddStats(StickManStats s1, StickManStats s2,string h1, string a1, string b1, string h2, string a2, string b2)
        {
            try
            {
                s1.Health = Convert.ToInt32(h1);
                s1.AttackMax = Convert.ToInt32(a1);
                s1.BlockMax = Convert.ToInt32(b1);

                s2.Health = Convert.ToInt32(h2);
                s2.AttackMax = Convert.ToInt32(a2);
                s2.BlockMax = Convert.ToInt32(b2);
            }
            catch (OverflowException){ }
            catch (FormatException) { }
        }

        //Genererer en tilfældig Attack-værdi mellem 1 og AttackMax
        public int Attack()
        {
            return Controller.GenerateRandom(AttackMax + 1);
        }

        //Genererer en tilfældig Block-værdi mellem 1 og BlockMax
        public int Block()
        {
            return Controller.GenerateRandom(BlockMax + 1);
        }

        //Returnerer vinderinformation som bruges til afsluttende overblik
        public static string GenerateWinnerInfo(StickManStats winner, StickManStats loser)
        {
            return String.Format("{0} has died, and the Winner is {1}", loser.Name, winner.GenerateInfo());
        }

    }
}
