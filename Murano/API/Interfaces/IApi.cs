using Murano.DAL.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Murano.API.Interfaces
{
    /// <summary>
    /// API
    /// </summary>
    public interface IApi<T>
    {
        /// <summary>
        /// Отправить запрос
        /// </summary>
        /// <param name="request">Запрос</param>
        Task<IEnumerable<T>> SendRequestAsync(IRequest request);
    }
}
