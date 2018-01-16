using System.Linq;


namespace CodeWars.GoodVsEvil
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kata.GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1");
            var result = Kata.GoodVsEvil("1 0 0 0 0 0", "1 0 0 0 0 0 0");
        }
    }

    internal class Kata
    {
        private static readonly int[] GoodsForces = new[] { 1, 2, 3, 3, 4, 10 };
        private static readonly int[] EvilsForces = new[] { 1, 2, 2, 2, 3, 5, 10 };

        public static string GoodVsEvil(string goods, string evils)
        {
            var goodArmy = goods.Split(' ').ToList().Select(int.Parse).ToList();
            var evilArmy = evils.Split(' ').ToList().Select(int.Parse).ToList();

            int goodForceTotal = 0;
            int evilForceTotal = 0;


            for (int i = 0; i < goodArmy.Count; i++)
            {
                goodForceTotal += GoodsForces[i] * goodArmy[i];
            }


            for (int i = 0; i < evilArmy.Count; i++)
            {
                evilForceTotal += EvilsForces[i] * evilArmy[i];
            }


            string result = "Battle Result: No victor on this battle field";

            if (goodForceTotal > evilForceTotal)
                result = "Battle Result: Good triumphs over Evil";
            else if (evilForceTotal > goodForceTotal)
                result = "Battle Result: Evil eradicates all trace of Good";

            return result;
        }
    }


    //Best Practice
    //public class Kata
    //{
    //    public enum GoodRacesValues
    //    {
    //        Hobbits = 1,
    //        Men = 2,
    //        Elves = 3,
    //        Dwarves = 3,
    //        Eagles = 4,
    //        Wizards = 10
    //    }

    //    public enum EvilRacesValues
    //    {
    //        Orcs = 1,
    //        Men = 2,
    //        Wargs = 2,
    //        Goblins = 2,
    //        UrukHai = 3,
    //        Trolls = 5,
    //        Wizards = 10
    //    }

    //    public static string GoodVsEvil(string good, string evil)
    //    {
    //        string[] goodArmyValues = good.Split(' ');
    //        string[] evilArmyValues = evil.Split(' ');
    //        int goodArmyForces = Kata.CalculateForces<GoodRacesValues>(goodArmyValues);
    //        int evilArmyForces = Kata.CalculateForces<EvilRacesValues>(evilArmyValues);

    //        return Kata.GetBattleResult(goodArmyForces, evilArmyForces);
    //    }

    //    public static int CalculateForces<T>(string[] armyValues)
    //    {
    //        int i = 0;
    //        int totalForces = 0;
    //        foreach (T raceValue in Enum.GetValues(typeof(T)))
    //        {
    //            totalForces += Convert.ToInt32(raceValue) * int.Parse(armyValues[i]);
    //            ++i;
    //        }
    //        return totalForces;
    //    }

    //    public static string GetBattleResult(int goodArmyForces, int evilArmyForces)
    //    {
    //        if (goodArmyForces > evilArmyForces)
    //        {
    //            return "Battle Result: Good triumphs over Evil";
    //        }
    //        else if (goodArmyForces < evilArmyForces)
    //        {
    //            return "Battle Result: Evil eradicates all trace of Good";
    //        }
    //        else
    //        {
    //            return "Battle Result: No victor on this battle field";
    //        }
    //    }
    //}
}
