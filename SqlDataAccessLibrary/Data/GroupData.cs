using SqlDataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary.Data
{
    public class GroupData : IGroupData
    {
        private readonly ISqlDataAccess _db;

        public GroupData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<List<GroupModel>> GetAllGroups()
        {
            string sql = "select [id], [Код], [Код_программы], [Программа обучения] as Программа_обучения, [Начало обучения] as Начало_обучения, [Начало практики] as Начало_практики, " +
                "[Окончание обучения] as Окончание_обучения, [Часов теории] as Часов_теории, [Часов практики] as Часов_практики, [Пояснение], [Закрытие], [Код_отв], [Оператор], " +
                "[Программа_короткое_имя], [Тип_обучения], [Подразделение], [Ответственный], [Можно_закрывать], [id_программы], [Сдан_в_архив], [Контроль], [Проверено] " +
                "from dbo.Группы";

            return _db.LoadData<GroupModel, dynamic>(sql, new { });
        }

        public Task<List<GroupModel>> GetGroupsById(int id)
        {
            string sql = "select [id], [Код], [Код_программы], [Программа обучения] as Программа_обучения, [Начало обучения] as Начало_обучения, [Начало практики] as Начало_практики, " +
                "[Окончание обучения] as Окончание_обучения, [Часов теории] as Часов_теории, [Часов практики] as Часов_практики, [Пояснение], [Закрытие], [Код_отв], [Оператор], " +
                "[Программа_короткое_имя], [Тип_обучения], [Подразделение], [Ответственный], [Можно_закрывать], [id_программы], [Сдан_в_архив], [Контроль], [Проверено] " +
                "from dbo.Группы " +
                $"where id = {id}";

            return _db.LoadData<GroupModel, dynamic>(sql, new { });
        }
    }
}
