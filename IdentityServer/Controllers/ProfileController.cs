using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    /// <summary>
    /// 提供当前用户相关的接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ApiControllerBase
    {
        /// <summary>
        /// 获取当前用户信息，包含角色以及权限信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Get()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 设置密码
        /// </summary>
        /// <returns></returns>
        [HttpPut(nameof(SetPassword))]
        public IActionResult SetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
