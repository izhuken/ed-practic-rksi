using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EdPractic_Alex
{
    struct Placement
    {
        public string city;
        public string street;
        public string number;
        public string flat;
        public string room;
    }

    internal class PlacementManager
    {
        private static string PlacementParsePattern = @"c\[(.*)\]st\[(.*)\]n\[(.*)\]f\[(.*)\]r\[(.*)\]";
        private static string PlacementBlankTemplate = "c[]st[]n[]f[]r[]";

        public static string Combine(string city, string street, string number, string flat, string room)
        {
            return $"c[{city}]st[{street}]n[{number}]f[{flat}]r[{room}]";
        }

        public static Placement Parse(string combinedPlacement)
        {
            Placement placement = new();

            if (combinedPlacement == "")
            {
                placement.city = "";
                placement.street = "";
                placement.flat = "";
                placement.number = "";
                placement.room = "";
                return placement;
            };

            var result = Regex.Match(combinedPlacement, PlacementParsePattern);

            placement.city = result.Groups[1].ToString();
            placement.street = result.Groups[2].ToString();
            placement.number = result.Groups[3].ToString();
            placement.flat = result.Groups[4].ToString();
            placement.room = result.Groups[5].ToString();

            return placement;
        }

        public static string Normalize(Placement placement)
        {
            string city = placement.city == "" ? "" : $"г. {placement.city}";
            string room = placement.room == "" ? "" : $"к. {placement.room}";
            string street = placement.street == "" ? "" : $"ул. {placement.street}";
            string number = placement.number == "" ? "" : $"{placement.number}";
            string flat = placement.flat == "" ? "" : $"кв. {placement.flat}";
            return $"{city} {street} {number} {flat} {room}";
        }
        public static string Normalize(string templatedPlacement)
        {
            Placement placement = Parse(templatedPlacement);
            string city = placement.city == "" ? "" : $"г. {placement.city}";
            string room = placement.room == "" ? "" : $"к. {placement.room}";
            string street = placement.street == "" ? "" : $"ул. {placement.street}";
            string number = placement.number == "" ? "" : $"{placement.number}";
            string flat = placement.flat == "" ? "" : $"кв. {placement.flat}";
            return $"{city} {street} {number} {flat} {room}";
        }
    }
}
