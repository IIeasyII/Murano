using Murano.DAL.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Murano.DAL
{
    /// <summary>
    /// Результат Bing поиска
    /// </summary>
    public class BingResult : IBingResult
    {
        /// <summary>
        /// Название
        /// </summary>
        [Display(Name = "Name")]
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Ссылка
        /// </summary>
        /// <remarks>
        /// Url должен быть
        /// </remarks>
        [Display(Name = "Link")]
        [JsonProperty(PropertyName = "url")]
        public string Link { get; set; }

        /// <summary>
        /// Отображающая ссылка
        /// </summary>
        [JsonProperty(PropertyName = "displayUrl")]
        public string DisplayUrl { get; set; }

        /// <summary>
        /// Отрывок
        /// </summary>
        [Display(Name = "Snippet")]
        [JsonProperty(PropertyName = "snippet")]
        public string Snippet { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "dateLastCrawled")]
        public DateTime DateLastCrawled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty(PropertyName = "cachedPageUrl")]
        public string CachedPageUrl { get; set; }

        /// <summary>
        /// Десериализация в объект типа <seealso cref="BingResult"/>
        /// </summary>
        /// <param name="content">Содержимое ответа от запроса</param>
        /// <returns></returns>
        public IEnumerable<BingResult> Deserialize(string content)
        {
            var results = JsonConvert.DeserializeObject<BingCustomSearchResponse>(content);

            return results.WebPages.Value;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    public class BingCustomSearchResponse
    {
        /// <summary>
        /// Тип
        /// </summary>
        [JsonProperty(PropertyName = "_type")]
        public string Type { get; set; }

        /// <summary>
        /// Веб-страницы
        /// </summary>
        [JsonProperty(PropertyName = "webPages")]
        public WebPages WebPages { get; set; }
    }

    /// <summary>
    /// Веб-страницы
    /// </summary>
    public class WebPages
    {
        /// <summary>
        /// Url веб-поиска
        /// </summary>
        [JsonProperty(PropertyName = "webSearchUrl")]
        public string WebSearchUrl { get; set; }

        /// <summary>
        /// Всего ответов
        /// </summary>
        [JsonProperty(PropertyName = "totalEstimatedMatches")]
        public int TotalEstimatedMatches { get; set; }

        /// <summary>
        /// Значение
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public BingResult[] Value { get; set; }
    }
}