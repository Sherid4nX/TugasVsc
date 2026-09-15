using System;

namespace GameEncapsulationDemo
{
    public class Character
    {
        public String? charId;
        protected String? charName;
        internal String? charCls;
        private float? health;
        private int? level;

//1. Konstruktor default
        
        public void Start()
        {
            level = 1;
            health = 100;
            Console.WriteLine($"Karakter {charName} (level {level}) memulai petualangan!");
        }

        private void LevelUp()
        {
            level++;
            Console.WriteLine($"{charName} naik level! Level sekarang {level}");
        }

        public void TakeDmg(float dmg)
        {
            health -= dmg;
            Console.WriteLine($"{charName} menerima damage sebesar {dmg} damage. Heath tersisa {health}");
            if (health <= 0)
            {
                Console.WriteLine($"{charName} telah gugur!");
            }
        }

        public void Heal(float healing)
        {
            health += healing;
            Console.WriteLine($"{charName} menerima pemulihan sebesar {healing}! Health saat ini {health}");
        }

        public void ShowStats()
        {
            Console.WriteLine($"ID = {charId}");
            Console.WriteLine($"Name = {charName}");
            Console.WriteLine($"Class = {charCls}");
            Console.WriteLine($"ID = {charId}");
            Console.WriteLine($"Level = {level}");
            Console.WriteLine($"Health = {health}");
        }
    }
}