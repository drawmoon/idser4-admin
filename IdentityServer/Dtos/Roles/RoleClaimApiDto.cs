﻿using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Dtos.Roles
{
    public class RoleClaimApiDto<TRoleDtoKey>
    {
        public int ClaimId { get; set; }

        public TRoleDtoKey RoleId { get; set; }

        [Required]
        public string ClaimType { get; set; }


        [Required]
        public string ClaimValue { get; set; }
    }
}