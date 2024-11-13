using back_end.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace back_end.DataAccess.Repositories
{
    public class ProfileRepository(DatabaseContext context)
    {
        private readonly DbSet<Profile> _entities = context.Profiles;

        public void CreateProfile(Profile profile)
        {
            _entities.Add(profile);
        }
    }
}
