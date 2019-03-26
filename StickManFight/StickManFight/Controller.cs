using System;
using System.Collections.Generic;
using System.IO;

namespace StickManFight
{
    static class Controller
    {
        //Collections 
        private static List<StickManInfo> StickManList;
        private static List<string> FightOverview;
            
        //Der skal laves en instans af listen, før der kan komme indhold i den. 
        //Derefter oprettes en StickManStats ved brug af Constructor
        //Den oprettede StickManStats tilføjes til listen
        public static void CreateNewStickMan(string name, string nationality)
        {

            if (StickManList == null || StickManList.Count >= 2)
            {
                StickManList = new List<StickManInfo>();
            }

            StickManInfo Fighter = new StickManStats(name, nationality);
            StickManList.Add(Fighter);
        }

        //Returnerer en StickManStats fra listen
        public static StickManInfo GetStickMan(int fighterNumber)
        {
            return StickManList[fighterNumber];
        }

        //Returnerer Overblikslisten
        public static List<string> GetFightOverview()
        {
            return FightOverview;
        }

        //Nulstiller Overblikslisten efter hver kamp
        public static void ClearFightOverview()
        {
            FightOverview.Clear();
        }

        //Returnerer damage på baggrund af de to randomiserede Attack- og Block-værdier
        public static int Fight(StickManStats f1, StickManStats f2)
        {
            if (f2.Health > 0)
            {
                int damage = f1.Attack() - f2.Block();

                if (damage >= 0)
                {
                    f2.Health -= damage;
                }

                return damage;
            }

            return 0;
        }

        //Sætter højde af Healthbar ved begyndelsen af kampen
        public static double HealthBarSet(StickManStats f)
        {
            if (f.Health > 0)
            {
                return Convert.ToDouble(f.Health);
            }
            else
            {
                return 0;
            }
            
        }

        //Returnerer et tilfældigt tal mellem 1 og inputparametren
        public static int GenerateRandom(int num)
        {
            Random r = new Random();
            return r.Next(1, num);
        }

        //Returnerer tekststreng med info om angrebet
        private static string GenerateFightInfo(StickManStats f1, StickManStats f2, int dmg)
        {
            if (f2.Health < 0)
            {
                return string.Format("{0} attacked {1} with {2} damage, {1} now has 0 health left", f1.Name, f2.Name, dmg, f2.Health);
            }
            else
            {
            return string.Format("{0} attacked {1} with {2} damage, {1} now has {3} health left", f1.Name, f2.Name, dmg, f2.Health);
            }

        }

        //Tilføjer angrebsinfo til overblikslisten.
        //Listen instantieres ved første kald af funktionen.
        public static void AddInfoToOverview(StickManStats f1, StickManStats f2, int dmg)
        {
            if (FightOverview == null)
            {
                FightOverview = new List<string>();
            }

            FightOverview.Add(GenerateFightInfo(f1, f2, dmg));
        }

        //Herunder defineres følgende:
        //Der tilføjes til History.txt og læses fra den
        //Der kan også nulstilles
        public const string path = @"..\..\FightHistory\History.txt";

        public static void WriteToHistoryFile(string text)
        {
            string fulltext = ReadFromHistoryFile();
            fulltext += text;
            File.WriteAllText(path, fulltext);
        }

        public static string ReadFromHistoryFile()
        {
            return File.ReadAllText(path);
        }

        public static void ClearToHistoryFile()
        {
            File.WriteAllText(path,"");
        }
    }
}
