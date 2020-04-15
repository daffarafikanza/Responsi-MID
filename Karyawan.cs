namespace ResponsiPemograman2826
{
    public class Karyawan
    {
        private int NIK { get; set; }
        private string Nama { get; set; }
        private int GajiBulanan { get; set; }

        public Karyawan(int NIK, string Nama, int Gaji)
        {
            this.NIK = NIK;
            this.Nama = Nama;

            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else
            {
                this.GajiBulanan = Gaji;
            }
        }

        public void showKaryawan()
        {
            Console.WriteLine("{0}\t {1}\t {2}", NIK, Nama, GajiBulanan);
        }

        public void naikGaji()
        {
            double tmp = 0;
            tmp = 0.1 * GajiBulanan;
            GajiBulanan += Convert.TOInt32(tmp);
            Console.WriteLine("{0}\t {1}\t {2}", NIK, Nama, GajiBulanan);
        }
    }
}