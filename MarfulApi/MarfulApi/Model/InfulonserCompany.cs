namespace MarfulApi.Model
{
    public class InfulonserCompany
    {
        public int Id { set; get; }
        public string Followed { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        public int IdCompany { set; get; }
        public Company Company { set; get; }
       
    }
}
