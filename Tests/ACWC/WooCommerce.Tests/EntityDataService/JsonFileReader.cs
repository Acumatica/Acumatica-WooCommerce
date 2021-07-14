using Newtonsoft.Json;
using System;
using System.IO;

namespace ACSC.Tests.EntityDataService
{
    public class JsonFileReader : IFileDataProvider
    {
        public string FilePath { get; set; }

        public T Get<T>()
        {
            try
            {
                var fileData = File.ReadAllText(FilePath);
                return JsonConvert.DeserializeObject<T>(fileData); ;
            }
            catch (Exception e)
            {
                throw new FileNotFoundException($"Error: {nameof(JsonFileReader)}, file: {FilePath}, error: {e}");
            }
        }
    }
}