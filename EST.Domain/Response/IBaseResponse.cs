﻿using EST.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EST.Domain.Response
{
    public interface IBaseResponse<T>
    {

        string Description { get; }

        T Data { get; }

        StatusCode StatusCode { get; }
    }
}
