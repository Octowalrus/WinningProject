using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotCaveFightTestArena
{
    internal class Titan : IRobot
    {
        double attack = double.PositiveInfinity / 3;
        double defense = (double.PositiveInfinity / 3) + 40;
        double speed = double.NegativeInfinity;
        static double constitution = double.PositiveInfinity / 3;
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

        public string GetRobotName() => "Titan";

        public double GetSpeed() => speed;
        public double GetAttack() => attack;
        public double GetDefense() => defense;

        public string GetStats() => ($"Current Health: {health}, Attack: {attack}, Defense: {defense}, Speed: {speed}.");

        public string[] GetStudentNames() => new string[] { "Samuel Deaton", "The other people in this group" };

        public ActionResult PerformAction(IRobot opponent)
        {
            opponent.TakeDamage(attack);
            return new ActionResult("One Punch2", "Punch");
        }

        public void Reset() => health = 10 * constitution;
        public void TakeDamage(double damage)
        {
            double damageDealt = damage - (defense / 100 * damage);
            health = health - damageDealt;

        }
    }
}
