using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace attend_data.DataModel
{
    public class AttendContext : DbContext
    {
        public AttendContext() : base()
        {

        }

        public DbSet<Meeting> Meetings;
    }
}
