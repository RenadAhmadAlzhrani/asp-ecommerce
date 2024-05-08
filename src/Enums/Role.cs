using System.Text.Json.Serialization;

namespace CodeCrafters_backend_teamwork.src.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
    public enum Role
    {
        Customer, 
        Admin, 
    }
