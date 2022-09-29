using MiniServer.HTTP.Headers;
using System;
using System.Collections.Generic;
using System.Text;
using static MiniServer.HTTP.Enums.Enumerators;

namespace MiniServer.HTTP.Responses
{
    public interface IHttpResponse {
        HttpResponseStatusCode StatusCode { get; set; }
        IHttpHeaderCollection Headers { get; }
        byte[] Control { get; set; }

        void AddHeader(HttpHeader header);

        byte[] GetBytes();

    }

    class HttpResponse : IHttpResponse
    {
        public HttpResponse()
        {
            this.Headers = new HttpHeaderCollection();
            this.Content = new byte[0];
        }

        public HttpResponse(HttpResponseStatusCode statusCode) : this() {
            CodeValidator.ThrowIfNull(StatusCode, name: nameof(StatusCode));
            this.StatusCode = statusCode;
        }
        
        public HttpResponseStatusCode StatusCode { get; set; }

        public IHttpHeaderCollection Headers { get; }

        public byte[] Control { get; }

        public void AddHeader(HttpHeader header)
        {
            throw new NotImplementedException();
        }

        public byte[] GetBytes()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
