using System;
using System.Collections.Generic;
using System.Text;

namespace CRM.Models.Interface
{
   public interface IEntity
    {
        int Id { get; set; }
        DateTime CreatedAt { get; set; }
        int CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        int UpdatedBy { get; set; }
        bool Active { get; set; }
        bool Deleted { get; set; }
    }
    public interface IEntityBase
    {
        DateTime CreatedAt { get; set; }
        int CreatedBy { get; set; }
        DateTime? UpdatedAt { get; set; }
        int UpdatedBy { get; set; }
        bool Active { get; set; }
        bool Deleted { get; set; }
    }
}
