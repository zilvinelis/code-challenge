using System.Linq;
using CodeChallengeJanuary2020.Extensions;
using CodeChallengeJanuary2020.Services;
using Xunit;

namespace CodeChallengeJanuary2020.Tests
{
    public class VesselPositionExtensionsTest
    {
        [Fact]
        public void VesselPositionCountIsTheSameAfterSplit()
        {
            var positions = VesselPositionDataService.GetVesselPositions().ToList();

            var splitPositions = positions.Split();

            Assert.Equal(positions.Count(), splitPositions.SelectMany(x => x).Count());
        }
    }
}
