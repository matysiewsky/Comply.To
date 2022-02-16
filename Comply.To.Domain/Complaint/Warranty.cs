using System;

namespace Comply.To.Domain.Complaint
{
    public class Warranty : BaseComplaint
    {
        public Warranty(Guid orderId, Guid customerId, string description)
            : base(orderId, customerId, description)
        {
        }

        public Warranty(Guid orderId, Guid customerId, string description,
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

