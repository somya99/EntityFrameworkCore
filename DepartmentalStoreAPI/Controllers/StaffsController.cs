using AutoMapper;
using DepartmentalStoreAPI.DepartmentalStore.Data;
using DepartmentalStoreAPI.DepartmentalStore.Domain;
using DepartmentalStoreAPI.DepartmentalStore.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffsController : ControllerBase
    {
        private readonly IDStoreRepository _repository;
        private readonly IMapper _mapper;
        

        public StaffsController(IDStoreRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
            
        }

        [HttpGet]
        public async Task<ActionResult<StaffModel[]>> Get(bool includeRole = true)
        {
            try
            {
                var results = await _repository.GetAllStaffAsync(includeRole);

                return _mapper.Map<StaffModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("{staffId}")]
        public async Task<ActionResult<StaffModel>> GetById(long staffId, bool includeRole = true)
        {
            try
            {
                var result = await _repository.GetStaffAsync(staffId, includeRole);

                if (result == null) return NotFound();

                return _mapper.Map<StaffModel>(result);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("firstname/{firstname}")]
        public async Task<ActionResult<StaffModel>> GetByFirstName(string firstname, bool includeRole = true)
        {
            try
            {
                var result = await _repository.GetStaffByFirstNameAsync(firstname, includeRole);

                if (result == null) return NotFound();

                return _mapper.Map<StaffModel>(result);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("lastname/{lastname}")]
        public async Task<ActionResult<StaffModel>> GetByLastName(string lastname, bool includeRole = true)
        {
            try
            {
                var result = await _repository.GetStaffByLastNameAsync(lastname, includeRole);

                if (result == null) return NotFound();

                return _mapper.Map<StaffModel>(result);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("phoneno/{phoneno}")]
        public async Task<ActionResult<StaffModel>> GetByPhoneNo(string phoneno, bool includeRole = true)
        {
            try
            {
                var result = await _repository.GetStaffByPhoneAsync(phoneno, includeRole);

                if (result == null) return NotFound();

                return _mapper.Map<StaffModel>(result);

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        [HttpGet("searchbyrole")]
        public async Task<ActionResult<StaffModel[]>> SearchByDate(string rolename, bool includeRole = true)
        {
            try
            {
                var results = await _repository.GetAllStaffByRole(rolename, includeRole);

                if (!results.Any()) return NotFound();

                return _mapper.Map<StaffModel[]>(results);
            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }
        }
        public async Task<ActionResult<StaffModel>> Post(Staff staff)
        {
            try
            {
                _repository.Add(staff);
                if (await _repository.SaveChangesAsync())
                {
                    return Created($"/api/Staffs/{staff.StaffId}", _mapper.Map<StaffModel>(staff));
                }

            }
            catch (Exception)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, "Database Failure");
            }

            return BadRequest();
        }
        [HttpPut("{staffId}")]
        public async Task<ActionResult<StaffModel>> Put(long staffId, StaffModel model)
        {
            try
            {
                var staff = await _repository.GetStaffAsync(staffId, true);
                if (staff == null) return NotFound("Couldn't find the staff");

                _mapper.Map(model, staff);

                if (model.StaffRole != null)
                {
                    var role = await _repository.GetStaffRoleAsync(model.StaffRole.StaffRoleId);
                    if (role != null)
                    {
                        staff.StaffRole = role;
                    }
                }

                if (await _repository.SaveChangesAsync())
                {
                    return _mapper.Map<StaffModel>(staff);
                }
                else
                {
                    return BadRequest("Failed to update database.");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to get Staff");
            }
        }
        [HttpDelete("{staffId}")]
        public async Task<IActionResult> Delete(long staffId)
        {
            try
            {
                var staff = await _repository.GetStaffAsync(staffId);
                if (staff == null) return NotFound("Failed to find the staff to delete");
                _repository.Delete(staff);

                if (await _repository.SaveChangesAsync())
                {
                    return Ok();
                }
                else
                {
                    return BadRequest("Failed to delete staff");
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Failed to get Staff");
            }
        }
    }
}
