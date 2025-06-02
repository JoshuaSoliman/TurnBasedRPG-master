using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnBasedRPG
{
    public enum ClassType
    {
        Athlete, Brainiac, Clown, NewStudent, Prodigy
    }

    public class Character
    {
        public string Name;
        public ClassType Class;
        public int Variant { get; set; }

        public int MaxHp;
        public int Hp;
        public int Attack;
        public int Defense;
        public int Wits;
        public int Stress;
        public int MaxStress;
        public int MentalStrength;

        public bool IsStunned = false;
        public bool PassiveTriggered = false;
        public bool IsDefending = false;

        private Random rand = new Random();

        public Character(string name, ClassType classType)
        {
            Name = name;
            Class = classType;
            SetupStatsByClass(classType);
        }

        private void SetupStatsByClass(ClassType classType)
        {
            switch (classType)
            {
                case ClassType.Athlete:
                    MaxHp = 100; Attack = 10; Defense = 9; Wits = 1; MaxStress = 20; MentalStrength = 5;
                    break;
                case ClassType.Brainiac:
                    MaxHp = 80; Attack = 3; Defense = 4; Wits = 9; MaxStress = 20; MentalStrength = 10;
                    break;
                case ClassType.Clown:
                    MaxHp = 90; Attack = 7; Defense = 6; Wits = 5; MaxStress = 15; MentalStrength = 7;
                    break;
                case ClassType.NewStudent:
                    MaxHp = 85; Attack = 4; Defense = 4; Wits = 4; MaxStress = 15; MentalStrength = 9;
                    break;
                case ClassType.Prodigy:
                    MaxHp = 80; Attack = 15; Defense = 6; Wits = 8; MaxStress = 10; MentalStrength = 5;
                    break;
            }
            Hp = MaxHp;
        }

        public bool TryResistTaunt()
        {
            return rand.Next(100) < (MentalStrength * 2);
        }

        public string AttackTarget(Character target)
        {
            bool doubleDamage = false;
            int defenseMultiplier = target.IsDefending ? target.Defense * 2 : target.Defense;

            // Prodigy passive chance
            if (Class == ClassType.Prodigy && rand.Next(100) < 10)
            {
                doubleDamage = true;
                PassiveTriggered = true;
            }

            int minDamage = (int)(Attack * 0.8);
            int maxDamage = (int)(Attack * 1.2);
            int baseDamage = rand.Next(minDamage, maxDamage + 1);
            int originalDamage = baseDamage;

            if (doubleDamage)
                baseDamage *= 2;

            int reducedDamage = Math.Max(baseDamage - defenseMultiplier * 1, 0);

            target.Hp = Math.Max(0, target.Hp - reducedDamage);

            return $"{Name} attacks! Roll: {originalDamage}" +
                   (doubleDamage ? " (Passive: DOUBLE DAMAGE!)" : "") +
                   $", {target.Name}'s Defense: {defenseMultiplier}, Final Damage: {reducedDamage}";
        }



        public string Taunt(Character target)
        {
            if (target.TryResistTaunt())
            {
                return $"{Name} attempted to taunt {target.Name}, but they resisted it!";
            }

            int stressAdded = Wits;
            bool doubled = false;

            if (Class == ClassType.Prodigy && rand.Next(100) < 10)
            {
                stressAdded *= 2;
                doubled = true;
                PassiveTriggered = true;
            }

            target.Stress += stressAdded;
            string log = $"{Name} taunted {target.Name} for {stressAdded} Stress" +
                         (doubled ? " (Passive: DOUBLE STRESS!)" : "") +
                         $". Total Stress: {target.Stress}/{target.MaxStress}.";

            if (target.Stress >= target.MaxStress)
            {
                target.Stress = 0;
                target.IsStunned = true;
                target.Defense = 0;

                if (target.Class == ClassType.NewStudent)
                {
                    target.Attack = Math.Max(1, target.Attack - 5);
                    target.Defense = Math.Max(1, target.Defense - 5);
                    target.Wits = Math.Max(1, target.Wits - 5);
                    target.MentalStrength = Math.Max(1, target.MentalStrength - 5);

                    log += $" {target.Name} is a New Student and maxed out their stress! Their stats drop by 5!";
                }
                else if (target.Class == ClassType.Athlete && !target.PassiveTriggered)
                {
                    target.PassiveTriggered = true;
                    target.IsStunned = true;
                    log += $" {target.Name} is an Athlete and their passive triggers (Stunned on max stress)!";
                }
                else if (Class == ClassType.Brainiac)
                {
                    target.Hp = Math.Max(0, target.Hp - 20);
                    log += $" {Name} is a Brainiac and their passive triggers — {target.Name} loses 20 HP!";
                }
                else
                {
                    log += $" {target.Name} is now STUNNED!";
                }
            }

            return log;
        }

        public string Defend()
        {
            IsDefending = true;
            return $"{Name} is defending! Total defense is now {Defense * 2}.";
        }

        public void ApplyPassiveEffects()
        {
            if (Class == ClassType.NewStudent)
            {
                
                Attack += 1;
                Defense += 1;
                Wits += 1;
                PassiveTriggered = true;
            }

            if (Class == ClassType.Clown)
            {
                Stress = Math.Max(0, Stress - 3);

                if (rand.Next(100) < 10) // 10% stun
                    IsStunned = true;
                PassiveTriggered = true;
            }

            if (Class == ClassType.Athlete && PassiveTriggered)
            {
                Attack *= 2;
                PassiveTriggered = true;
            }
        }

        public void EndTurnReset()
        {
            IsDefending = false;
            if (IsStunned)
                IsStunned = false;
            ApplyPassiveEffects();
        }

        public bool IsAlive => Hp > 0;
    }
}