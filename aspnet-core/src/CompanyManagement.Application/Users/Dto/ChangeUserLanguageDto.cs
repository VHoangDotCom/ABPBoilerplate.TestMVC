using System.ComponentModel.DataAnnotations;

namespace CompanyManagement.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}