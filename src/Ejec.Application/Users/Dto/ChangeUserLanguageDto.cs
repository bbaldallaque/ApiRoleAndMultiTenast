using System.ComponentModel.DataAnnotations;

namespace Ejec.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}