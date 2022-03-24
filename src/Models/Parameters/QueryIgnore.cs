using System;

namespace Nervestaple.EntityFrameworkCore.Models.Parameters {

    /// <summary>
    /// Provides an attribute that indicates the annotated field should bot be
    /// used as a search parameter.
    /// </summary> 
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class QueryIgnore : Attribute {

    }
}
