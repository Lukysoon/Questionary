using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecordManagemant.Models.Enums;
using RecordManagemant.Validation.CustomAttributes;

namespace RecordManagemant.Models.Dto;

public class RecordDto
{
    [Required]
    public string FirstName { get; set; } = null!;
    [Required]
    public string LastName { get; set; } = null!;

    public bool DontHavePin { get; set; }
    [RequiredIf("DontHavePin", false)]
    [RegularExpression(@"^\d{2}(0[1-9]|1[0-2])(0[1-9]|[12]\d|3[01])\/?\d{3,4}$")]
    public string? PersonalIdentificationNumber { get; set; }
    [Required]
    public DateTime DateOfBirth { get; set; }
    [Required]
    public Gender Gender { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; } = null!;
    public List<SelectListItem> NationalityList { get; set; } = new List<SelectListItem>();
    [Required]
    public string Nationality { get; set; } = null!;
    [Range(typeof(bool), "true", "true", ErrorMessage="You have to agree.")]
    public bool GdprConsent { get; set; }

}
