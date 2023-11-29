using LakasHirdetes.Datas.Enums;

namespace LakasHirdetes.Datas.Entities
{
    public class Kiado
    {
        public Kiado(Guid id, string fullName, string email, string companyName , DateTime birthDay)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            CompanyName = companyName;
            BirthDay = birthDay;
        }

        public Kiado(string fullName, string email, string companyName, DateTime birthDay)
        {
            Id = new Guid();
            FullName = fullName;
            Email = email;
            CompanyName = companyName;
            BirthDay = birthDay;
        }

        public Kiado()
        {
            Id = new Guid();
            FullName = string.Empty;
            Email = string.Empty;
            CompanyName = string.Empty;
            BirthDay = new DateTime();
        }

        public Guid Id { get; set; }
        private string FullName { get; set; }
        public string Email { get; set; }
        public string CompanyName { get; set;}
        public DateTime BirthDay { get; set;}

        public override string ToString()
        {
            return $"{FullName}: Email: {Email},Hirdető cég név: {CompanyName},Szül: {String.Format("{0:yyyy:MM.dd}", BirthDay)}";
        }
    }
}
