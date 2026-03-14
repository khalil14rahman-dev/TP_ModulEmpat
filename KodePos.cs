using System;
using System.Collections.Generic;
using System.Text;

namespace TP_ModulEmpat
{
    public class KodePos
    {
        // Menggunakan array atau dictionary untuk menyimpan data tabel 
        public string[,] tabelKodePos = {
        { "Batununggal", "40266" }, { "Kujangsari", "40287" }, { "Mengger", "40267" },
        { "Wates", "40256" }, { "Cijaura", "40287" }, { "Jatisari", "40286" },
        { "Margasari", "40286" }, { "Sekejati", "40286" }, { "Kebonwaru", "40272" },
        { "Maleer", "40274" }, { "Samoja", "40273" }
        };

        public string getKodePos(string kelurahan)
        {
            for (int i = 0; i < tabelKodePos.GetLength(0); i++)
            {
                if (tabelKodePos[i, 0] == kelurahan)
                {
                    return tabelKodePos[i, 1];
                }
            }
            return "Kode pos tidak ditemukan";
        }
    }
}
