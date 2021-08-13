using System;

namespace Patterns.Domain.Configuration.Attributes {
    [AttributeUsage(AttributeTargets.Class)]
    public class DomainEntityAttribute : Attribute {
        public DomainEntityAttribute(string EntityName) => this.EntityName = EntityName;

        public string EntityName { get; private set; }
    }
}
