using System;

namespace GameEncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Character hero1 = new Character();
            
            hero1.charId = "T1000";
            hero1.charName = "Zioth";
            hero1.charCls = "Low Tier Knight";
            hero1.health = 122;
            hero1.level = 1;
            
            hero1.ShowStats();
            Console.ReadKey();
        }
    }
}