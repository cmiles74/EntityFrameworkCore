using Nervestaple.EntityFrameworkCore.Models.Criteria;
using Nervestaple.EntityFrameworkCore.Models.Entities;

namespace Nervestaple.EntityFrameworkCore.Models.Parameters {

    /// <summary>
    /// Provides an interface all search parameters must implement.
    /// </summary>
    /// <typeparam name="ENTITY">Type of Entity</typeparam>
    /// <typeparam name="ID">Type of unique identifier for the Entity</typeparam>
    public interface ISearchParameters<ENTITY, ID> 
        where ENTITY : IEntity<ID>
        where ID : struct {

        /// <summary>
        /// Search criteria specific to this instance type.
        /// </summary>
        ISearchCriteria<ENTITY, ID> SearchCriteria { get; }

        /// <summary>
        /// Search parameters should include page parameters.
        /// </summary>
        [QueryIgnore]
        PageParameters PageParameters { get; set; }
    }
}