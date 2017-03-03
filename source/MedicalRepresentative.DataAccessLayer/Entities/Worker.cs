namespace MedicalRepresentative.DataAccessLayer.Entities
{
    public class Worker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? InstituteId { get; set; }
        public virtual Institute Institute { get; set; }
        public int? OccupationId { get; set; }
        public virtual Occupation Occupation { get; set; }
    }
}
