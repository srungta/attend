using System;

namespace attend_data.Repo
{
    public class MeetingRepository : IMeetingRepository
    {
        public Meeting Retrieve(Guid id)
        {
            return new Meeting
            {
                Id = Guid.NewGuid()
            };
        }
    }
}
