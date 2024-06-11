using System;
namespace frameManager.Model.Response
{
    public class Basic<T>
    {
        private string code { get; set; }
        private T data { get; set; }
        private string message { get; set; }

        public Basic(string code, T data, string message)
        {
            this.code = code;
            this.data = data;
            this.message = message;
        }

    }
}

