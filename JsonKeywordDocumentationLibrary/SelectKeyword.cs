using JsonKeywordDocumentationApp;
using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace JsonKeywordDocumentationLibrary
{
    public static class SelectKeyword
    {

        public static string keywordinfo(string keyword)
        {
            string projectPath = ProjectPath.GetPath();


            switch (keyword.ToLower())
            {
                case "abstract":
                    string abstractfileToRead = Path.Combine( projectPath,"KeyWords","AbstractKeywordInfo.json");
                    return abstractfileToRead;
                case "async":
                    string asyncfileToRead = Path.Combine( projectPath,"KeyWords","AsyncKeywordInfo.json");
                    return asyncfileToRead;
                case "const":
                    string constfileToRead = Path.Combine(projectPath,"KeyWords","ConstKeywordInfo.json");
                    return constfileToRead;
                case "event":
                    string eventfileToRead = Path.Combine(projectPath,"KeyWords","EventKeywordInfo.json");
                    return eventfileToRead;
                case "extern":
                    string externfileToRead = Path.Combine(projectPath,"KeyWords","ExternKeywordInfo.json");
                    return externfileToRead;
                case "new":
                    string newfileToRead = Path.Combine(projectPath, "KeyWords", "NewKeywordInfo.json");
                    return newfileToRead;
                case "override":
                    string overridefileToRead = Path.Combine(projectPath, "KeyWords", "OverrideKeywordInfo.json");
                    return overridefileToRead;
                default:
                    return "no content";
            }
        }
        public static void WriteKeywordContent(HttpContext context, string v)
        {
            var filecontent = System.IO.File.ReadAllText(keywordinfo(v));
            context.Response.WriteAsync(filecontent);
        }
    }
}
