namespace Soldiers
{
    public class Soldier
    {
        public int Id;
        public string Name;
        public string Specialty;

        public Soldier Clone()
        {
            Soldier clone = (Soldier) this.MemberwiseClone(); //builtin method
            return clone;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Soldier soldier_prototype = new Soldier();
            soldier_prototype.Name = "Pvt. Sam";
            soldier_prototype.Id = 1;
            soldier_prototype.Specialty = "rifleman";

            Soldier soldier1 = soldier_prototype.Clone();
            Soldier soldier2 = soldier_prototype.Clone();

            soldier1.Id = 2;
            soldier1.Name = soldier_prototype.Name;
            soldier1.Specialty = soldier_prototype.Specialty;

            soldier2.Name = "Pvt. Rookie";
            soldier2.Id = 3;
            soldier2.Specialty = "sniper";

            DisplayValues(soldier_prototype);
            DisplayValues(soldier1);
            DisplayValues(soldier2);

            soldier1.Specialty = "grenadier";
            soldier2.Specialty = "rocketman";

            Console.WriteLine("Displaying values:\n");
            DisplayValues(soldier_prototype);
            DisplayValues(soldier1);
            DisplayValues(soldier2);
        }

        public static void DisplayValues(Soldier soldier)
        {
            Console.WriteLine($"Id: {soldier.Id:d}");
            Console.WriteLine($"Name: {soldier.Name}");
            Console.WriteLine($"Specialty: {soldier.Specialty}");
            Console.WriteLine($"\n");
        }
    }
}