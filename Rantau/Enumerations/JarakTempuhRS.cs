using System.ComponentModel.DataAnnotations;

namespace Rantau.Enumerations
{
    public enum JarakTempuhRS
    {
        [Display(Name = ">2 Jam")]
        Jauh = 1,
        [Display(Name = "<2 Jam")]
        Dekat = 2
    }
}
