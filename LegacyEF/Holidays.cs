using System;

namespace LegacyEF
{
    public class HolidayRequest
    {
        public Guid Id { get; set; }

        public DateTime Date { get; set; }

        public string Notes { get; set; }

        public Status Status { get; set; }

        public void Approve()
        {
            Status = Status.Approved;
        }
    }

    public enum Status
    {
        Pending,
        Approved,
    }
}