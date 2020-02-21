using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Identity
{
    public interface IIdentityService
    {
        Task SignInAsync();
        Task SignUpAsync();
    }
}
