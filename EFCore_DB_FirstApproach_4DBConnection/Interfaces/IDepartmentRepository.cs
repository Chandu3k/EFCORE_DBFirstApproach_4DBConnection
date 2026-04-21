
using EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;

namespace EFCore_DB_FirstApproach_4DBConnection.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetDepartments();

        Task<Department> GetDepartmentById(int id);
        Task<bool> UpdateDepartment(Department department);

        Task<bool> DeleteDepartmentById(int id);
        Task<bool> AddDepartment(Department department);

    }
}
