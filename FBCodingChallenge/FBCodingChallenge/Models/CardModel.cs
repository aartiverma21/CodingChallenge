using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FBCodingChallenge.Models
{
    public class CardModel
    {
        public int CardNumber { get; set; }
        public int Cvv { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string NameOnCard { get; set; }
    }
}