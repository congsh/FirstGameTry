using FirstGameTry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGameTry.Modules
{
    public class RefreshService
    {
        private static GamePad gp = GamePad.getInstance();
        public static void Update()
        {
            CalcResouce();
        }

        public static void GenMap(List<List<string>> Items)
        {
            if (Items == null)
            {
                Items = new List<List<string>>();
            }
            Items.Clear();
        }

        private static void CalcResouce()
        {
            gp.Food += gp.IncreaseSpeedOfFood;
            gp.Golds += gp.IncreaseSpeedOfGolds;
            gp.Metals += gp.IncreaseSpeedOfMetals;
            gp.Techs += gp.IncreaseSpeedOfTechs;
        }
    }
}
