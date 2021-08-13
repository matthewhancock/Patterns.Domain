using System;

namespace Patterns.Domain.Configuration.Attributes {
    [AttributeUsage(AttributeTargets.Property)]
    public class DomainReferenceAttribute : Attribute {
        public DomainReferenceAttribute(string EntityName, string FieldName)
            => (this.EntityName, this.FieldName) = (EntityName, FieldName);

        public string EntityName { get; }
        public string FieldName { get; }
    }
}
