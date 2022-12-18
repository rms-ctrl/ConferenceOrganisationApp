namespace NAUJAS_TINKLAI_ITPROJ.Models
{
    public class Auditorija
    {
        public int pk_Id { get; set; }
        public string Pavadinimas { get; set; }
        public int fk_PatalpaId { get; set; }
        public string Tema { get; set; }
        public int fk_VartotojoId { get; set; }
    }
}
