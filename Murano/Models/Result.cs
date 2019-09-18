namespace Murano.Models
{
    /// <summary>
    /// Результат поиска
    /// </summary>
    public class Result
    {
        /// <summary>
        /// Название
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Ссылка
        /// </summary>
        public string Link { get; set; }

        /// <summary>
        /// Отрывок
        /// </summary>
        public string Snippet { get; set; }
    }
}