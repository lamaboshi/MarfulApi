namespace MarfulApi.Model
{
    public class CompanyContent
    {
        public int Id { set; get; }
        public int IdCompany { set; get; }
        public Company Company { set; get; }
        public int IdContent { set; get; }
        public Content Content { set; get; }
       ICollection<Brand> Brand { set; get; }
    }
}
