namespace MarfulApi.Model
{
    public class CompanyContent
    {
        public int Id { set; get; }
        public int CompanyId { set; get; }
        public Company Company { set; get; }
        public int ContentId { set; get; }
        public Content Content { set; get; }
        public ICollection<Brand> Brand { set; get; }
    }
}
