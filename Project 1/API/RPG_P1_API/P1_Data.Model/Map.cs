namespace P1_Data.Model
{
    public class Map
    {
        //Fields
        public int xloc { get; set; }
        public int yloc { get; set; }
        public string description { get; set; }//constructors


        //constructors

        public Map() { }

        public Map(int xloc, int yloc, string description)
        {
            this.xloc = xloc;
            this.yloc = yloc;
            this.description = description;
        }
          
    }
}
