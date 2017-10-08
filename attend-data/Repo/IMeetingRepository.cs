using System;

namespace attend_data.Repo
{
    public interface IMeetingRepository
    {
        Meeting Retrieve(Guid id);
    }
}
