using back_end.DataAccess;
using back_end.DataAccess.Entities;
using back_end.DataAccess.Providers;
using back_end.DataAccess.Repositories;
using back_end.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/profile")]
    public class ProfileController(
        ProfileProvider _profileProvider,
        ProfileRepository _profileRepository,
        DatabaseContext _dbContext) : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CreateProfile([FromBody] CreateProfileViewModel newProfile)
        {
            var token = HttpContext.RequestAborted;

            var profile = new Profile()
            {
                FirstName = newProfile.FirstName,
                LastName = newProfile.LastName,
                Weight = newProfile.Weight,
                StartDay = DateTime.UtcNow,
            };
            _profileRepository.CreateProfile(profile);
            await _dbContext.SaveChangesAsync(token);

            return Created();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProfile([FromRoute] Guid id)
        {
            var token = HttpContext.RequestAborted;

            var profile = await _profileProvider
                .GetProfile(id)
                .FirstOrDefaultAsync(token);

            return Ok(profile);
        }

        [HttpGet]
        public async Task<IActionResult> GetProfiles([FromQuery] int page = 1, [FromQuery] int size = 10)
        {
            var token = HttpContext.RequestAborted;

            var profile = await _profileProvider
                .GetProfiles(page, size)
                .ToListAsync(token);

            return Ok(profile);
        }
    }
}
