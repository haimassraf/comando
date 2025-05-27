using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class Weapon
    {
        private string name;
        private string manufacturer;
        private int numberOfBulits;

        public void Shoot()
        {
            if (this.numberOfBulits > 0)
            {
                this.numberOfBulits -= 1;
                Console.WriteLine($"Solder shoot.");
            }
            else
            {
                Console.WriteLine("You don`t have enught bulits.");
            }
        }

        public Weapon(string name, string manufacturer, int numberOfBulits)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.numberOfBulits = numberOfBulits;
            WeaponFactory.AddWeapon(this);
        }
    }
}
