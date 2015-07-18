using System.ComponentModel;

namespace FalloutShelter.VaultData {
    public class RootObject {
        [DisplayName(@"Time Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public TimeMgr timeMgr { get; set; }

        [DisplayName(@"Local Notification Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public LocalNotificationMgr localNotificationMgr { get; set; }

        [DisplayName(@"Task Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public TaskMgr taskMgr { get; set; }

        [DisplayName(@"Rating Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public RatingMgr ratingMgr { get; set; }

        [DisplayName(@"Dwellers"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public Dwellers dwellers { get; set; }

        [DisplayName(@"Construct Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public ConstructMgr constructMgr { get; set; }

        [DisplayName(@"Vault"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public Vault vault { get; set; }

        [DisplayName("Dweller Spawner"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public DwellerSpawner dwellerSpawner { get; set; }

        public string deviceName { get; set; }

        [DisplayName(@"Tutorial Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public TutorialManager tutorialManager { get; set; }

        [DisplayName(@"Objective Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public ObjectiveMgr objectiveMgr { get; set; }

        [DisplayName(@"Unlockable Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public UnlockableMgr unlockableMgr { get; set; }

        [DisplayName(@"Survival W"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public SurvivalW survivalW { get; set; }

        [DisplayName(@"Happiness Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public HappinessManager happinessManager { get; set; }

        [DisplayName(@"Refugee Spawner"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public RefugeeSpawner refugeeSpawner { get; set; }

        [DisplayName(@"Lunchbox Collect Window"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public LunchBoxCollectWindow LunchBoxCollectWindow { get; set; }

        [DisplayName(@"Swrve Events Manager"),
         TypeConverter(typeof (ExpandableObjectConverter))]
        public SwrveEventsManager swrveEventsManager { get; set; }
    }
}