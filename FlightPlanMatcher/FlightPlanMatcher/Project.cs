﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Device.Location;

namespace FlightPlanMatcher
{
    
    // will watch actual flight data with planned flight data

    class Project
    {
        // method to match actual flight objects to planned flight lines

        public void MatchPairs(ActualFlightProject actualFlightProject, PlannedFlightProject plannedFlightProject)
        {
            // New "PlannedFlightProject" object to use for comparison

            PlannedFlightProject newPlannedFlight = new PlannedFlightProject();
            KMLParser kmlParser = new KMLParser();
            newPlannedFlight = kmlParser.ParseKMLFile();

            // New "ActualFlightProject" object to use for comparison

            ActualFlightProject newActualFlight = new ActualFlightProject();
            RPPParser rppParser = new RPPParser();
            newActualFlight = RPPParser.AddSwathsFromRPP();


            var test = new GeoCoordinate();

            var totalPlanned = newPlannedFlight.totalPlannedSwaths();

            // try with matching start or finish lat or longs to each other with a <400m difference

            foreach (var swath in newPlannedFlight.PlannedSwathList)
            {
                



            }


        }

        // get horizontal distance between two set of lat/long coords
        public double DistanceDifference(GeoCoordinate num1, GeoCoordinate num2)
        {

            double horizontalDistance = num1.GetDistanceTo(num2);

            return horizontalDistance;

        }

    }
}
