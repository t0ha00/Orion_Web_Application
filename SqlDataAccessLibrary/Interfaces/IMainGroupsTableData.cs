
using SqlDataAccessLibrary.Models;

namespace SqlDataAccessLibrary.Data
{
    public interface IMainGroupsTableData
    {
        Task<List<MainGroupsTableInfoModel>> getAllGroupsForMainTable(int code);
    }
}