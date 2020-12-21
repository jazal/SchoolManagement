using System.ComponentModel.DataAnnotations;

namespace Saho.SchoolManagementSystem.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}