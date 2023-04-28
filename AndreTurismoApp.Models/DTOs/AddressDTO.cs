using Newtonsoft.Json;
using System.Security.Principal;
using System.Text.Json.Serialization;

namespace AndreTurismoApp.Models.DTOs
{
    public class AddressDTO
    {       
        public int Id { get; set; }

        [JsonProperty("pais")]
        public string? Country { get; set; }

        [JsonProperty("cep")]
        public string? ZipCode { get; set; }

        [JsonProperty("bairro")]
        public string? Neighbohood { get; set; }

        [JsonProperty("cidade")]
        public City? City { get; set; }

        [JsonProperty("uf")]
        public string? State { get; set; }

        [JsonProperty("logradouro")]
        public string? Street { get; set; }      

        [JsonProperty("complemento")]
        public string? Complement { get; set; }

    }
}
