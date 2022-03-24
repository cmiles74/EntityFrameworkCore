using System.Collections.Generic;

namespace Nervestaple.EntityFrameworkCore.Models.Parameters {

    /// <summary>
    /// Provides an interface all page parameters must implement.
    /// </summary>
    public interface IPageParameters {

        /// <summary>
        /// the size of each page of data
        /// </summary>
        int Size { get; set; }

        /// <summary>
        /// the page of data to return
        /// </summary>
        int Page { get; set; }

        /// <summary>
        /// a collection of sort parameters to apply to the returned data
        /// </summary>
        IEnumerable<SortParameter> GetSort();
    }
}