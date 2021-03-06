﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Services.Common.Command;
using Services.Identity.Command;

namespace Services.Identity.Handlers.Command
{
    public class SignUpHandler:ICommandHandler<SignUp>
    {
        private readonly IIdentityService _identityService;
        public SignUpHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }
        public async Task HandleAsync(SignUp command)
        {
            await _identityService.SignUpAsync(command.UserId,command.Email,command.Password);
        }
    }
}
