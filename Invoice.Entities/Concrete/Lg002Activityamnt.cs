using System;
using System.Collections.Generic;

#nullable disable

namespace Invoice.Entities.Concrete
{
    public partial class Lg002Activityamnt
    {
        public int Logicalref { get; set; }
        public int? Prodordref { get; set; }
        public int? Displineref { get; set; }
        public int? Ovhdtrref { get; set; }
        public DateTime? Date { get; set; }
        public double? Amount { get; set; }
    }
}
