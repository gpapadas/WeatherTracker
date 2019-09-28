﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace WeatherTracker
{
    public class Wind
    {
        public enum DirectionEnum
        {
            North,
            North_North_East,
            North_East,
            East_North_East,
            East,
            East_South_East,
            South_East,
            South_South_East,
            South,
            South_South_West,
            South_West,
            West_South_West,
            West,
            WNW,
            North_West,
            North_North_West,
            Unknown
        }

        public readonly double SpeedMetersPerSecond;
        public readonly double SpeedFeetPerSecond;
        public readonly DirectionEnum Direction;
        public readonly double Degree;
        public readonly double Gust;

        public Wind(JToken windData)
        {
            SpeedMetersPerSecond = double.Parse(windData.SelectToken("speed").ToString());
            SpeedFeetPerSecond = SpeedMetersPerSecond * 3.28084;
            Degree = double.Parse(windData.SelectToken("deg").ToString());
            Direction = AssignDirection(Degree);

            if (windData.SelectToken("gust") != null)
                Gust = double.Parse(windData.SelectToken("gust").ToString());
        }

        public string DirectionEnumToString(DirectionEnum dir)
        {
            switch (dir)
            {
                case DirectionEnum.East:
                    return "East";
                case DirectionEnum.East_North_East:
                    return "East North-East";
                case DirectionEnum.East_South_East:
                    return "East South-East";
                case DirectionEnum.North:
                    return "North";
                case DirectionEnum.North_East:
                    return "North East";
                case DirectionEnum.North_North_East:
                    return "North North-East";
                case DirectionEnum.North_North_West:
                    return "North North-West";
                case DirectionEnum.North_West:
                    return "North West";
                case DirectionEnum.South:
                    return "South";
                case DirectionEnum.South_East:
                    return "South East";
                case DirectionEnum.South_South_East:
                    return "South South-East";
                case DirectionEnum.South_South_West:
                    return "South South-West";
                case DirectionEnum.South_West:
                    return "South West";
                case DirectionEnum.West:
                    return "West";
                case DirectionEnum.WNW:
                    return "West North-West";
                case DirectionEnum.West_South_West:
                    return "West South-West";
                case DirectionEnum.Unknown:
                    return "Unknown";
                default:
                    return "Unknown";
            }
        }

        private DirectionEnum AssignDirection(double degree)
        {
            if (FallsBetween(degree, 348.75, 360))
                return DirectionEnum.North;
            if (FallsBetween(degree, 0, 11.25))
                return DirectionEnum.North;
            if (FallsBetween(degree, 11.25, 33.75))
                return DirectionEnum.North_North_East;
            if (FallsBetween(degree, 33.75, 56.25))
                return DirectionEnum.North_East;
            if (FallsBetween(degree, 56.25, 78.75))
                return DirectionEnum.East_North_East;
            if (FallsBetween(degree, 78.75, 101.25))
                return DirectionEnum.East;
            if (FallsBetween(degree, 101.25, 123.75))
                return DirectionEnum.East_South_East;
            if (FallsBetween(degree, 123.75, 146.25))
                return DirectionEnum.South_East;
            if (FallsBetween(degree, 168.75, 191.25))
                return DirectionEnum.South;
            if (FallsBetween(degree, 191.25, 213.75))
                return DirectionEnum.South_South_West;
            if (FallsBetween(degree, 213.75, 236.25))
                return DirectionEnum.South_West;
            if (FallsBetween(degree, 236.25, 258.75))
                return DirectionEnum.West_South_West;
            if (FallsBetween(degree, 258.75, 281.25))
                return DirectionEnum.West;
            if (FallsBetween(degree, 281.25, 303.75))
                return DirectionEnum.WNW;
            if (FallsBetween(degree, 303.75, 326.25))
                return DirectionEnum.North_West;
            if (FallsBetween(degree, 326.25, 348.75))
                return DirectionEnum.North_North_West;
            return DirectionEnum.Unknown;
        }

        //fB = fallsBetween
        private bool FallsBetween(double val, double min, double max)
        {
            if ((min <= val) && (val <= max))
                return true;
            return false;
        }
    }
}