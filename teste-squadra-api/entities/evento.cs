using System;

namespace teste_squadra_api.entities
{
    public class evento
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; } = DateTime.Now

        public decimal Price {get; set; }

        public string FirstName { get; set; } = string.empty

        public string Suburb { get; set; } = string.empty

        public string Category { get; set; } = string.empty

        public string Description { get; set; } = string.empty
    }
}
