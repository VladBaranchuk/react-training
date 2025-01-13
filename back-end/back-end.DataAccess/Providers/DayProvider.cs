using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace back_end.DataAccess.Providers
{
    public class DayProvider(DatabaseContext context)
    {
        private readonly DbSet<Day> _entities = context.Days;

        public IQueryable<Day> GetDayById(Guid id)
        {
            return _entities.Where(x => x.Id == id);
        }

        public IQueryable<Day> GetDayByDate(Guid profileId, DateTime date)
        {
            return _entities
                .Where(x => x.ProfileId == profileId)
                .Where(x => x.Date.Date == date.Date);
        }

        public IQueryable<Day> GetDays(Guid profileId, int page, int size)
        {
            return _entities
                .Where(x => x.ProfileId == profileId)
                .Skip((page - 1) * size)
                .Take(size);
        }
    }
}
