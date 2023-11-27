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
        // (attack) infinity/3 + (defense) ((infinity/3) + 40) + (speed) -infinity + (constitution) infinity/3 = 40 so it's okay lol
        double attack = (double.PositiveInfinity / 3);
        double defense = (double.PositiveInfinity / 3) + 40;
        double speed = double.NegativeInfinity;
        static double constitution = (double.PositiveInfinity / 3); //break this pls
        double health = 10 * constitution;

        public void setStats(double att, double def, double spe, double cons)
        {
            attack = att;
            defense = def;
            speed = spe;
            constitution = cons;
            health = 10 * constitution;
        }
        public double GetHealth()
        {
            Reset();
            return health;
        }

        public double GetMaxHealth() => 10 * constitution;

        public string GetPrimaryColor() => "#4991E5";

        public string GetSecondaryColor() => "#F15515";

        public string GetRobotName() => "Joe";

        public double GetSpeed() => speed;

        public string GetStats() => ($"Current Health: {health}, Attack: {attack}, Defense: {defense}, Speed: {speed}.\n bruh{((speed + constitution) + attack) + defense}");


        public string[] GetStudentNames() => new string[] { "Samuel Deaton", "Gavin Boyle, Elijah Church, Alexander Smith" };

        public ActionResult PerformAction(IRobot opponent)
        {
            opponent.TakeDamage(attack);
            opponent.GetStats();
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
