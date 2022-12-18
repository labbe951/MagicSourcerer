namespace EFcoreRelationships.Models
{
    public class Band
    {
        public Guid Id { get; set; }
        public string BandName { get; set; } = string.Empty;
        public string BandDescription { get; set; } = string.Empty;
        public List<BandMember> BandMembers { get; set; } = new List<BandMember>();
    }
}
