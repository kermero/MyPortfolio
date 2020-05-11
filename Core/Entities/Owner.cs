namespace Core.Entities
{
    public  class Owner : EntityBase
    {
        public string FullName { get; set; }
        public string  profil { get; set; }
        public string Avatar { get; set; }
        public Address Address { get; set; }
    }
}
