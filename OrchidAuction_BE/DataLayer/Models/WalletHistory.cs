using System;
using System.Collections.Generic;

namespace DataLayer.Models
{
    public partial class WalletHistory
    {
        public Guid Id { get; set; }
        public Guid? WalletId { get; set; }
        public double? MoneyChange { get; set; }
        public DateTime? HistoryTime { get; set; }
        public bool? Status { get; set; }

        public virtual Wallet? Wallet { get; set; }
    }
}
