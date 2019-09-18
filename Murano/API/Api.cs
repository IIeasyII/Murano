using Murano.API.Interfaces;
using Murano.DAL;
using Murano.DAL.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace Murano.API
{
    /// <summary>
    /// API
    /// </summary>
    public class Api<T> : IApi<T> where T : IResult<T>
    {
        public async Task<IEnumerable<T>> SendRequestAsync(IRequest request)
        {
            var url = request.Service + "?";

            foreach (var pr in request.Parameters)
            {
                url += pr.Key + "=" + pr.Value + "&";
            }

            url = url.Remove(url.Length - 1);

            var client = new HttpClient();

            if (request.Headers != null)
            {
                foreach (var header in request.Headers)
                {
                    client.DefaultRequestHeaders.Add(header.Key, header.Value);
                }
            }

            var httpResponseMessage = client.GetAsync(url).Result;
            var responseContent = await httpResponseMessage.Content.ReadAsStringAsync();

            var type = typeof(T);
            var @object = (T)Activator.CreateInstance(type);

            var response = @object.Deserialize(responseContent);

            return response;
        }
    }
}