using EFCore_DB_FirstApproach_4DBConnection.Interfaces;
using EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata.Ecma335;

namespace EFCore_DB_FirstApproach_4DBConnection.Repository
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly NorthwindDbContext _context;
        public DepartmentRepository(NorthwindDbContext context)
        {
            _context = context;
        }
        public async Task<bool> AddDepartment(Department department)
        {
            await _context.Departments.AddAsync(department);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<bool> DeleteDepartmentById(int id)
        {
            var result = await _context.Departments.Where(a => a.Deptid == id).FirstOrDefaultAsync();
            if (result != null)
            {
                _context.Departments.Remove(result);
                await _context.SaveChangesAsync();
                return true;
            }
            else
            {
                return false;
            }
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            return await _context.Departments.FirstOrDefaultAsync(a => a.Deptid == id);

        }

        public async Task<List<Department>> GetDepartments()
        {
            return await _context.Departments.ToListAsync();

        }

        public async Task<bool> UpdateDepartment(Department department)
        {
            var dep = await _context.Departments.Where(a => a.Deptid == department.Deptid).FirstOrDefaultAsync();
            dep.Deptid = department.Deptid;
            dep.Deptname = department.Deptname;
            dep.Deptlocation = department.Deptlocation;
            await _context.SaveChangesAsync();
            return true;

        }
    }
}
