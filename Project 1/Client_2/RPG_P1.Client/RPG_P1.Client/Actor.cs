using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_P1.Client
{
    public class Actor
    {
        //Fields
        public string name { get; set; }
        public int hpmax { get; set; }
        public int hpcurrent { get; set; }
        public int attbonus { get; set; }
        public int savebonus { get; set; }
        public int damagedie { get; set; }

        public Actor() { }

        public Actor(string name, int hp, int att, int save, int damage)
        {
            this.name = name;
            this.hpmax = hp;
            this.hpcurrent = hp;
            this.attbonus = att;
            this.savebonus = save;
            this.damagedie = damage;

        }

        public override string ToString()
        {
            return $"{name} {hpmax} {hpcurrent} {attbonus} {savebonus} {damagedie}"; 
        }
    }
}
