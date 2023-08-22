using EST.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EST.Domain.Response
{
    public class BaseResponse<T> : IBaseResponse<T>
    {
        // Свойство ловит название ошибки
        public string Description { get; set; }

        // Свойство ловит код ошибки
        public StatusCode StatusCode { get; set; }

        // Свойство - результат запроса
        public T Data { get; set; }
    }
}
