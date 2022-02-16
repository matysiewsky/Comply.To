using System;
using System.Collections.Generic;
using Comply.To.Domain.Enums;

namespace Comply.To.Domain.Complaint
{
    public interface IBaseComplaint
    {
        Guid? Id { get; set; }
        Guid OrderId { get; set; }
        Guid CustomerId { get; set; }
        RealizationStatus Status { get; set; }
        string Description { get; set; }
        string? Circumstances { get; set; }
        IEnumerable<Note> Notes { get; set; }

        bool ValidateDeadline(DateTime orderFinalised);
    }
}