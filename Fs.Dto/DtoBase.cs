using System;
using System.Collections.Generic;
using System.Text;

namespace Fs.Dto
{
    public class DtoBase
    {
        /// <summary>
        /// Jedes BO wird durch eine eindeutige GUID Oid festgelegt
        /// </summary>
        public virtual Guid? Oid { get; set; }

        /// <summary>
        /// Datum der Erstellung des Datensatzes. Wird für jedes DTO gespeichert.
        /// </summary>
        public virtual DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Datum der Erstellung des Datensatzes. Wird für jedes DTO gespeichert.
        /// </summary>
        public virtual DateTime? UpdatedDate { get; set; }

        /// <summary>
        /// Datum der Erstellung des Datensatzes. Wird für jedes DTO gespeichert.
        /// </summary>
        public virtual DateTime? DeletedDate { get; set; }
    }
}
