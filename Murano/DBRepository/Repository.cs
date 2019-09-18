using Murano.DBRepository.Models;
using Murano.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Murano.DBRepository
{
    /// <summary>
    /// Репозиторий
    /// </summary>
    public class Repository
    {
        MuranoContext context;

        public Repository()
        {
            context = new MuranoContext();
        }

        /// <summary>
        /// Сохранить сущность
        /// </summary>
        /// <param name="entity">Сущность</param>
        public void Save(dynamic entityes)
        {
            if (entityes.Result == null)
            {
                return;
            }

            foreach (var entity in entityes.Result)
            {
                context.ResultRequests.Add(new ResultRequests
                {
                    Name = entity.Name,
                    Link = entity.Link,
                    Snippet = entity.Snippet
                });
            }

            context.SaveChangesAsync();
        }

        public dynamic Find(string searchTerm)
        {
            return context.ResultRequests.Where(i => i.Snippet.Contains(searchTerm)).ToList();
        }
    }
}