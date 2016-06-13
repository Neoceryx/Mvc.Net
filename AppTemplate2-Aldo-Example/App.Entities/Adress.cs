namespace App.Entities
{
   public  class Address
    {
        public int Id { get; set; }
        public string Street { get; set; }
        public int UserId { get; set; }

        public virtual User User { get; set; }
    }
}