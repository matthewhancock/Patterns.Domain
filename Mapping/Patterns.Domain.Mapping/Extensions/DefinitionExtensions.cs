using System;
using System.Reflection.Metadata;
using System.Reflection;

namespace Patterns.Domain.Mapping.Extensions {
    internal static class DefinitionExtensions {
        public static EntityDefinition GetEntityDefinition(this Type DomainEntityType)
            => typeof(IDomainEntity).IsAssignableFrom(DomainEntityType)
                ? DomainEntityType.GetCustomAttribute<EntityDefinitionAttribute>()?.Definition
                : null;
        public static EntityDefinition GetEntityDefinition<T>() where T : IDomainEntity
            => typeof(T).GetCustomAttribute<EntityDefinitionAttribute>()?.Definition;

        public static FieldDefinition GetFieldDefinition(this PropertyInfo Property)
            => Property.GetCustomAttribute<FieldDefinitionAttribute>()?.Definition;

        public static ReferenceDefinition GetReferenceDefinition(this PropertyInfo Property)
            => Property.GetCustomAttribute<ReferenceDefinitionAttribute>()?.Definition;
    }
}
