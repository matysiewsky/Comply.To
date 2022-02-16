using System;

namespace Comply.To.Domain.Complaint
{
    public class Note
    {
        public Guid ComplaintId { get; }
        public string Message { get; }
        public DateTime CreatedOn { get; private set; }

        public Note(Guid complaintId, string message)
        {
            ComplaintId = complaintId;
            Message = message;
            CreatedOn = DateTime.Now;
        }

    }
}