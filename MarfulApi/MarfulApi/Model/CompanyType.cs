namespace MarfulApi.Model
{
    public class CompanyType
    {

        public int Id { get; set; }
        public string type { get; set; }
        public int CompanyId { get; set; }
        public virtual Company? Company { get; set; }
    }
}
