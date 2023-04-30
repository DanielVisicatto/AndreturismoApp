﻿namespace AndreTurismoApp.Models
{
    public class Address
    {
        #region[Properties]
        public int Id { get; set; }
        public string? Street { get; set; }
        public int Number { get; set; }
        public string? Neighborhood { get; set; }
        public string? Complement { get; set; }
        public City City { get; set; }
        public string? ZipCode { get; set; }
        public DateTime RegisterDate { get; set; }
        #endregion
    }
}