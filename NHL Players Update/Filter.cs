using NHL_Players;
using System;
using System.Collections.Generic;
using System.Linq;

public static class Filter
{
    public static List<Player> ApplyFilter(List<Player> players, string filterExpression)
    {
        if (string.IsNullOrWhiteSpace(filterExpression)) return players;

        var conditions = filterExpression.Split(',')
            .Select(condition => condition.Trim())
            .ToList();

        foreach (var condition in conditions)
        {
            var tokens = ParseCondition(condition);
            if (tokens == null) continue;

            string field = tokens[0];
            string op = tokens[1];
            string value = tokens[2];

            players = players.Where(player => MatchesCondition(player, field, op, value)).ToList();
        }

        return players;
    }

    private static string[] ParseCondition(string condition)
    {
        var operators = new[] { ">", "<", ">=", "<=", "==", "=" };
        foreach (var op in operators)
        {
            int index = condition.IndexOf(op, StringComparison.Ordinal);
            if (index != -1)
            {
                string field = condition.Substring(0, index).Trim();
                string value = condition.Substring(index + op.Length).Trim();
                return new[] { field, op, value };
            }
        }
        return null;
    }

    private static bool MatchesCondition(Player player, string field, string op, string value)
    {
        object fieldValue = GetFieldValue(player, field);
        if (fieldValue == null) return false;

        if (fieldValue is int intValue)
        {
            if (double.TryParse(value, out double targetDouble))
                return CompareNumbers(intValue, op, targetDouble);
        }
        else if (fieldValue is double doubleValue)
        {
            if (double.TryParse(value, out double targetDouble))
                return CompareNumbers(doubleValue, op, targetDouble);
        }
        else if (fieldValue is string strValue)
        {
            return CompareStrings(strValue, op, value);
        }

        return false;
    }

    private static object GetFieldValue(Player player, string field)
    {
        switch (field)
        {
            case "GP":
                return player.GP;
            case "G":
                return player.G;
            case "A":
                return player.A;
            case "P":
                return player.P;
            case "PlusMinus":
                return player.PlusMinus;
            case "Team":
                return player.Team;
            case "Name":
                return player.Name;
            case "Pos":
                return player.Pos;
            case "PIM":
                return player.PIM;
            case "PGP":
                return player.PGP;
            case "PPG":
                return player.PPG;
            case "PPP":
                return player.PPP;
            case "SHG":
                return player.SHG;
            case "SHP":
                return player.SHP;
            case "GWP":
                return player.GWG;
            case "OTG":
                return player.OTG;
            case "S":
                return player.S;
            case "SPercentage":
                return player.SPercentage;
            case "TOIGP":
                return player.TOIGP;
            case "ShiftsGP":
                return player.ShiftsGP;
            case "FOWPercentage":
                return player.FOWPercentage;
            default:
                return null;
        }
    }

    private static bool CompareNumbers(double fieldValue, string op, double targetValue)
    {
        switch (op)
        {
            case ">":
                return fieldValue > targetValue;
            case "<":
                return fieldValue < targetValue;
            case ">=":
                return fieldValue >= targetValue;
            case "<=":
                return fieldValue <= targetValue;
            case "=":
            case "==":
                return Math.Abs(fieldValue - targetValue) < 0.0001;
            default:
                return false;
        }
    }

    private static bool CompareStrings(string fieldValue, string op, string targetValue)
    {
        if (op == "=" || op == "==")
            return fieldValue.ToLower().Contains(targetValue.ToLower());

        return false;
    }

}
