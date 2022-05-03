
namespace SqlDataAccessLibrary
{
    public interface IStudentsData
    {
        Task<List<StudentsModel>> GetAllStudents();
        Task InsertStudent(StudentsModel student);
    }
}