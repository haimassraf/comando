using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class WeaponFactory
    {
        private List<Weapon> weapons = new List<Weapon>();
        public void AddWeapon(Weapon newWeapon) => weapons.Add(newWeapon);
        public List<Weapon> GetAllWeapons() => weapons;
        public Weapon CreatWeapon(string name, string manufacturer, int numberOfBulits)
        {
            Weapon newWeapon = new Weapon(name, manufacturer, numberOfBulits);
            AddWeapon(newWeapon);
            return newWeapon;
        }
    }
}
