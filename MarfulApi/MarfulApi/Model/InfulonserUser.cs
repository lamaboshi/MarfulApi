namespace MarfulApi.Model
{
    public class InfulonserUser
    {
        public int Id { set; get; }
        public int IdInfulonser { set; get; }
        public Infulonser Infulonser { set; get; }
        public int IdUser { set; get; }
        public User User { set; get; }
    }
}
