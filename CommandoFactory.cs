using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    class CommandoFactory
    {
        private List<Commando> commandors = new List<Commando>();
        public void AddCommando(Commando newCommandor) => commandors.Add(newCommandor);
        public List<Commando> GetAllCommandos() => commandors;
        public Commando CreatCommando(string name, string nameCode, CommandoType commandoType = CommandoType.RegularCommandor)
        {
            Commando newCommando;
            if (commandoType == CommandoType.AirCommando)
            {
                newCommando = new AirCommando(name, nameCode);
            }
            else if (commandoType == CommandoType.SeaCommando)
            {
                newCommando = new SeaCommando(name, nameCode);
            }
            else if (commandoType == CommandoType.RegularCommandor)
            {
                newCommando = new Commando(name, nameCode);
            }
            else
            {
                throw new ArgumentException("Unsupported commando type.");
            }
            AddCommando(newCommando);
            return newCommando;
        }
    }
}
