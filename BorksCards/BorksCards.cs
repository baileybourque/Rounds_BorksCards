﻿using BepInEx;
using UnboundLib;
using UnboundLib.Cards;
using BorksCards.Cards;
using HarmonyLib;
using CardChoiceSpawnUniqueCardPatch.CustomCategories;


namespace BorksCards
{
    // These are the mods required for our mod to work
    [BepInDependency("com.willis.rounds.unbound", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.moddingutils", BepInDependency.DependencyFlags.HardDependency)]
    [BepInDependency("pykess.rounds.plugins.cardchoicespawnuniquecardpatch", BepInDependency.DependencyFlags.HardDependency)]
    // Declares our mod to Bepin
    [BepInPlugin(ModId, ModName, Version)]
    // The game our mod is associated with
    [BepInProcess("Rounds.exe")]
    public class MyModName : BaseUnityPlugin
    {
        private const string ModId = "com.bork.rounds.borkscards";
        private const string ModName = "BorksCards";
        public const string Version = "0.0.1"; // What version are we on (major.minor.patch)?
        public const string ModInitials = "BC";
        public static BorksCards instance { get; private set; }


        void Awake()
        {
            // Use this to call any harmony patch files your mod may have
            var harmony = new Harmony(ModId);
            harmony.PatchAll();
        }
        void Start()
        {
            instance = this;
            CustomCard.BuildCard<MyCardName>();
        }
    }
}
