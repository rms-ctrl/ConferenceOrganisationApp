namespace NAUJAS_TINKLAI_ITPROJ.Models
{
    public class Patalpa
    {
        public string Pavadinimas { get; set; }
        public string Adresas { get; set; }
        public int Talpa { get; set; }
        public DateTime? LaisvumoData { get; set; }
        public string Įranga { get; set; }
        public int PranesejuSk { get; set; }
        public int pk_Id { get; set; }
        public int fk_Rezervacija { get; set; }
    }
}
