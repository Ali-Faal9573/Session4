using JsonKeywordDocumentationApp;
using Newtonsoft.Json;

namespace JsonKeywordDocumentationLibrary
{
    public class ReadAndConvertFile
    {
        string Path { get; set; }
        public ReadAndConvertFile(string path)
        {
            this.Path = path;
        }

        public keywordmodel convert()
        {
            var filecontent = System.IO.File.ReadAllText($"{Path}");
            var jsonobject = JsonConvert.DeserializeObject<keywordmodel>(filecontent);

            return jsonobject;
        }
    }
}
