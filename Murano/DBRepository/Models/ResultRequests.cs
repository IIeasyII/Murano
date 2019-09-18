using Murano.DBRepository.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Murano.DBRepository.Models
{
    /// <summary>
    /// Результаты запросов
    /// </summary>
    public class ResultRequests : BaseEntity
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