using Rantau.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Rantau.Models
{
    public class Pasien
    {
        [Key]
        public int PasienID { get; set; }

        [Required]
        [DisplayName("No Rekam Medis")]
        [RegularExpression("0*[1-9][0-9]*", ErrorMessage = "No Rekam Medis must be number only.")]
        public string NoRekamMedis { get; set; }

        [Required]
        [DisplayName("Nama Depan")]
        public string NamaDepan { get; set; }

        [DisplayName("Nama Belakang")]
        public string NamaBelakang { get; set; }

        [Required]
        [DisplayName("Tanggal Lahir")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime TanggalLahir { get; set; }

        [DisplayName("Jenis Kelamin")]
        public JenisKelamin JenisKelamin { get; set; }

        [Required]
        [DisplayName("Alamat")]
        public string Alamat { get; set; }

        [Required]
        [DisplayName("No Telepon Utama")]
        [MaxLength(13)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("([0][0-9]+)", ErrorMessage = "Format tidak valid")]
        public string NoTeleponUtama { get; set; }

        [DisplayName("No Telepon Alternatif")]
        [MaxLength(13)]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression("([0][0-9]+)", ErrorMessage = "Format tidak valid")]
        public string NoTeleponAlternatif { get; set; }

        [DisplayName("Jenis Pembayaran")]
        public JenisPembayaran JenisPembayaran { get; set; }

        [DisplayName("Status Pernikahan")]
        public StatusPernikahan StatusPernikahan { get; set; }

        [DisplayName("Tingkat Pendidikan")]
        public TingkatPendidikan TingkatPendidikan { get; set; }

        [DisplayName("Riwayat Merorok")]
        public RiwayatMerokok RiwayatMerokok { get; set; }

        [Required]
        [DisplayName("Waktu Tempuh ke RS")]
        public JarakTempuhRS WaktuTempuhRS { get; set; }

        public string Pemeriksa { get; set; }

        [DisplayName("Dibuat Oleh")]
        public string CreatedBy { get; set; }

        [DisplayName("Tanggal Dibuat")]
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<InfoRekamMedis> InfoRekamMedis { get; set; }
    }
}
