using System.ComponentModel.DataAnnotations;

namespace Rantau.Enumerations
{
    public enum JenisKelamin
    {
        [Display(Name = "Laki-laki")]
        Pria = 1,
        [Display(Name = "Perempuan")]
        Wanita = 2
    }
}
