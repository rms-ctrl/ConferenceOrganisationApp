namespace NAUJAS_TINKLAI_ITPROJ.Models
{
    public class Konferencija
    {
        public string Pavadinimas { get; set; }
        public DateTime Data { get; set; }
        public int Trukmė { get; set; }
        public double Kaina { get; set; }
        public string Aprasymas { get; set; }
        public string TelNr { get; set; }
        public int pk_Id { get; set; }
        public int fk_PatalposId { get; set; }
    }
}
