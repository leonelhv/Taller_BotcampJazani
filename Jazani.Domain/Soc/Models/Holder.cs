﻿using Jazani.Domain.Mc.Models;

namespace Jazani.Domain.Soc.Models
{
    public class Holder
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Lastname { get; set; }
        public string? MaidenName { get; set; }
        public string? Documentnumber { get; set; }
        public string? Landline { get; set; }
        public string? Mobile { get; set; }
        public string? Corporatemail { get; set; }
        public string? Personalmail { get; set; }
        public DateTime RegistrationDate { get; set; }
        public bool State { get; set; }

        public virtual ICollection<Investment>? Investments { get; set; }
    }
}
