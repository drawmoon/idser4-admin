using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using IdentityServer.BusinessLogic.Identity.Dtos.Identity;
using IdentityServer.BusinessLogic.Identity.Services.Interfaces;
using IdentityServer.Configuration.Constants;
using IdentityServer.ExceptionHandling;
using IdentityServer.Helpers.Localization;
using IdentityServer.Resources;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityServer.Controllers
{
    /// <summary>
    /// 提供角色相关的接口
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ControllerExceptionFilterAttribute))]
    [Produces("application/json", "application/problem+json")]
    [Authorize(Policy = AuthorizationConsts.AdministrationPolicy)]
    public class RolesController<TUserDto, TUserDtoKey, TRoleDto, TRoleDtoKey, TUserKey, TRoleKey, TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken,
            TUsersDto, TRolesDto, TUserRolesDto, TUserClaimsDto,
            TUserProviderDto, TUserProvidersDto, TUserChangePasswordDto, TRoleClaimsDto> : ControllerBase
        where TUserDto : UserDto<TUserDtoKey>, new()
        where TRoleDto : RoleDto<TRoleDtoKey>, new()
        where TUser : IdentityUser<TKey>
        where TRole : IdentityRole<TKey>
        where TKey : IEquatable<TKey>
        where TUserClaim : IdentityUserClaim<TKey>
        where TUserRole : IdentityUserRole<TKey>
        where TUserLogin : IdentityUserLogin<TKey>
        where TRoleClaim : IdentityRoleClaim<TKey>
        where TUserToken : IdentityUserToken<TKey>
        where TRoleDtoKey : IEquatable<TRoleDtoKey>
        where TUserDtoKey : IEquatable<TUserDtoKey>
        where TUsersDto : UsersDto<TUserDto, TUserDtoKey>
        where TRolesDto : RolesDto<TRoleDto, TRoleDtoKey>
        where TUserRolesDto : UserRolesDto<TRoleDto, TUserDtoKey, TRoleDtoKey>
        where TUserClaimsDto : UserClaimsDto<TUserDtoKey>, new()
        where TUserProviderDto : UserProviderDto<TUserDtoKey>
        where TUserProvidersDto : UserProvidersDto<TUserDtoKey>
        where TUserChangePasswordDto : UserChangePasswordDto<TUserDtoKey>
        where TRoleClaimsDto : RoleClaimsDto<TRoleDtoKey>, new()
    {
        private readonly IIdentityService<TUserDto, TUserDtoKey, TRoleDto, TRoleDtoKey, TUserKey, TRoleKey, TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken,
            TUsersDto, TRolesDto, TUserRolesDto, TUserClaimsDto,
            TUserProviderDto, TUserProvidersDto, TUserChangePasswordDto, TRoleClaimsDto> _identityService;
        private readonly IGenericControllerLocalizer<UsersController<TUserDto, TUserDtoKey, TRoleDto, TRoleDtoKey, TUserKey, TRoleKey, TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken,
            TUsersDto, TRolesDto, TUserRolesDto, TUserClaimsDto,
            TUserProviderDto, TUserProvidersDto, TUserChangePasswordDto, TRoleClaimsDto>> _localizer;

        private readonly IMapper _mapper;
        private readonly IApiErrorResources _errorResources;

        public RolesController(IIdentityService<TUserDto, TUserDtoKey, TRoleDto, TRoleDtoKey, TUserKey, TRoleKey, TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken,
                TUsersDto, TRolesDto, TUserRolesDto, TUserClaimsDto,
                TUserProviderDto, TUserProvidersDto, TUserChangePasswordDto, TRoleClaimsDto> identityService,
            IGenericControllerLocalizer<UsersController<TUserDto, TUserDtoKey, TRoleDto, TRoleDtoKey, TUserKey, TRoleKey, TUser, TRole, TKey, TUserClaim, TUserRole, TUserLogin, TRoleClaim, TUserToken,
                TUsersDto, TRolesDto, TUserRolesDto, TUserClaimsDto,
                TUserProviderDto, TUserProvidersDto, TUserChangePasswordDto, TRoleClaimsDto>> localizer, IMapper mapper, IApiErrorResources errorResources)
        {
            _identityService = identityService;
            _localizer = localizer;
            _mapper = mapper;
            _errorResources = errorResources;
        }
        
        /// <summary>
        /// 获取角色
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TRoleDto>> Get(TUserDtoKey id)
        {
            var role = await _identityService.GetRoleAsync(id.ToString());

            return Ok(role);
        }

        /// <summary>
        /// 获取角色列表
        /// </summary>
        /// <param name="searchText">查询关键字</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">每页的大小</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<TRolesDto>> Get(string searchText, int page = 1, int pageSize = 10)
        {
            var rolesDto = await _identityService.GetRolesAsync(searchText, page, pageSize);

            return Ok(rolesDto);
        }

        /// <summary>
        /// 添加角色
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(201)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<TRoleDto>> Post([FromBody]TRoleDto role)
        {
            if (!EqualityComparer<TRoleDtoKey>.Default.Equals(role.Id, default))
            {
                return BadRequest(_errorResources.CannotSetId());
            }
 
            var (identityResult, roleId) = await _identityService.CreateRoleAsync(role);
            var createdRole = await _identityService.GetRoleAsync(roleId.ToString());

            return CreatedAtAction(nameof(Get), new { id = createdRole.Id }, createdRole);
        }

        /// <summary>
        /// 修改角色
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]TRoleDto role)
        {
            await _identityService.GetRoleAsync(role.Id.ToString());
            await _identityService.UpdateRoleAsync(role);

            return Ok();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(TRoleDtoKey id)
        {
            var roleDto = new TRoleDto { Id = id };

            await _identityService.GetRoleAsync(id.ToString());
            await _identityService.DeleteRoleAsync(roleDto);

            return Ok();
        }

        /// <summary>
        /// 获取该角色下的用户列表
        /// </summary>
        /// <param name="id">角色Id</param>
        /// <param name="searchText">查询关键字</param>
        /// <param name="page">页码</param>
        /// <param name="pageSize">每页的大小</param>
        /// <returns></returns>
        [HttpGet("{id}/Users")]
        public async Task<ActionResult<TRolesDto>> GetRoleUsers(string id, string searchText, int page = 1, int pageSize = 10)
        {
            var usersDto = await _identityService.GetRoleUsersAsync(id, searchText, page, pageSize);

            return Ok(usersDto);
        }
    }
}
