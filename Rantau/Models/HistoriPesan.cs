using Rantau.Enumerations;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rantau.Models
{
    public class HistoriPesan
    {
        [Key]
        public int HistoriPesanID { get; set; }

        [DisplayName("Sumber Pesan")]
        public SumberHistoriPesan SumberPesan { get; set; }

        [DisplayName("No Telepon")]
        public string NoTelepon { get; set; }

        [DisplayName("Nama Sapaan")]
        public string NamaSapaan { get; set; }

        [DisplayName("Nama Pasien")]
        public string NamaPasien { get; set; }

        [DisplayName("Jarak Anjuran")]
        public string JarakAnjuran { get; set; }

        [DisplayName("Isi Pesan")]
        public string IsiPesan { get; set; }

        [DisplayName("Diinput oleh")]
        public string CreatedBy { get; set; }

        [DisplayName("Tanggal Input")]
        public DateTime CreatedDate { get; set; }
    }
}
