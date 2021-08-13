using System;

namespace Patterns.Domain.Configuration.Attributes {
    [AttributeUsage(AttributeTargets.Property)]
    public class DomainFieldAttribute : Attribute {
        public DomainFieldAttribute(string FieldName) => this.FieldName = FieldName;

        public string FieldName { get; }
    }
}
