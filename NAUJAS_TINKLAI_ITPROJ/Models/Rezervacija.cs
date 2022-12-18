namespace NAUJAS_TINKLAI_ITPROJ.Models
{
    public class Rezervacija
    {
        public int pk_Id { get; set; }
        public int fk_VartotojoId { get; set; }
        public bool arRezervuota { get; set; }
    }
}
