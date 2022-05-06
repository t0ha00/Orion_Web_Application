using SqlDataAccessLibrary.Models;

namespace SqlDataAccessLibrary.Data
{
    public interface IGroupData
    {
        Task<List<GroupModel>> GetAllGroups();
        Task<List<GroupModel>> GetGroupsById(int id);
    }
}