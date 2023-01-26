using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Utilities.Return_s
{
    public class ErrorDataResult<T> : DataResult<T>
    {

        public ErrorDataResult(T data) : base(false, data)
        {
        }

        public ErrorDataResult(T data, string message) : base(false, data, message)
        {
        }
    }
}
