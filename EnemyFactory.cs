using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    static class EnemyFactory
    {
        private static List<Enemy> enemys = new List<Enemy>();
        public static void AddEnemy(Enemy newEnemy) => enemys.Add(newEnemy);
        public static List<Enemy> GetAllEnemys() => enemys;
        public static Enemy CreatEnemy(string name)
        {
            Enemy newEnemy = new Enemy(name);
            return newEnemy;
        }
    }
}
