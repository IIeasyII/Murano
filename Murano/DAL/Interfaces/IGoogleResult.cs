namespace Murano.DAL.Interfaces
{
    /// <summary>
    /// Интерфейс результата Google поиска
    /// </summary>
    public interface IGoogleResult : IResult<GoogleResult>
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
        /// Отрывок
        /// </summary>
        string Snippet { get; set; }

        /// <summary>
        /// Источник
        /// </summary>
        string Source { get; set; }

        /// <summary>
        /// Запрос
        /// </summary>
        string Query { get; set; }


        int Index { get; set; }
    }
}
