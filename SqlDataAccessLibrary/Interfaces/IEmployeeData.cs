using SqlDataAccessLibrary.Models;

namespace SqlDataAccessLibrary.Data
{
    public interface IEmployeeData
    {
        Task<List<EmployeeModel>> GetAllEmployee();
        Task<List<EmployeeModel>> GetEmployeeByCodeSubdivision(int subdivisionCode);
    }
}