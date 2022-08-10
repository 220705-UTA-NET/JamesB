using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.DTO
{
    public class Character
    {
        public string name { get; set; }
        public int hpmax { get; set; }
        public int hpcurrent { get; set; }
        public int attbonus { get; set; }
        public int savebonus { get; set; }
        public int damagedie { get; set; }

        public Character(){}

        public void create(int hp, int att, int save, int ddie)
        {
            hpmax = hp;
            hpcurrent = hp;
            attbonus = att;
            savebonus = save;
            damagedie = ddie;
        }
            
    }
}
