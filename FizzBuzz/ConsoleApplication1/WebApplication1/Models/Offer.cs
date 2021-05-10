using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Offer
    {

        // 3) Create   a   class   named   "Offer"   with    .

        //var varOffers = new OfferViewModel("Discount", ProductViewModel("Toothpaste", 10.00, "Toothpaste contains salt"));

        public class OfferViewModel
        {
            public string OfferName { get; set; }

            public IList<ProductViewModel> ProductsList { get; set; }
        }
    }
}