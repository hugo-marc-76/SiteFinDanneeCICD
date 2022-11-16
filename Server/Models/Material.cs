namespace NWSInventaire.Server.Models
{
    public class Material
    {
        public int MaterialId { get; set; }

        public string? MaterialName { get; set; }

        public string? MaterialDescription { get; set; }

        public MaterialType? materialType { get; set; }

        public Student? student { get; set; }

        public DateTime StartLend { get; set; }

        public DateTime EndLend { get; set; }

        public DateTime LastReminder { get; set; }

    }
}
