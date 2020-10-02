using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace UrlFormatter.Requests
{
    public class UrlFormatterRequest : IRequest<string>
    {
        public string OriginalUrl { get; set; }
    }

    public class UrlFormatterRequestHandler : IRequestHandler<UrlFormatterRequest, string>
    {
        public Task<string> Handle(UrlFormatterRequest request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
