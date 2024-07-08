using System.ComponentModel.DataAnnotations.Schema;

namespace Core.v1.Entities
{
    public class Registration
    {
        public Guid Id { get; set; }
        public required string RegisterName { get; set; }
        public Guid TripId { get; set; }

        [ForeignKey(nameof(TripId))]
        public Trip Trip { get; set; }
    }
}
