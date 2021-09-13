using System.ComponentModel.DataAnnotations;

namespace Rantau.Enumerations
{
    public enum StatusPernikahan
    {
        [Display(Name = "Sendiri")]
        Sendiri = 1,
        [Display(Name = "Dengan Pasangan")]
        Pasangan = 2
    }
}
