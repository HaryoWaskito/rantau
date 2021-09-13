using Microsoft.AspNetCore.Mvc.Rendering;
using Rantau.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace Rantau.ViewModels
{
    public class HistoriPesanVM
    {
        public HistoriPesan historiPesan { get; set; }

        [DisplayName("Daftar Templat")]
        public List<SelectListItem> templatPesanList { get; set; }
    }
}
