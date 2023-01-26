using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Abstract.Return_s
{
    public interface IDataResult<T> : IResult
    {
        T Data { get; set; }
    }
}
