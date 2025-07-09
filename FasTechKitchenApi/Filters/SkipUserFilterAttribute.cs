using Microsoft.AspNetCore.Mvc.Filters;

namespace FastTechKitchen.Api.Filters;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class SkipUserFilterAttribute : Attribute, IFilterMetadata { }
