using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MovieDBApp.Services
{
    interface IHttpRequest
    {
        Task<TResult> GetAsync<TResult>(string uri);
    }
}
