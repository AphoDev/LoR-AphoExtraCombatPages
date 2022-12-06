using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BigDLL4221.Models;
using BigDLL4221.Utils;
using LOR_DiceSystem;


namespace AphoExtraCombatPages
{
    public static class AphoExtraCombatPages
    {
        public static string PackageId = "AphoExtraCombatPages";
        public static string Path;
    }
    public class AphoExtraCombatPagesInit : ModInitializer
    {
        public override void OnInitializeMod()
        {
            OnInitParameters();
            ArtUtil.GetArtWorks(new DirectoryInfo(AphoExtraCombatPages.Path + "/ArtWork"));
            ArtUtil.PreLoadBufIcons();
            CardUtil.ChangeCardItem(ItemXmlDataList.instance, AphoExtraCombatPages.PackageId);
            KeypageUtil.ChangeKeypageItem(Singleton<BookXmlList>.Instance, AphoExtraCombatPages.PackageId);
            PassiveUtil.ChangePassiveItem(AphoExtraCombatPages.PackageId);
            LocalizeUtil.AddGlobalLocalize(AphoExtraCombatPages.PackageId);
            LocalizeUtil.RemoveError();
            CardUtil.InitKeywordsList(new List<Assembly> { Assembly.GetExecutingAssembly() });
            ArtUtil.InitCustomEffects(new List<Assembly> { Assembly.GetExecutingAssembly() });
            CustomMapHandler.ModResources.CacheInit.InitCustomMapFiles(Assembly.GetExecutingAssembly());

            //BinahDegraded
            ReplaceCardInfo(new LorId(607201), new LorId(AphoExtraCombatPages.PackageId, 607201));
            ReplaceCardInfo(new LorId(607202), new LorId(AphoExtraCombatPages.PackageId, 607202));
            ReplaceCardInfo(new LorId(607203), new LorId(AphoExtraCombatPages.PackageId, 607203));
            ReplaceCardInfo(new LorId(607204), new LorId(AphoExtraCombatPages.PackageId, 607204));
            ReplaceCardInfo(new LorId(607205), new LorId(AphoExtraCombatPages.PackageId, 607205));

            //Roland
            ReplaceCardInfo(new LorId(702001), new LorId(AphoExtraCombatPages.PackageId, 702001));
            ReplaceCardInfo(new LorId(702002), new LorId(AphoExtraCombatPages.PackageId, 702002));
            ReplaceCardInfo(new LorId(702003), new LorId(AphoExtraCombatPages.PackageId, 702003));
            ReplaceCardInfo(new LorId(702004), new LorId(AphoExtraCombatPages.PackageId, 702004));
            ReplaceCardInfo(new LorId(702005), new LorId(AphoExtraCombatPages.PackageId, 702005));
            ReplaceCardInfo(new LorId(702006), new LorId(AphoExtraCombatPages.PackageId, 702006));
            ReplaceCardInfo(new LorId(702007), new LorId(AphoExtraCombatPages.PackageId, 702007));
            ReplaceCardInfo(new LorId(702008), new LorId(AphoExtraCombatPages.PackageId, 702008));
            ReplaceCardInfo(new LorId(702009), new LorId(AphoExtraCombatPages.PackageId, 702009));

            //Binah
            ReplaceCardInfo(new LorId(706201), new LorId(AphoExtraCombatPages.PackageId, 706201));
            ReplaceCardInfo(new LorId(706202), new LorId(AphoExtraCombatPages.PackageId, 706202));
            ReplaceCardInfo(new LorId(706203), new LorId(AphoExtraCombatPages.PackageId, 706203));
            ReplaceCardInfo(new LorId(706204), new LorId(AphoExtraCombatPages.PackageId, 706204));
            ReplaceCardInfo(new LorId(706205), new LorId(AphoExtraCombatPages.PackageId, 706205));
        }
        private static void OnInitParameters()
        {
            ModParameters.PackageIds.Add(AphoExtraCombatPages.PackageId);
            AphoExtraCombatPages.Path = Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));
            ModParameters.Path.Add(AphoExtraCombatPages.PackageId, AphoExtraCombatPages.Path);
            OnInitRewards();
        }
        internal static void ReplaceCardInfo(LorId oldId, LorId newId)
        {
            DiceCardXmlInfo diceCardXmlInfo = ItemXmlDataList.instance.GetCardList().Find((DiceCardXmlInfo x) => x.id == newId);
            bool flag = ItemXmlDataList.instance.GetCardList().Exists((DiceCardXmlInfo x) => x.id == oldId) && diceCardXmlInfo != null;
            if (flag)
            {
                ItemXmlDataList.instance.GetCardItem(oldId, false).optionList = diceCardXmlInfo.optionList;
                //ItemXmlDataList.instance.GetCardItem(oldId, false).Keywords = diceCardXmlInfo.Keywords;
            }
        }
        private static void OnInitRewards()
        {
            ModParameters.StartUpRewardOptions.Add(new RewardOptions(cards: new Dictionary<LorId, int>
            {
                //Tomerry
                { new LorId(405003), 999 },
                { new LorId(405004), 999 },
                { new LorId(405005), 999 },
                { new LorId(405006), 999 },
                { new LorId(405007), 999 },
                { new LorId(405008), 999 },
                { new LorId(405011), 999 },
                { new LorId(405012), 999 },

                //EmmaNoah
                { new LorId(503005), 999 },
                { new LorId(503006), 999 },
                { new LorId(503007), 999 },
                { new LorId(503008), 999 },

                //CryingChild
                //{ new LorId(508002), 999 }, //Wound of Sorrow
                { new LorId(508003), 999 }, //Distorted Illusion
                { new LorId(508004), 999 }, //Bygone Illusion
                //{ new LorId(508005), 999 }, //Restrain
                //{ new LorId(508006), 999 }, //Murmur
                //{ new LorId(508007), 999 }, //Wing Stroke
               // { new LorId(508008), 999 }, //Vicitimize 

                //Phillip
                { new LorId(707101), 999 }, //Dcourage


                //BlueSicko
                //{ new LorId(604021), 999 }, //Trails of Blue
                //{ new LorId(604022), 999 }, //Preludio
                { new LorId(604024), 999 }, //Scout

                //BlueSicko2
                { new LorId(703002), 999 },//Assolo
                { new LorId(703003), 999 },//Dissonance
                { new LorId(703004), 999 },//Scythe Slash
                { new LorId(703005), 999 },//Unhinged Melodia
                { new LorId(703011), 999 },//Sequential Blitz
                //Skip Trails of Blue, there's already a player version
                //DBlueSicko
                { new LorId(707002), 999 },
                { new LorId(707003), 999 },

                //Eileen
                { new LorId(703201), 999 },
                { new LorId(703202), 999 },
                { new LorId(703203), 999 },
                //DEileen
                { new LorId(707201), 999 },
                { new LorId(707202), 999 },
                { new LorId(707203), 999 },
                { new LorId(707204), 999 },
                { new LorId(707205), 999 },

                //Greta
                { new LorId(703311), 999 }, //Slap and Fold
                { new LorId(703313), 999 }, //Break an Egg
                { new LorId(703314), 999 }, //Season
               //Mince already has player version
                //DGreta
                { new LorId(707301), 999 },
                { new LorId(707302), 999 },
                { new LorId(707303), 999 },
                { new LorId(707304), 999 },

                //Musicians
                { new LorId(703411), 999 },
                { new LorId(703412), 999 },
                { new LorId(703413), 999 },
                { new LorId(703414), 999 },
                { new LorId(703416), 999 }, //Neigh
                { new LorId(703421), 999 }, //Powerful Tendon Chords
                { new LorId(703422), 999 }, //Everlasting Melody
                { new LorId(703423), 999 }, //Dark Shrine to Music
                { new LorId(703424), 999 }, //Explosive Tempo
                { new LorId(703425), 999 }, //Trio
                //Dmusicians
                { new LorId(707401), 999 },
                { new LorId(707402), 999 },
                { new LorId(707403), 999 },
                { new LorId(707404), 999 },
                { new LorId(707405), 999 },

                //Clowns
                { new LorId(703511), 999 }, //Casual Toss
                { new LorId(703514), 999 }, //Knife Barrage
                { new LorId(703521), 999 }, //AriaEncourage
                { new LorId(703522), 999 }, //AriaAuspice
                { new LorId(703523), 999 }, //AriaCourage
                //DClown
                { new LorId(707508), 999 }, //Don't Resist
                { new LorId(707510), 999 }, //FANFARE!!!

                //Tanya
                { new LorId(703601), 999 }, //Fisticufs (NOTE: Duplicated, only give 1)
                { new LorId(703602), 999 }, //Kicks and stomps (duplicated)
                { new LorId(703611), 999 }, //Lupine Onslaught (duplicated)

                //Puppeteer
                { new LorId(703717), 999 },
                { new LorId(703718), 999 },
                { new LorId(703719), 999 },
                //DPuppeteer
                { new LorId(707705), 999 },
                { new LorId(707706), 999 },
                { new LorId(707707), 999 },

                //Elena/VC
                { new LorId(703802), 999 }, //Siphon
                { new LorId(703804), 999 }, //Inject
                { new LorId(703811), 999 }, //CrossBlade
                { new LorId(703812), 999 }, //Shockwave
                { new LorId(703813), 999 }, //HeatedWeapon
                //Delena
                { new LorId(707802), 999 }, //Regurgitation
                { new LorId(707804), 999 }, //Absorb

                //Pluto
                { new LorId(703911), 999 },
                { new LorId(703912), 999 },
                { new LorId(703913), 999 },
                { new LorId(703914), 999 },

                //Dpluto
                { new LorId(707904), 999 },
                { new LorId(707905), 999 },
                { new LorId(707922), 999 },


                //LIBRARIANS
                //BinahDegraded
                { new LorId(607201), 999 },
                { new LorId(607202), 999 },
                { new LorId(607203), 999 },
                { new LorId(607204), 999 },
                { new LorId(607205), 999 },

                //Roland
                { new LorId(702001), 999 },
                { new LorId(702002), 999 },
                { new LorId(702003), 999 },
                { new LorId(702004), 999 },
                { new LorId(702005), 999 },
                { new LorId(702006), 999 },
                { new LorId(702007), 999 },
                { new LorId(702008), 999 },
                { new LorId(702009), 999 },

                //Binah
                { new LorId(706201), 999 },
                { new LorId(706202), 999 },
                { new LorId(706203), 999 },
                { new LorId(706204), 999 },
                { new LorId(706205), 999 },

                //ABNO
                { new LorId(900101), 999 }, //Depression
                { new LorId(900102), 999 }, //PaleHands
                { new LorId(900202), 999 }, //Beats of Aspiration
                { new LorId(900701), 999 }, //Today's Expression
                { new LorId(900801), 999 }, //Sanguine Desire
                { new LorId(902001), 999 }, //Vigilance
                { new LorId(902201), 999 }, //TheQuiet (Dupe)
                { new LorId(902202), 999 }, //GuidingHand (Ver 1)
                { new LorId(902211), 999 }, //Tranquility (Dupe)

            }));
        }
    }
}
