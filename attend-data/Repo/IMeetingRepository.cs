using System;

namespace attend_data.Repo
{
    public interface IMeetingRepository
    {
        MeetingRetrieve Retrieve(Guid id);
    }
}
