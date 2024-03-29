﻿namespace MarfulApi.Model
{
    public class Company
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public string? Phone { set; get; }
        public string Email { set; get; }
        public string Password { set; get; }
        public string? TelePhone { set; get; }
        public string Address{ set; get; }
        public byte[]? Image { set; get; }
        public string? Description { set; get; }
        public virtual ICollection<Conversation>? conversation { set; get; }
        public virtual ICollection<UserCompany>? UserCompanie { set; get; }
        public virtual ICollection<CompanyContent>? CompanyContent { set; get; }
        public virtual ICollection<CompanyType>? CompanyType { set; get; }
        public virtual ICollection<CompanyInfulonser>? CompanyInfulonser { set; get; }
    }
}
