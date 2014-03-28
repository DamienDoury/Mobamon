using Mobamon.GameManager;
using System.Linq;

namespace Mobamon.Pokemon.Helpers
{
    public static class TeamHelper
    {
        /// <summary>
        /// Gets the players count in a team.
        /// </summary>
        /// <returns>The players count in a team.</returns>
        /// <param name="teamId">Team identifier.</param>
        public static int GetPlayersCountInTeam(int teamId)
        {
            return PlayerRegistrar.Instance.List.Values.Where(v => v.Team == teamId).Count();
        }
    }
}