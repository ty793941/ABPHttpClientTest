using System.ComponentModel.DataAnnotations;

namespace ABPTest.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}