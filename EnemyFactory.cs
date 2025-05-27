using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class EnemyFactory
    {
        private List<Enemy> enemys = new List<Enemy>();
        public void AddEnemy(Enemy newEnemy) => enemys.Add(newEnemy);
        public List<Enemy> GetAllEnemys() => enemys;
        public Enemy CreatEnemy(string name)
        {
            Enemy newEnemy = new Enemy(name);
            return newEnemy;
        }
    }
}
