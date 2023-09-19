using Core.Utilities.Results.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results.Concrete
{
    public class DataResult<T>:Result, IDataResult<T>
    {
        public DataResult(T data, bool isSuccess, string message) : base(isSuccess, message)
        {
            Data = data;
        }
        public DataResult(T data, bool isSuccess) : base(isSuccess)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
