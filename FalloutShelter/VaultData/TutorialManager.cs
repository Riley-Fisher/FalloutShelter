using System.Collections.Generic;

namespace FalloutShelter.VaultData {
    public class TutorialManager {
        public string phase { get; set; }
        public int taskNumber { get; set; }
        public bool objectivesTutorialMessage { get; set; }
        public bool lunchboxTutorialMessage { get; set; }
        public bool showingObjectiveTutorialMessage { get; set; }
        public bool showingLunchboxTutorialMessage { get; set; }
        public double showWastelandMessageTime { get; set; }
        public double showExploreWastelandMessageTime { get; set; }
        public bool exploreWastelandMessageShown { get; set; }
        public List<object> intialTimerTasks { get; set; }
        public bool ContextualVaultTecObjectives { get; set; }
        public bool ContextualAddFriends { get; set; }
        public bool ContextualWasteland { get; set; }
        public bool ContextualRadioRoom { get; set; }
        public bool ContextualWeaponsAndOutfits { get; set; }
        public bool ContextualTrainDweller { get; set; }
        public bool ContextualBabies { get; set; }
        public bool ContextualDestroyRocks { get; set; }
        public bool ContextualStorage { get; set; }
        public bool ContextualNoRoomForDwellers { get; set; }
        public bool ContextualUnequipedDweller { get; set; }
        public bool ContextualBuildAnElevator { get; set; }
        public bool ContextualDestroyRockToBuild { get; set; }
        public bool ContextualNoBuildZonesAvailableByRock { get; set; }
        public bool ContextualDestroyRockToAccessNextFloor { get; set; }
        public bool ContextualResourcesAlert { get; set; }
        public bool ContextualIncidentOcurs { get; set; }
        public bool ContextualLowPowerAlert { get; set; }
        public bool ContextualStorageFull { get; set; }
        public bool ContextualMergeOrUpgradeRoom { get; set; }
        public bool ContextualWastelandMessage { get; set; }
        public bool ContextualObjectivesCompleted { get; set; }
        public bool ContextualBabiesTutorial { get; set; }
        public bool ContextualStimpackMessage { get; set; }
        public bool ContextualLunchboxTutorial { get; set; }
        public bool ContextualRadwayMessage { get; set; }
        public bool ContextualRoomMerge2 { get; set; }
        public bool ContextualRoomMerge3 { get; set; }
        public bool ContextualStorage2 { get; set; }
        public bool ContextualEquippingItemsWeapon { get; set; }
        public bool ContextualLuck { get; set; }
        public int MaleTasksQuant { get; set; }
        public int FemaleTasksQuant { get; set; }
    }
}