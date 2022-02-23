using System.Net;

namespace Caja.API.DTO
{
    public class ResponseDTO
    {
        public HttpStatusCode Code { get; set; }
        public string Message { get; set; }
        public string Data { get; set; }
    }
}
