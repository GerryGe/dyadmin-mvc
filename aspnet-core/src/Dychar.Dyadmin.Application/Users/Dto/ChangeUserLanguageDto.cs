using System.ComponentModel.DataAnnotations;

namespace Dychar.Dyadmin.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}