using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Abstract.Return_s
{
    public interface IResult
    {
        string Message { get; set; }
        bool Success { get; set; }

    }
}
