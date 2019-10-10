using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Mediator.Colleagues;

namespace Mediator.Mediators
{
    public class CqrsMediator : IMediator
    {
        public Task BroadcastAsync<T>(IPayload<T> payload)
        {
            throw new NotImplementedException();
        }

        public Task<T> SendAsync<T>(IPayload<T> payload)
        {
            throw new NotImplementedException();
        }
    }
}
