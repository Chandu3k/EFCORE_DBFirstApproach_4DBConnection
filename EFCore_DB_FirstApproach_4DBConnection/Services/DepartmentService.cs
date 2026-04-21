using EFCore_DB_FirstApproach_4DBConnection.Dtos;
using EFCore_DB_FirstApproach_4DBConnection.Interfaces;
using EFCore_DB_FirstApproach_4DBConnection.NorthwindDBModels;

namespace EFCore_DB_FirstApproach_4DBConnection.Services
{
 
        public class DepartmentService : IDepartmentService
        {
            private readonly IDepartmentRepository _repository;
            //constructor injection
            public DepartmentService(IDepartmentRepository repository)
            {
                _repository = repository;
            }

        public async Task<bool> AddDepartment(DepartmentDto deptdetail)
        {
            Department dept = new Department();
            dept.Deptname = deptdetail.Deptname;
            dept.Deptlocation = deptdetail.Deptlocation;
            var res = await _repository.AddDepartment(dept);
            return res;
        }

        public async Task<bool> DeleteDepartmentById(int deptid)
            {
                await _repository.DeleteDepartmentById(deptid);
                return true;
            }

            public async Task<DepartmentDto> GetDepartmentById(int deptid)
            {
                var res = await _repository.GetDepartmentById(deptid);
                DepartmentDto deptdto = new DepartmentDto();
                deptdto.Deptid = res.Deptid;//Here i am mapping entity object properties to Dto Object properties.
                deptdto.Deptname = res.Deptname;
                deptdto.Deptlocation = res.Deptlocation;
                return deptdto;
            }

            public async Task<List<DepartmentDto>> GetDepartments()
            {
                List<DepartmentDto> lstdeptdto = new List<DepartmentDto>();
                var res = await _repository.GetDepartments();
                foreach (Department dept in res)
                {

                    DepartmentDto deptdto = new DepartmentDto();
                    deptdto.Deptid = dept.Deptid;//Here i am mapping entity object properties to Dto Object properties.
                    deptdto.Deptname = dept.Deptname;
                    deptdto.Deptlocation = dept.Deptlocation;
                    lstdeptdto.Add(deptdto);

                }
                return lstdeptdto;
            }

            public async Task<bool> UpdateDepartment(DepartmentDto deptdetail)
            {
                Department dept = new Department();
                dept.Deptid = deptdetail.Deptid;
                dept.Deptname = deptdetail.Deptname;
                dept.Deptlocation = deptdetail.Deptlocation;
                await _repository.UpdateDepartment(dept);
                return true;
            }
        }
    }
