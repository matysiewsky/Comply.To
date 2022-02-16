using System;

namespace Comply.To.Domain.Complaint
{
    public class PaidService : BaseComplaint
    {
        public PaidService(Guid orderId, Guid customerId, string description)
            : base(orderId, customerId, description)
        {
        }

        public PaidService(Guid orderId, Guid customerId, string description,
            string circumstances)
            : base(orderId, customerId, description, circumstances)
        {
        }

        public override bool ValidateDeadline(DateTime orderFinalised)
        {
            throw new NotImplementedException();
        }
    }
}

