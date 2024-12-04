using System.Diagnostics;
using System.Text.Json;

namespace UppgiftKontaktlista.Services
{
    public class FileService
    {
        private readonly string _directoryPath;
        private readonly string _filePath;
        private readonly JsonSerializerOptions _jsonSerializerOptions;

        public FileService(string directoryPath = "Data", string filePath = "list,json")
        {
            _directoryPath = directoryPath;
            _filePath = Path.Combine(directoryPath, filePath);
            _jsonSerializerOptions = new JsonSerializerOptions { WriteIndented = true };

        }

        public void SaveList(List<ContactService> list)
        {
            try
            {
                if (!Directory.Exists(_directoryPath))
                    Directory.CreateDirectory(_directoryPath);

                
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            
        }

        //public List<Contact> ContactList()
        //{

        //}
    }
}