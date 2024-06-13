namespace Frame_Manager.Model.Response
{
    public class BasicResponse<T>
    {
        private int _statusCode {  get; set; }
        private string _message {  get; set; }
        private T _data { get; set; }

        public BasicResponse(int statusCode, string message, T data)
        {
            _statusCode = statusCode;
            _message = message;
            _data = data;
        }
    }
}
