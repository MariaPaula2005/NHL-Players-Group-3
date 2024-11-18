using System.Collections.Generic;
using System.Linq;

namespace NHL_Players
{
    public class Sorting
    {
        public List<Player> Sort(List<Player> players, string field, bool ascending)
        {
            var property = typeof(Player).GetProperty(field);
            if (property == null) return players;

            return ascending
                ? players.OrderBy(p => property.GetValue(p)).ToList()
                : players.OrderByDescending(p => property.GetValue(p)).ToList();
        }
}}
