using Data.Services;
using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Business.Models
{
    public class FileService
    {
        private readonly string _directoryPath;
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public FileService(string directoryPath = "Data", string fileName = "list,json")
        {
            _directoryPath = directoryPath;
            _filePath = Path.Combine(directoryPath, fileName);
            _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };

        }

        public void SaveList<T>(List<T> list)
        {
            try
            {
                if (!Directory.Exists(_directoryPath))
                    Directory.CreateDirectory(_directoryPath);

                //var json = JsonConvert.SerializeObject(list);
                //File.WriteAllText(_filePath, json);

                var json = JsonSerializer.Serialize(list, _jsonSerializerOptions);
                File.WriteAllText(_filePath, json);


            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }

        }

        public List<T> LoadList<T>()
        {
            try
            {
                if (!File.Exists(_filePath))
                    return []; 

                var json = File.ReadAllText(_filePath);
                var list = JsonSerializer.Deserialize<List<T>>(json, _jsonSerializerOptions);
                return list ?? [];
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                return [];
            }

        }

        public void PopulateContactsFromFiles()
        {

        }


        //public List<Contact> ContactList()
        //{

        //}
    }
}