using SqlDataAccessLibrary.Models;

namespace SqlDataAccessLibrary.Data
{
    public interface ISubdivisionData
    {
        Task<List<SubdivisionModel>> GetAllSubdivisions();
    }
}