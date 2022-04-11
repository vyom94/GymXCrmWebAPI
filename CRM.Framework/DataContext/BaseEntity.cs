using CRM.Models.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CRM.Framework.DataContext
{
    public abstract class BaseEntity : IObjectState, IEntity
    {
        public int Id { get; set; }
        public bool Active { get; set; }
        public bool Deleted { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedByName { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<System.DateTime> UpdatedAt { get; set; }
        public int UpdatedBy { get; set; }
        public string UpdatedByName { get; set; }

        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }

    public abstract class BaseEntityState : IObjectState
    {
        [NotMapped]
        public ObjectState ObjectState { get; set; }
    }


}
