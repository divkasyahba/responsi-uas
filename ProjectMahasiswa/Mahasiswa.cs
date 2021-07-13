using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    public class Mahasiswa
    {
       

        public string nim;
        public string nama;
        public string jeniskelamin;
        public string ipk;

        
        public Mahasiswa(string nim, string nama, string jeniskelamin, string ipk)
        {
            this.nim = nim;
            this.nama = nama;
            this.jeniskelamin = jeniskelamin;
            this.ipk = ipk;

        }
    }
}