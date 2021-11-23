using System;
using System.Collections.Generic;

#nullable disable

namespace PenggajianKaryawan.Models
{
    public partial class Pegawai
    {
        public int IdPegawai { get; set; }
        public string Nama { get; set; }
        public string JenisKelamin { get; set; }
        public int? Telepon { get; set; }
        public string Alamat { get; set; }
    }
}
