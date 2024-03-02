﻿namespace STARAS.BusinessLayer.Utilities.ErrorResponse
{
    public class ErrorResponse : Exception
    {
        public ErrorResponse() { }

        public ErrorDetailResponse Error { get; private set; }

        public ErrorResponse(int statusCode, int errorCode, string message)
        {
            this.Error = new ErrorDetailResponse
            {
                StatusCode = statusCode,
                ErrorCode = errorCode,
                Message = message
            };
        }
    }

    public class ErrorDetailResponse
    {
        public int StatusCode { get; set; }
        public int ErrorCode { get; set; }
        public string? Message { get; set; }
    }
}