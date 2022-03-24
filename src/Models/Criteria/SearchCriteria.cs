
using Nervestaple.EntityFrameworkCore.Models.Entities;

namespace Nervestaple.EntityFrameworkCore.Models.Criteria {

    /// <summary>
    /// Provides a data object modeling a set of search criteria for instances.
    /// </summary>
    /// <typeparam name="ENTITY">Type of Entity</typeparam>
    /// <typeparam name="ID">Type of unique identifier for the Entity</typeparam>
    public abstract class SearchCriteria<ENTITY, ID> : ISearchCriteria<ENTITY, ID> 
        where ENTITY : IEntity<ID> 
        where ID : struct {

        /// <summary>
        /// The unique identifier for the instance.
        /// </summary>
        public ID? Id { get; set; }
    }
}