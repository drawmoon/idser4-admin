﻿using IdentityServer.BusinessLogic.Identity.Dtos.Identity.Interfaces;

namespace IdentityServer.BusinessLogic.Identity.Dtos.Identity.Base
{
    public class BaseUserClaimDto<TUserId> : IBaseUserClaimDto
    {
        public int ClaimId { get; set; }

        public TUserId UserId { get; set; }

        object IBaseUserClaimDto.UserId => UserId;
    }
}