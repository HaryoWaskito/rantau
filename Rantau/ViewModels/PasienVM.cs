using Rantau.Models;
using System.Collections.Generic;

namespace Rantau.ViewModels
{
    public class PasienVM
    {
        public Pasien pasien { get; set; }
        public List<Pasien> pasienList { get; set; }
        public HistoriPesan historiPesan { get; set; }
    }
}
