using SqlDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Data
{
    public class MainGroupsTableData : IMainGroupsTableData
    {
        private readonly ISqlDataAccess _db;

        public MainGroupsTableData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<List<MainGroupsTableInfoModel>> getAllGroupsForMainTable(int code)
        {
            string sql = "SELECT  Группы.id, Группы.[Программа обучения] AS Программа_обучения, COUNT(Состав_группы.Код_группы) AS Учен, Группы.[Начало обучения] as Нач, " +
                "Группы.[Начало практики] as Практ, Группы.[Окончание обучения] as Окончание, Группы.[Часов теории] as Теор, " +
                "Группы.[Часов практики] as Час_практики,  dbo.Группы.Тип_обучения as Тип " +
                "FROM Группы LEFT OUTER JOIN " +
                "Состав_группы ON Группы.id = Состав_группы.Код_группы " +
                "GROUP BY dbo.Группы.id, Группы.[Программа обучения], Группы.[Начало обучения], Группы.[Начало практики], Группы.[Окончание обучения], dbo.Группы.[Часов теории], dbo.Группы.[Часов практики], " +
                $"Группы.Программа_короткое_имя , Группы.Тип_обучения, Группы.Код_отв, Группы.Закрытие  HAVING (Группы.Код_отв = {code}) " +
                "order by Группы.id DESC";

            return _db.LoadData<MainGroupsTableInfoModel, dynamic>(sql, new { });
        }
    }
}
