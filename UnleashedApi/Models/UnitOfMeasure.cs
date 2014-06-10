using System;

namespace UnleashedApi.Models
{
    public class UnitOfMeasure : IKey
    {
        public Guid Guid { get; set; }
        public string Name { get; set; }
    }
}
