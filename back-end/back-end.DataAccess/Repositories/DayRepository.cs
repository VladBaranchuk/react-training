using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace back_end.DataAccess.Repositories
{
    public class DayRepository(DatabaseContext context)
    {
        private readonly DbSet<Day> _entities = context.Days;

        public void CreateDay(Day day)
        {
            _entities.Add(day);
        }
    }
}
