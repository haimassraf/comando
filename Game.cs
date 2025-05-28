using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace comando
{
    internal class Game
    {
        private CommandoFactory commandoFactory;
        private WeaponFactory weaponFactory;
        private EnemyFactory enemyFactory;

        public Game()
        {
            commandoFactory = new CommandoFactory();
            weaponFactory = new WeaponFactory();
            enemyFactory = new EnemyFactory();
        }

        public Commando CreateComandor(string name, string nameCode, CommandoType commandoType = CommandoType.RegularCommandor)
        {
          Commando newCommando = commandoFactory.CreatCommando(name, nameCode, commandoType);
            return newCommando;
        }

        public Weapon CreateWeapon(string name, string manufacturer, int numberOfBulits)
        {
            Weapon newWeapon = weaponFactory.CreatWeapon(name, manufacturer, numberOfBulits);
            return newWeapon;
        }

        public Enemy CreateEnemy(string name)
        {
            Enemy newEnemy = enemyFactory.CreatEnemy(name);
            return newEnemy;
        }
    }
}
