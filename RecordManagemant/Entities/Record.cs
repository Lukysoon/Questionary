using RecordManagemant.Models.Enums;
using System;

namespace RecordManagemant.Entities
{
    public class Record
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string? PersonalIdentificationNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Email { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public bool GdprConsent { get; set; }
    }
}
