using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    internal class WeaponFactory
    {
        private static List<Weapon> weapons = new List<Weapon>();
        public static void AddWeapon(Weapon newWeapon) => weapons.Add(newWeapon);
        public static List<Weapon> GetAllWeapons() => weapons;
        public static Weapon CreatWeapon(string name, string manufacturer, int numberOfBulits)
        {
            Weapon newWeapon = new Weapon(name, manufacturer, numberOfBulits);
            return newWeapon;
        }
    }
}
