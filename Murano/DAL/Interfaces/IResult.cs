using System.Collections.Generic;

namespace Murano.DAL.Interfaces
{
    /// <summary>
    /// Интерфейс результата поиска
    /// </summary>
    public interface IResult<T>
    {
        /// <summary>
        /// Десериализация в объект типа Т
        /// </summary>
        /// <param name="content">Содержимое ответа от запроса</param>
        /// <returns></returns>
        IEnumerable<T> Deserialize(string content);
    }
}