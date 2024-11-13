using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace back_end.DataAccess.Providers
{
    public class ProfileProvider(DatabaseContext context)
    {
        private readonly DbSet<Profile> _entities = context.Profiles;

        public IQueryable<Profile> GetProfiles(int page, int size)
        {
            return _entities
                .Skip((page - 1) * size)
                .Take(size);
        }

        public IQueryable<Profile> GetProfile(Guid id)
        {
            return _entities.Where(x => x.Id == id);
        }
    }
}
