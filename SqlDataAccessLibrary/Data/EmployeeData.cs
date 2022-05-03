using SqlDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Data
{
    public class EmployeeData : IEmployeeData
    {
        private readonly ISqlDataAccess _db;

        public EmployeeData(ISqlDataAccess db)
        {
            this._db = db;
        }
        public Task<List<EmployeeModel>> GetAllEmployee()
        {
            string sql = "select * from dbo.Сотрудники";

            return _db.LoadData<EmployeeModel, dynamic>(sql, new { });
        }

        public Task<List<EmployeeModel>> GetEmployeeByCodeSubdivision(int subdivisionCode)
        {
            string sql = $"select * from dbo.Сотрудники where Код_филиала={subdivisionCode}";

            return _db.LoadData<EmployeeModel, dynamic>(sql, new { });
        }
    }
}
