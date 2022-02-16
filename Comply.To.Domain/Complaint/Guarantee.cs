using System;

namespace Comply.To.Domain.Complaint
{
    public class Guarantee : BaseComplaint
    {
        public Guarantee(Guid orderId, Guid customerId, string description)
            : base(orderId, customerId, description)
        {
        }

        public Guarantee(Guid orderId, Guid customerId, string description,
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

