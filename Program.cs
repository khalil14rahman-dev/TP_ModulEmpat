using TP_ModulEmpat;

class Program
{
    static void Main(string[] args)
    {
        KodePos kPos = new KodePos();

        Console.WriteLine("=== OUTPUT TABLE-DRIVEN (KODE POS) ===");

        // Mengakses langsung jumlah baris dari tabel yang ada di class KodePos
        for (int i = 0; i < kPos.tabelKodePos.GetLength(0); i++)
        {
            string kelurahan = kPos.tabelKodePos[i, 0];
            string kode = kPos.getKodePos(kelurahan); // Memanggil method sesuai instruksi 

            Console.WriteLine($"Kelurahan: {kelurahan,-15} | Kode Pos: {kode}");
        }
    }
}