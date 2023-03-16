namespace urlopy2.Models
{
    public class Pracownik
    {
        public int Id { get; set; }    
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? EmailAddress { get; set; }
        public string? Tekst { get; set; }
        public DateTime DataOd { get; set; }
		public DateTime DataDo { get; set; }
        public int IleDni { get; set; }
		public bool JestAkceptacja { get; set; }
        public string? ZdjecieUrl { get; set; }
        public string? MiniaturkaUrl { get; set; }
		public DateTime data_created { get; set; }
		public DateTime data_updated { get; set; }
        public bool JsetZgoda { get; set; }
        public string? Manager { get; set; }

    }
}
