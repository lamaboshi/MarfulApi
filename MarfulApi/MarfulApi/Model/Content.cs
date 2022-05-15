namespace MarfulApi.Model
{
    public class Content
    {
        
        public int Id { set; get; }
        public string Name { set; get; }
        public string Description { set; get; }
        ICollection<CompanyContent> CompanyContent { set; get; }
        ICollection<InfulonserContent> InfulonserContent { set; get; }
    }
}

