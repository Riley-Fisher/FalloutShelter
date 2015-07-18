using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class RatingMgr {
        public int sampleId { get; set; }
        public int dayRatingId { get; set; }
        public List<int> currentSamples { get; set; }
        public List<Rating> ratings { get; set; }
        public List<Rating> ratingsLast { get; set; }
        public bool hasWeekRating { get; set; }
        public bool hasLastWeekRating { get; set; }
        public int weekRating { get; set; }
        public int lastWeekRating { get; set; }
    }
}