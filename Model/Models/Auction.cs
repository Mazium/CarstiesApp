using System;

namespace Carsties.Domain.Models
{
    public class Auction : BaseEntity
    {
        public int ReservePrice { get; set; } = 0;
        public string Seller { get; set; }
        public string Winner { get; set; }
        public decimal SoldAmount { get; set; }
        public decimal CurrentHighBid { get; set; }
        public DateTime AuctionEnd { get; set; }
        public Status Status { get; set; } = Status.Live;
        public Item Item { get; set; }
    }
}
