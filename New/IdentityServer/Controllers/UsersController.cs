using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    /// <summary>
    /// 提供用户相关的接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        /// <summary>
        /// 获取用户
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取用户列表
        /// </summary>
        /// <param name="searchText">查询关键字</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">每页的大小</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get(string searchText, int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Post()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改用户
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取用户的角色列表
        /// </summary>
        /// <param name="id">用户Id</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">每页的大小</param>
        /// <returns></returns>
        [HttpGet("{id}/Roles")]
        public IActionResult GetUserRoles(string id, int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 添加用户角色
        /// </summary>
        /// <returns></returns>
        [HttpPost("Roles")]
        public IActionResult PostUserRoles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除用户角色
        /// </summary>
        /// <returns></returns>
        [HttpDelete("Roles")]
        public IActionResult DeleteUserRoles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        [HttpPost("ChangePassword")]
        public IActionResult PostChangePassword()
        {
            throw new NotImplementedException();
        }
    }
}
