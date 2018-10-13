using System;

namespace _03_Defining_Classes_4
{
    public class Claim
    {
        public string ClaimId { get; set; }
        public DateTime ClaimDate { get; set; }
        public decimal ClaimAmt { get; set; }

        public Claim(string claimId, DateTime claimDate, decimal claimAmt)
        {
            ClaimId = claimId;
            ClaimAmt = claimAmt;
            ClaimDate = claimDate;

        }

    }
}
