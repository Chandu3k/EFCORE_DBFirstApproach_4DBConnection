
using EFCore_DB_FirstApproach_4DBConnection.Dtos;

namespace EFCore_DB_FirstApproach_4DBConnection.Interfaces
{
    public interface IDepartmentService
    {
        Task<List<DepartmentDto>> GetDepartments();

        Task<DepartmentDto> GetDepartmentById(int id);
        Task<bool> UpdateDepartment(DepartmentDto department);

        Task<bool> DeleteDepartmentById(int id);
        Task<bool> AddDepartment(DepartmentDto department);
    }
}
