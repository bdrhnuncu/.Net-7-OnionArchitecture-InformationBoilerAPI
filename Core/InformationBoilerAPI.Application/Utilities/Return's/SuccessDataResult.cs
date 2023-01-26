using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Utilities.Return_s
{
    public class SuccessDataResult<T> : DataResult<T>
    {

        public SuccessDataResult(T data) : base(true, data)
        {
        }

        public SuccessDataResult(T data, string message) : base(true, data, message)
        {
        }
    }
}
