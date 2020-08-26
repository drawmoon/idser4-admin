using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    /// <summary>
    /// 提供账号相关的接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        /// <summary>
        /// 登入
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(Login))]
        [AllowAnonymous]
        public IActionResult Login()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 登出
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(Logout))]
        public IActionResult Logout()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 忘记密码
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(ForgotPassword))]
        public IActionResult ForgotPassword()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 重置密码
        /// </summary>
        /// <returns></returns>
        [HttpPost(nameof(ResetPassword))]
        public IActionResult ResetPassword()
        {
            throw new NotImplementedException();
        }
    }
}
