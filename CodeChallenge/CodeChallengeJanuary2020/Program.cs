using System;
using CodeChallengeJanuary2020.Extensions;
using CodeChallengeJanuary2020.Services;

namespace CodeChallengeJanuary2020
{
    class Program
    {
        static void Main(string[] args)
        {
            var vesselPositions = VesselPositionDataService.GetVesselPositions();
            var splitPositions = vesselPositions.Split();

            Console.ReadLine();
        }
    }
}
