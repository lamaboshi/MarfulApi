namespace MarfulApi.Model
{
    public class CompanyContent
    {
        public int Id { set; get; }
        public int? CompanyId { set; get; }
        public virtual Company? Company { set; get; }
        public int? ContentId { set; get; }
        public virtual Content? Content { set; get; }
        public virtual ICollection<Brand>? Brand { set; get; }
    }
}
