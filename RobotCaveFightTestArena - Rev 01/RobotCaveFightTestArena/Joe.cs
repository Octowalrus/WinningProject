using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCaveFightTestArena
{
    internal class Joe : IRobot
    {
        
        double attack = 39;
        double defense = 1;
        double speed = -20000;
        static double constitution = 20000; //break this pls
        double health = 10 * constitution;
        
        public void setStats(double att, double def, double spe, double cons)
        {
            attack = att;
            defense = def;
            speed = spe;
            constitution = cons;
            health = 10 * constitution;
        }
        public double GetHealth() => health;

        public double GetMaxHealth() => 10 * constitution;

        public string GetPrimaryColor() => "#4991E5";

        public string GetSecondaryColor() => "#F15515";

        public string GetRobotName() => "Joe";

        public double GetSpeed() => speed;

        public string GetStats() => ($"Current Health: {health}, Attack: {attack}, Defense: {defense}, Speed: {speed}.");

        public string[] GetStudentNames() => new string[] { "Samuel Deaton", "The other people in this group" };

        public ActionResult PerformAction(IRobot opponent)
        {
            opponent.TakeDamage(attack);
            Console.WriteLine(opponent.GetStats());
            return new ActionResult("One Punch", "Punch");
        }

        //public ActionResult Attack(IRobot opponent) => new ActionResult("fortnite", "Punch");


        public void Reset() => health = 10 * constitution;

        public void TakeDamage(double damage)
        {
            double damageDealt = damage - (defense / 100 * damage);
            health -= damageDealt;

        }
    }
}
