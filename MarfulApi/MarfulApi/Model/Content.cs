namespace MarfulApi.Model
{
    public class Content
    {
        
        public int Id { set; get; }
        public string Name { set; get; }
        public string? Description { set; get; }
        public virtual ICollection<CompanyContent>? CompanyContent { set; get; }
        public virtual ICollection<InfulonserContent>? InfulonserContent { set; get; }
    }
}

