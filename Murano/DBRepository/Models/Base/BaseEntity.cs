using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Murano.DBRepository.Models.Base
{
    /// <summary>
    /// Базовый класс сущности
    /// </summary>
    public abstract class BaseEntity
    {
        /// <summary>
        /// Идентификатор сущности
        /// </summary>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}