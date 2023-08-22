using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EST.Domain.Enum
{
    //Error status code
    public enum StatusCode
    {
        EntityNotFound = 0,
        UserNotFound = 1,
        OK = 200,
        InternalServerError = 500,
    }
}
