namespace Multitenant.Extensions
{
    public static class HttpContextExtensions
    {
        public static string GetTenantId(this HttpContext httpContext) =>
                    httpContext?.Request.Path.Value.Split('/', System.StringSplitOptions.RemoveEmptyEntries)[0];

    }
}
