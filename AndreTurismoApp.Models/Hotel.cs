namespace AndreTurismoApp.Models
{
    internal class Hotel
    {
        #region[Properties]
        public int Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public DateTime RegisterDate { get; set; }
        public float Price { get; set; }
        #endregion
    }
}
