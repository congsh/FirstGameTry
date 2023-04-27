using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameTry.Models
{
    public class GamePad
    {
        //单例模式 
        private static GamePad? instance;
        private GamePad() { }

        public static GamePad getInstance()
        {
            if (instance == null)
            {
                instance = new GamePad();
            }
            return instance;
        }

        public double Golds { get; set; }

        public double Techs { get; set; }

        public double Metals { get; set; }

        public double Food { get; set; }

        public double IncreaseSpeedOfGolds { get; set; }

        public double IncreaseSpeedOfTechs { get; set; }

        public double IncreaseSpeedOfMetals { get; set; }

        public double IncreaseSpeedOfFood { get; set; }
    }
}
