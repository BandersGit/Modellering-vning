using System;

namespace ModelleringÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            Platform a1 = new Platform();
            a1.x = 50;
            a1.y = 100;
            a1.z = 30;

            Gun smg = new Gun();
            smg.dmg = 22;
            smg.ammo = 40;
            smg.firerate = 6;
            smg.accuracy = 70;

            Player you = new Player();
            you.hp = 50;
            you.speed = 5;
            you.size = 2;
            you.xpLevel = 34;



        }
    }
}
