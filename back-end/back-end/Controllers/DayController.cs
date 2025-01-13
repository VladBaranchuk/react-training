using back_end.DataAccess;
using back_end.DataAccess.Entities;
using back_end.DataAccess.Providers;
using back_end.DataAccess.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace back_end.Controllers
{
    [ApiController]
    [Route("api/profile/{profileId}/days")]
    public class DayController : ControllerBase
    {
        private readonly DayProvider _dayProvider;
        private readonly DayRepository _dayRepository;
        private readonly DatabaseContext _dbContext;

        public DayController(
            DayProvider dayProvider,
            DayRepository dayRepository,
            DatabaseContext dbContext)
        {
            _dayProvider = dayProvider;
            _dayRepository = dayRepository;
            _dbContext = dbContext;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDay([FromRoute] Guid profileId, [FromRoute] Guid id)
        {
            var token = HttpContext.RequestAborted;

            var day = await _dayProvider
                .GetDayById(id)
                .FirstOrDefaultAsync(token);

            return Ok(day);
        }
        
        [HttpGet]
        public async Task<IActionResult> GetDays(
            [FromRoute] Guid profileId, 
            [FromQuery] int page = 1, [FromQuery] int size = 10)
        {
            var token = HttpContext.RequestAborted;

            await CreateNewDay(profileId);

            var days = await _dayProvider
                .GetDays(profileId, page, size)
                .Select(x => new
                {
                    x.Id,
                    x.Date
                })
                .ToListAsync();

            return Ok(days);
        }

        private async Task CreateNewDay(Guid profileId)
        {
            var newDay = await _dayProvider
                .GetDayByDate(profileId, DateTime.UtcNow)
                .FirstOrDefaultAsync();

            if (newDay == null)
            {
                newDay = new Day()
                {
                    Id = Guid.NewGuid(),
                    MorningWeight = 0.0,
                    StartSleep = DateTime.Now,
                    FinishSleep = DateTime.Now,
                    Fatigue = FatigueType.None,
                    Sleepy = SleepyType.None,
                    Mood = MoodType.None,
                    DoDrink = false,
                    DoSmoke = false,
                    DoMorningExamples = false,
                    Date = DateTime.UtcNow,
                    ProfileId = profileId,
                    Activities = new List<Activity>(),
                    Dishes = new List<Dish>()
                };

                _dayRepository.CreateDay(newDay);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
