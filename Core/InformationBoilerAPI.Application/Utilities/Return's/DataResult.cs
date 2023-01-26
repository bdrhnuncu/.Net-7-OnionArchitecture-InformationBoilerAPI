using InformationBoilerAPI.Application.Abstract.Return_s;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationBoilerAPI.Application.Utilities.Return_s
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
        public DataResult(bool success, T data, string message) : this(success, data)
        {
            Message = message;
        }
        public DataResult(bool success, T data) 
        {
            Data= data;
            Success = success;
        }

    }
}
