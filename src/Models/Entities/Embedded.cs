using System;

namespace Nervestaple.EntityFrameworkCore.Models.Entities {

    /// <summary>
    /// Provides an attribute that indicates the annotated field should be
    /// embedded in the payload, if possible (i.e. a HAL resource).
    /// </summary> 
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    public class Embedded : Attribute {

    }
}
