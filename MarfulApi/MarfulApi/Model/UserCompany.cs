namespace MarfulApi.Model
{
    public class UserCompany
    {
        public int Id { set; get; }
        public int IdUser { set; get; }
        public User User { set; get; }
        public int IdCompany { set; get; }
        public Company Company { set; get; }
    }
}
