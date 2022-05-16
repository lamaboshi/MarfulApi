namespace MarfulApi.Model
{
    public class Content
    {
        
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        public ICollection<CompanyContent> CompanyContent { set; get; }
        public ICollection<InfulonserContent> InfulonserContent { set; get; }
    }
}

