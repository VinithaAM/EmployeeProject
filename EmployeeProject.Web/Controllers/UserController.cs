using Employee.Application.IServices;
using Employee.Domain.Entities;
using EmployeeProject.Web.DTO;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeProject.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController(IUserServices userService) : ControllerBase
    {
        private readonly IUserServices _userService = userService;
        readonly Response response = new();
        [HttpGet(Name = "GetUser")]
        public Response GetUsers()
        {
           
            try
            {
                List<User> users = _userService.GetUsers();
                response.Status = "Success";
                response.Message = "";
                response.Data = users;
                return response;
            }
            catch (Exception ex)
            {
                response.Status = "Failed";
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
        }
        [HttpGet("{id}", Name ="GetUserById")]
        public Response GetUserById(int id)
        {
         
            try
            {
                User users = _userService.GetUserById(id);
                response.Status = "Success";
                response.Message = "";
                response.Data = users;
                return response;
            }
            catch (Exception ex)
            {
                response.Status = "Failed";
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
          
        }
        [HttpPost(Name = "Create")]
        public Response Create(User user)
        {
            try
            {
                User users = _userService.Create(user);
                response.Status = "Success";
                response.Message = "Created Successfully..";
                response.Data = users;
                return response;
            }
            catch (Exception ex)
            {
                response.Status = "Failed";
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
      
        }
        [HttpPut(Name = "Update")]
        public Response Update(User user)
        {
            try
            {
                User users = _userService.Update(user);
                response.Status = "Success";
                response.Message = "Updated Successfully..";
                response.Data = users;
                return response;
            }
            catch (Exception ex)
            {
                response.Status = "Failed";
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
           
        }
        [HttpDelete(Name = "Delete")]
        public Response Delete(int id)
        {
            try
            {
                bool status = _userService.Delete(id);
                if(status)
                {
                    response.Status = "Success";
                    response.Message = "Deleted Successfully..";
                    response.Data = status;
                }
                else
                {
                    response.Status = "Success";
                    response.Message = "UserData Not Found";
                    response.Data = status;
                }
                return response;
            }
            catch (Exception ex)
            {
                response.Status = "Failed";
                response.Message = ex.Message;
                response.Data = null;
                return response;
            }
           
        }
    }
}
