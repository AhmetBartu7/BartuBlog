using Core.Results.Abstract;
using Core.Results.ComplexType;
using System;

namespace Core.Results.Concrete
{
    public class DataResult<T> : IDataResult<T>
    {
        public T Data { get; }

        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }

        public DataResult(T data, ResultStatus status, string message, Exception exception = null)
        {
            Data = data;
            ResultStatus = status;
            Message = message;
            Exception = exception;

        }
    }
}
