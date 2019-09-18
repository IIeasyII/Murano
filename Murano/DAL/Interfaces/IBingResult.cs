using System;

namespace Murano.DAL.Interfaces
{
    /// <summary>
    /// Интерфейс результата Bing поиска
    /// </summary>
    public interface IBingResult : IResult<BingResult>
    {
        /// <summary>
        /// Название
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// Ссылка
        /// </summary>
        string Link { get; set; }

        /// <summary>
        /// Отображающая ссылка
        /// </summary>
        string DisplayUrl { get; set; }

        /// <summary>
        /// Отрывок
        /// </summary>
        string Snippet { get; set; }
        /// <summary>
        /// 
        /// </summary>
        DateTime DateLastCrawled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        string CachedPageUrl { get; set; }
    }
}
