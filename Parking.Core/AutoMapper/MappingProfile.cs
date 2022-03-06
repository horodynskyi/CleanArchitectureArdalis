using System.Reflection;
using System.Runtime.Serialization;
using AutoMapper;
using Parking.SharedKernel.Interfaces;

namespace Parking.Core.AutoMapper;

public class MappingProfile:Profile
{
    
    public MappingProfile(IEnumerable<Assembly> assemblies)
    {
        AllowNullCollections = true;
        foreach (var assembly in assemblies)
        {
            ApplyMappingsFromAssembly(assembly);
        }
    }

    public MappingProfile()
    {
        AllowNullCollections = true;
        ApplyMappingsFromAssembly(Assembly.GetExecutingAssembly());
        ApplyMappingsFromAssembly(Assembly.GetEntryAssembly());
    }

    private void ApplyMappingsFromAssembly(Assembly assembly)
    {
        var typesWithMapFrom = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapFrom<>)))
            .ToList();

        foreach (var type in typesWithMapFrom)
        {
            var instance = FormatterServices.GetUninitializedObject(type);

            var methodInfo = type.GetMethod("Mapping")
                             ?? type.GetInterface("IMapFrom`1")?.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }

        var typesWithMapTo = assembly.GetExportedTypes()
            .Where(t => t.GetInterfaces().Any(i =>
                i.IsGenericType && i.GetGenericTypeDefinition() == typeof(IMapTo<>)))
            .ToList();

        foreach (var type in typesWithMapTo)
        {
            var instance = FormatterServices.GetUninitializedObject(type);

            var methodInfo = type.GetMethod("Mapping")
                             ?? type.GetInterface("IMapTo`1")?.GetMethod("Mapping");

            methodInfo?.Invoke(instance, new object[] { this });
        }
    }
}