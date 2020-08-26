using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    /// <summary>
    /// 提供组织相关的接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class OrganizationsController : ControllerBase
    {
        /// <summary>
        /// 获取组织
        /// </summary>
        /// <param name="id">组织Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取组织列表
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
        /// 添加组织
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public IActionResult Post()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 修改组织
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public IActionResult Put()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 删除组织
        /// </summary>
        /// <param name="id">组织Id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 获取该组织下的用户列表
        /// </summary>
        /// <param name="id">组织Id</param>
        /// <param name="searchText">查询关键字</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">每页的大小</param>
        /// <returns></returns>
        [HttpGet("{id}/Users")]
        public IActionResult GetRoleUsers(string id, string searchText, int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }
    }
}
