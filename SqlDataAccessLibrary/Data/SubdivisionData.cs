using SqlDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Data
{
    public class SubdivisionData : ISubdivisionData
    {
        private readonly ISqlDataAccess _db;

        public SubdivisionData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<List<SubdivisionModel>> GetAllSubdivisions()
        {
            string sql = "select * from dbo.Филиалы";

            return _db.LoadData<SubdivisionModel, dynamic>(sql, new { });
        }
    }
}
