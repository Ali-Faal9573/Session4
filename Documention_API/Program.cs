using JsonKeywordDocumentationLibrary;

namespace Documention_API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddAuthorization();


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapGet("/",(HttpContext context) =>
            {
                context.Response.WriteAsync(ShowRoutes.routes());
            });

            app.MapGet("/abstract",(HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context, "abstract");

            });
            app.MapGet("/async", (HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context,"async");

            });
            app.MapGet("/const", (HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context, "const");

            });
            app.MapGet("/event", (HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context, "event");

            });
            app.MapGet("/extern", (HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context, "extern");

            });
            app.MapGet("/new", (HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context, "new");

            });
            app.MapGet("/override", (HttpContext context) =>
            {
                SelectKeyword.WriteKeywordContent(context, "override");

            });

            app.Run();
        }

    }
}