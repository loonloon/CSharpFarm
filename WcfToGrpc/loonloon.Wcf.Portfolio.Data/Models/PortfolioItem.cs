﻿using System.Runtime.Serialization;

namespace loonloon.Wcf.Portfolio.Data.Models
{
    [DataContract]
    public class PortfolioItem
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int ShareId { get; set; }

        [DataMember]
        public int Holding { get; set; }

        [DataMember]
        public decimal Cost { get; set; }
    }
}
