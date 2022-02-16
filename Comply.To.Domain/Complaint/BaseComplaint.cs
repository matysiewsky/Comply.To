using System;
using System.Collections.Generic;
using Comply.To.Domain.Enums;

namespace Comply.To.Domain.Complaint
{
    public abstract class BaseComplaint : IBaseComplaint
    {
        public Guid? Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public RealizationStatus Status { get; set; }

        public string Description { get; set; }
        public string? Circumstances { get; set; }
        public IEnumerable<Note> Notes { get; set; }
            = new List<Note>();

        protected BaseComplaint(Guid orderId, Guid customerId, string description)
        {
            OrderId = orderId;
            CustomerId = customerId;
            Description = description;
            Status = RealizationStatus.Created;
        }

        protected BaseComplaint(Guid orderId, Guid customerId, string description, string circumstances)
        {
            OrderId = orderId;
            CustomerId = customerId;
            Description = description;
            Circumstances = circumstances;
            Status = RealizationStatus.Created;
        }

        public abstract bool ValidateDeadline(DateTime orderFinalised);
    }
}

