using Newtonsoft.Json;

namespace Abi_MVC.Models
{
    public class FileResponse
    {
        [JsonProperty("Название тендера")]
        public string Name {  get; set; }
        [JsonProperty("Дата начала")]

        public string StartDate {  get; set; }
        [JsonProperty("Дата окончания")]

        public string EndDate { get; set; }
        [JsonProperty("URL тендерной площадки")]

        public string Url {  get; set; }
    }
}
