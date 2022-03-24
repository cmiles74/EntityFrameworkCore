namespace Nervestaple.EntityFrameworkCore.Models.Entities {

    /// <summary>
    /// Models the data used for creating or updating an Entity.
    /// </summary>
    /// <typeparam name="ENTITY">Type of Entity</typeparam>
    /// <typeparam name="ID">Type of unique identifier for the Entity</typeparam>
    public class EditModel<ENTITY, ID> where ENTITY : Entity<ID> where ID: struct
    {

    }
}