﻿using System.ComponentModel.DataAnnotations;

namespace IdentityServer.Dtos.Users
{
    public class UserClaimApiDto<TUserDtoKey>
    {
        public int ClaimId { get; set; }

        public TUserDtoKey UserId { get; set; }

        [Required]
        public string ClaimType { get; set; }

        [Required]
        public string ClaimValue { get; set; }
    }
}