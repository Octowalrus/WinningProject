/**
*--------------------------------------------------------------------
* File name: Joe.cs
* Project name: RobotCaveFightTestArena
* Solution name: RobotCaveFightTestArena
*--------------------------------------------------------------------
* Author’s name and email: Samuel Deaton, Gavin Boyle, Elijah Church, Alexander Smith
* Course-Section: CSCI 1250-002
* Creation Date: November 28, 2023
* Modified Date: December 3, 2023
* -------------------------------------------------------------------
*/

using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace RobotCaveFightTestArena
{
    internal class Joe : IRobot
    {   
        /// <summary>
        /// Stats (attack, defense, speed, and constitution) are set here, as well as health (determined by constitution).
        /// </summary>
        double attack = (double.PositiveInfinity) / 3;
        double defense = double.NegativeInfinity;
        double speed = (double.PositiveInfinity / 3) + 40;
        static double constitution = double.PositiveInfinity / 3; //constitution needs to be static because health can't access it.

        double health = 10 * constitution;
        public double GetAttack() => attack;
        public double GetDefense() => defense;
        public double GetHealth() => health;
        public double GetMaxHealth() => 10 * constitution;
        public string GetPrimaryColor() => "#4991E5";
        public string GetSecondaryColor() => "#F15515";
        public string GetRobotName() => "Darryl";
        public double GetSpeed() => speed;
        public string GetStats() => ($"Current Health: {health}, Attack: {attack}, Defense: {defense}, Speed: {speed}.");
        public string[] GetStudentNames() => new string[] { "Samuel Deaton", "Gavin Boyle" , "Elijah Church" , "Alexander Smith" };
        /// <summary>
        /// This method decides which action is taken.
        /// </summary>
        /// <param name="opponent">
        /// Way to interact with opponent through IRobot
        /// </param>
        /// <returns>
        /// The action to be performed.
        /// </returns>
        public ActionResult PerformAction(IRobot opponent)
        {
            Random randnumber = new Random();
            int x = randnumber.Next(1, 1);
            ActionResult finalResult = new ActionResult("", "");
            if (x == 1)
            {
                if (double.IsNaN(health) || health <= 0) 
                {
                    health = 0;
                    attack = attack - 1;
                    health = 3;
                    finalResult = new ActionResult("Nuh uh", "Heal");  //Heal
                }
                else    
                {
                    finalResult = new ActionResult("Activate Instant Kill", "Punch");  //Attack 1
                    opponent.TakeDamage(attack);
                }
            }
            else
            {
                finalResult = new ActionResult("Bruh", "Power Up");    //Attack 2
                opponent.TakeDamage((attack * .9) + (defense * .1));
            }

            return finalResult;
        }
        /// <summary>
        /// Resets the health for a new battle.
        /// </summary>
        public void Reset()
        {
            attack = (double.PositiveInfinity) / 3;
            defense = double.NegativeInfinity;
            speed = (double.PositiveInfinity / 3) + 40;
            constitution = double.PositiveInfinity / 3;
            health = 10 * constitution;
        }
        /// <summary>
        /// Method for taking damage and subtracting from health.
        /// </summary>
        /// <param name="damage">
        /// The opponents attack is interpreted as damage
        /// </param>
        public void TakeDamage(double damage)
        {
            double damageDealt = damage - (defense / 100 * damage);
            health -= damageDealt;
        }
    }
}