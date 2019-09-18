using System.Collections.Generic;

namespace Murano.DAL.Interfaces
{
    /// <summary>
    /// Интерфейс запроса к поисковой системе
    /// </summary>
    public interface IRequest
    {
        /// <summary>
        /// Сервис для поиска
        /// </summary>
        string Service { get; set; }

        /// <summary>
        /// Строка запроса
        /// </summary>
        string SearchQuery { get; set; }

        /// <summary>
        /// Параметры запроса
        /// </summary>
        Dictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Заголовки запроса
        /// </summary>
        Dictionary<string, string> Headers { get; set; }
    }
}
