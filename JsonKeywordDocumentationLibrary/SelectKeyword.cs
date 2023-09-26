using JsonKeywordDocumentationApp;

namespace JsonKeywordDocumentationLibrary
{
    public static class SelectKeyword
    {

        public static string? keywordinfo(string keyword)
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
                case "partial":
                    string partialfileToRead = Path.Combine(projectPath, "KeyWords", "PartialKeywordInfo.json");
                    return partialfileToRead;
                case "readonly":
                    string readonlyfileToRead = Path.Combine(projectPath, "KeyWords", "ReadonlyKeywordInfo.json");
                    return readonlyfileToRead;
                case "sealed":
                    string sealedfileToRead = Path.Combine(projectPath, "KeyWords", "SealedKeywordInfo.json");
                    return sealedfileToRead;
                case "static":
                    string staticfileToRead = Path.Combine(projectPath, "KeyWords", "StaticKeywordInfo.json");
                    return staticfileToRead;
                case "unsafe":
                    string unsafefileToRead = Path.Combine(projectPath, "KeyWords", "UnsafeKeywordInfo.json");
                    return unsafefileToRead;
                case "virtual":
                    string virtualfileToRead = Path.Combine(projectPath, "KeyWords", "VirtualKeywordInfo.json");
                    return virtualfileToRead;
                case "volatile":
                    string volatilefileToRead = Path.Combine(projectPath, "KeyWords", "VolatileKeywordInfo.json");
                    return volatilefileToRead;
                default:
                    return null;
            }
        }
    }
}
