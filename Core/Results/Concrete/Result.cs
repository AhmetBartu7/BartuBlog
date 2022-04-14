using Core.Results.Abstract;
using Core.Results.ComplexType;
using System;

namespace Core.Results.Concrete
{
    public class Result : IResult
    {
        public ResultStatus ResultStatus { get; }

        public string Message { get; }

        public Exception Exception { get; }
        public Result(ResultStatus result, string message, Exception exception = null)
        {
            ResultStatus = result;
            Message = message;
            Exception = exception;
        }
    }
}
