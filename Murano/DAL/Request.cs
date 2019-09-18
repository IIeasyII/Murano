using Murano.DAL.Interfaces;
using System.Collections.Generic;

namespace Murano.DAL
{
    /// <summary>
    /// Запрос к поисковой системе
    /// </summary>
    public class Request : IRequest
    {
        /// <summary>
        /// Сервис для поиска
        /// </summary>
        public string Service { get; set; }

        /// <summary>
        /// Строка запроса
        /// </summary>
        public string SearchQuery { get; set; }

        /// <summary>
        /// Параметры запроса
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Заголовки запроса
        /// </summary>
        public Dictionary<string, string> Headers { get; set; }
    }
}