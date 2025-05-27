using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comando
{
    internal class ComandorFactory
    {
        static List<Commando> commandors = new List<Commando>();
        public static void AddCommandor(Commando newCommandor) => commandors.Add(newCommandor);
        public static List<Commando> GetAllCommandors() => commandors;
        public static Commando CreatCommandor(string name, string nameCode, Status status, CommandoType commandoType = CommandoType.RegularCommandor)
        {
            if (commandoType == CommandoType.AirCommando)
            {
                AirComando newCommandor = new AirComando(name, nameCode, status);
                return newCommandor;
            }
            if (commandoType == CommandoType.SeaCommando)
            {
                SeaCommando newAirCommndo = new SeaCommando(name, nameCode, status);
                return newAirCommndo;
            }
            Commando newSeaCommndo = new Commando(name, nameCode, status);
            return newSeaCommndo;
        }
    }
}
