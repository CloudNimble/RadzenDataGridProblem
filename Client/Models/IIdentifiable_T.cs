namespace RadzenGridProblem.Client.Models
{

    public interface IIdentifiable<T> where T : struct
    {
        //
        // Summary:
        //     The unique identifier for this particular Entity.
        T Id { get; set; }
    }

}