using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Model.Entities.Base
{
    [Serializable]
    public abstract class BaseEntity<T> : BaseEntity
    {
        [Column(Order = 0)]
        public T Id { get; set; }
    }

    [Serializable]
    public abstract class BaseEntity
    {
        public bool IsDeleted { get; set; }        
    }
}
