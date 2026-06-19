using MoodPlay.Models;

namespace MoodPlay.Services
{
    public interface IMoodService
    {
        List<Mood> GetAllMoods();
        Mood GetMoodByName(string name);
    }
}