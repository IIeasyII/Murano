using Murano.DAL.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Murano.DAL
{
    public class GoogleResult : IGoogleResult
    {
        /// <summary>
        /// Название
        /// </summary>
        /// <remarks>
        /// Title д.б.
        /// </remarks>
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// Ссылка
        /// </summary>
        [Display(Name = "Link")]
        public string Link { get; set; }

        /// <summary>
        /// Отрывок
        /// </summary>
        [Display(Name = "Snippet")]
        public string Snippet { get; set; }

        /// <summary>
        /// Источник
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Запрос
        /// </summary>
        public string Query { get; set; }


        public int Index { get; set; }

        IEnumerable<GoogleResult> IResult<GoogleResult>.Deserialize(string content)
        {
            dynamic jsonData = JsonConvert.DeserializeObject(content);

            var results = new List<GoogleResult>();

            foreach (var item in jsonData.items)
            {
                results.Add(new GoogleResult
                {
                    Name = item.title,
                    Link = item.link,
                    Snippet = item.snippet
                });
            }

            return results;
        }
    }
}