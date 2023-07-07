using System;

namespace BasicsTutorial
{
    public class Spaceship
    {
        public string Name;
        public string Hull;
        public string Type;
        public int HullHP;
        public int GunPower;
        public int Energy;
        public int Crew;
        public int Enemy;
         
        public Spaceship(string name,string hull, string type, int hullHP, int gunpower, int energy, int crew,int enemy)
        {
            Name = name;
            Hull = hull;
            Type = type;
            HullHP = hullHP;
            GunPower = gunpower;
            Energy = energy;
            Crew = crew;
            Enemy = enemy;
        }
        public int Damage(int damage)
        {
            HullHP = HullHP - damage;
            return HullHP;
        }
        public int Repair(int RepairPower )
        {
            HullHP = HullHP + RepairPower;
            return HullHP;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        Start:;
            bool turn= true;
            int Order;
            int Choosen=0;
            bool A = false;
            string Choice;
            Spaceship[] YourShip = new Spaceship[1];
            Spaceship[] EnemyShip = new Spaceship[1];
            Spaceship[] Ships = new Spaceship[2];
            Spaceship Shepherd = new Spaceship("Shepherd","shepherd", "destroyer", 25, 3,30,8,-1);
            Spaceship Wolf = new Spaceship("Wolf", "wolf", "destroyer", 20, 5, 20, 5,-1);
            Ships[0] = Shepherd;
            Ships[1]= Wolf;
            for (int i=0; i<Ships.Length; i++)
            {
                Console.WriteLine(Ships[i].Name);
            }
            Console.WriteLine("To choose write the name of your ship:");
            Choice = Console.ReadLine();

                for (Choosen = 0; Choosen < Ships.Length; Choosen++)
                {
                    if (Choice == Ships[Choosen].Name)
                    {
                        if (A == false)
                        {
                            YourShip[0] = Ships[Choosen];
                            YourShip[0].Enemy = 1;
                            Console.WriteLine("You Choose " + YourShip[0].Name);
                            Ships[Choosen] = null;
                            A = true;
                            break;
                        }
                    }
                }
           Console.WriteLine("To choose write the name of your enemy ship:");
            
                for (int i = 0; i < Ships.Length; i++)
                {
                    if (i != Choosen)
                    {
                        Choice = Console.ReadLine();
                        if (Choice == Ships[i].Name)
                        {
                            EnemyShip[0] = Ships[i];
                        }
                    }
                }
                Console.WriteLine("Your Ship is: " + YourShip[0].Name);
                Console.WriteLine("Your Enemy is: " + EnemyShip[0].Name);
            

            while (YourShip[0].HullHP > 0 || EnemyShip[0].HullHP > 0) {
                Console.WriteLine("Your Healt " + YourShip[0].HullHP);
                Console.WriteLine("Enemy Healht " + EnemyShip[0].HullHP);
                if (YourShip[0].HullHP > 0)
                {
                    while (turn == true)
                    { 
                        Console.WriteLine("Your Lieutenant: Your Orders Sir");
                        Console.WriteLine("1)Attack -- 2)Repair");
                        int.TryParse(Console.ReadLine(), out Order);
                        if (Order == 1)
                        {
                            int damage;
                            damage = YourShip[0].GunPower;
                            EnemyShip[0].Damage(damage);
                            turn = false;
                        }
                        else if (Order == 2)
                        {
                            YourShip[0].Repair(YourShip[0].Crew);
                            turn = false;
                        }
                }             
            }
            
            else
            {
                Console.WriteLine("Your Liutenant: Sir There is a Light Am I DEAD!");
                    goto Start;
            }


                if (EnemyShip[0].HullHP > 0)
                {

                    Random random = new Random();
                    int EnemyOrder = random.Next(1, 3);
                    while (turn == false)
                    {
                        Console.WriteLine("Enemy Order: " + EnemyOrder);
                        if (EnemyOrder == 1)
                        {
                            int damage;
                            damage = EnemyShip[0].GunPower;
                            YourShip[0].Damage(damage);
                            turn = true;
                        }
                        else if (EnemyOrder == 2)
                        {
                            EnemyShip[0].Repair(EnemyShip[0].Crew);
                            turn = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Your Liutenant: We Won Sir");
                    goto Start;
                }
            }
        }
    }
}

