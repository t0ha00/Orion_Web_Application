using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlDataAccessLibrary
{
    public class StudentsData : IStudentsData
    {
        private readonly ISqlDataAccess _db;

        public StudentsData(ISqlDataAccess db)
        {
            this._db = db;
        }

        public Task<List<StudentsModel>> GetAllStudents()
        {
            string sql = "select * from dbo.Учащиеся";

            return _db.LoadData<StudentsModel, dynamic>(sql, new { });
        }

        public Task InsertStudent(StudentsModel student)
        {
            string sql = @"insert int dbo.Учащиеся (ФИО, Дата_рождения, ТН, ИНН, СНИЛС, Почта, Примечание, Тел, s, Ур_образования)
                            values (@ФИО, @Дата_рождения, @ТН, @ИНН, @СНИЛС, @Почта, @Примечание, @Тел, @s, @Ур_образования);";

            return _db.SaveData(sql, student);
        }
    }
}
