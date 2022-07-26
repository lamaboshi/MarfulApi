namespace MarfulApi.Model
{
    public class CompanyInfulonser
    {
        public int Id { set; get; }
        public string Followed { set; get; }
        public int? InfulonserId { set; get; }
        public Infulonser Infulonser { set; get; }
        public int? CompanyId { set; get; }
        public Company Company { set; get; }
    }
}
