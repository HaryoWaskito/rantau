using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rantau.Models
{
    public class TemplatPesan
    {
        [Key]
        public int TemplatePesanID{ get; set; }

        [DisplayName("Kode Pesan")]
        public string TemplatePesanCode { get; set; }

        [DisplayName("Deskripsi Pesan")]
        public string TemplatePesanDescription { get; set; }

        [DisplayName("Dibuat Oleh")]
        public string CreatedBy { get; set; }

        [DisplayName("Tanggal Dibuat")]
        public DateTime CreatedDate { get; set; }
    }
}
