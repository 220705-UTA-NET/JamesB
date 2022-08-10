using P1_Data.Model;

namespace P1_IRepository
{
    public interface IRepository
    {
        Task<IEnumerable<Actor>> GetActorsAsync();

        Task<IEnumerable<Map>> GetMapDescriptionAsync(int xloc, int yloc);



    }
    
}
