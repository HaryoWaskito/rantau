using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rantau.Models
{
    public class InfoRekamMedis
    {
        [Key]
        public int InfoRekamMedisID { get; set; }

        [DisplayName("No Rekam Medis")]
        [RegularExpression("0*[1-9][0-9]*", ErrorMessage = "No Rekam Medis must be number only.")]
        public string NoRekamMedis { get; set; }

        [DisplayName("Tanggal Pemeriksaan")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy HH:mm}")]
        public DateTime TanggalPemeriksaan { get; set; }

        [DisplayName("Berat Badan")]
        public decimal BeratBadan { get; set; }

        [DisplayName("Tinggi Badan")]
        public decimal TinggiBadan { get; set; }

        [DisplayName("Indeks Massa Tubuh")]
        public decimal IndeksMassaTubuh { get; set; }

        [DisplayName("Denyut Nadi")]
        public decimal DenyutNadi { get; set; }

        [DisplayName("Tekanan Darah Sistolik")]
        public int TekananDarahSistolik { get; set; }

        [DisplayName("Tekanan Darah Diastolik")]
        public int TekananDarahDiastolik { get; set; }

        [DisplayName("Saturasi")]
        public decimal Saturasi { get; set; }

        [DisplayName("Jarak Uji Jalan")]
        public decimal JarakUjiJalan { get; set; }

        [DisplayName("Jarak Uji Waktu")]
        public int JarakUjiWaktu { get; set; }

        [DisplayName("VO2 Max")]
        public decimal VO2Max { get; set; }

        public decimal METs { get; set; }

        public string Pemeriksa { get; set; }

        [DisplayName("Dibuat Oleh")]
        public string CreatedBy { get; set; }

        [DisplayName("Tanggal Dibuat")]
        public DateTime CreatedDate { get; set; }
    }
}
