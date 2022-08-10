namespace P1_Data.Model
{
    public class Actor
    {
        //fields
        public string name { get; set; }
        public int hpmax { get; set; }
        public int hpcurrent { get; set; }
        public int attbonus { get; set; }
        public int savebonus { get; set; }
        public int damagedie { get; set; }

        //constructors
        public Actor() { }
        public Actor(string name, int hpmax, int attbonus, int savebonus, int damagedie)
        {
            this.name = name;
            this.hpmax = hpmax;
            this.hpcurrent = hpmax;
            this.attbonus = attbonus;
            this.savebonus = savebonus;
            this.damagedie = damagedie;
        }

        



    }
}