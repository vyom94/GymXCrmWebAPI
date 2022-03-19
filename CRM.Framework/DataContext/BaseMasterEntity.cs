using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Framework.DataContext
{

   public abstract class BaseMasterEntity : IObjectState
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public Nullable<long> UpdatedBy { get; set; }
        public string UpdatedByName { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }

    public abstract class BaseMasterEntityState : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }
}
