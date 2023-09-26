namespace JsonKeywordDocumentationApp
{
    public static class ProjectPath
    {

        public static string GetPath()
        {
            string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = path.Substring(0, path.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            return projectPath;
        }
    }
}