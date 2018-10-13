using _03_Defining_Classes_4;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Defining_Classes_4
{
    public class ClaimRepository
    {
         private List<Claim> _claimlisList;

        public ClaimRepository()
        { 
        _claimlisList = new List<Claim>();
        }

    public List<Claim> GetClaimsList()
        {
        return _claimlisList;
        }

    public void AddClaim(Claim claim)
    {
        _claimlisList.Add(claim);
    }

    public List<string> SendCallMessage()
    {
        List<string> claimMessage = new List<string>();
        foreach (var claim in _claimlisList)
        {
            if (claim.ClaimAmt > 10000m)
                claimMessage.Add(claim.ClaimId + "Call agent");
            else
                claimMessage.Add(claim.ClaimId + "Claim is being processed");

        }

        return claimMessage;
    }
}
}

