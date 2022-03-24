using Nervestaple.EntityFrameworkCore.Models.Entities;

namespace Nervestaple.EntityFrameworkCore.Models.Criteria {

    /// <summary>
    /// Creates a new instance for the given entity type with the provided unique id type.
    /// </summary>
    /// <typeparam name="ENTITY">Type of Entity</typeparam>
    /// <typeparam name="ID">Type of unique identifier for the Entity</typeparam>
    public class ISearchCriteria<ENTITY, ID> 
        where ENTITY : IEntity<ID>
        where ID : struct {
    
    }
}
