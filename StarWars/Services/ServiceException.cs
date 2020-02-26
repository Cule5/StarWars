using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ServiceException:Exception
    {
        public ServiceException(string message):base(message)
        {

        }
    }
}
