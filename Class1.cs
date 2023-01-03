using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using BigDLL4221.Models;
using BigDLL4221.Utils;


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
        }
        private static void OnInitParameters()
        {
            ModParameters.PackageIds.Add(AphoExtraCombatPages.PackageId);
            AphoExtraCombatPages.Path = Path.GetDirectoryName(Uri.UnescapeDataString(new UriBuilder(Assembly.GetExecutingAssembly().CodeBase).Path));
            ModParameters.Path.Add(AphoExtraCombatPages.PackageId, AphoExtraCombatPages.Path);
            OnInitRewards();
        }
        
        private static void OnInitRewards()
        {
            ModParameters.StartUpRewardOptions.Add(new RewardOptions(cards: new Dictionary<LorId, int>
            {
                //Tomerry
                { new LorId(405003), 999 }, //SharpPommellin OK
                { new LorId(405004), 999 }, //HeavyP OK
                { new LorId(405005), 999 }, //PointedP OK
                { new LorId(405006), 999 }, //SharpRam OK
                { new LorId(405007), 999 }, //HeavyR OK
                { new LorId(405008), 999 }, //PointedR OK
                { new LorId(405011), 999 }, //Let'sPlay OK
                { new LorId(405012), 999 }, //LoveTownWelcomesAll OK

                //EmmaNoah
                { new LorId(503005), 999 }, //LionClaws OK
                { new LorId(503006), 999 }, //UnicycleAct OK
                { new LorId(503007), 999 }, //BulkyCharge OK
                { new LorId(503008), 999 }, //LetShowBegin OK

                //CryingChild
                //{ new LorId(508002), 999 }, //Wound of Sorrow 1 UNUSED - 2/3 is better
                { new LorId(508003), 999 }, //Distorted Illusion OK
                { new LorId(508004), 999 }, //Bygone Illusion OK
                { new LorId(508005), 999 }, //Restrain 1 OK
                { new LorId(508006), 999 }, //Murmur 1 OK
                { new LorId(508007), 999 }, //Wing Stroke 1 OK
                { new LorId(508008), 999 }, //Vicitimize 1 OK
                //Phillip
                { new LorId(703112), 999 }, //Conflicting Emotions OK
                { new LorId(703113), 999 }, //Despairingly Stigmatize OK
                { new LorId(703114), 999 }, //Searing Resolution OK
                { new LorId(703115), 999 }, //Fierce Spirit counter
                { new LorId(703116), 999 }, //Combusting Courage OK
                { new LorId(703117), 999 }, //Restrain 2 OK
                { new LorId(703118), 999 }, //Wound of Sorrow 2 OK
                { new LorId(703122), 999 }, //Wing Stroke 2 OK
                { new LorId(703123), 999 }, //Victimize 2 OK
                //DPhillip
                { new LorId(707101), 999 }, //Dcourage OK
                //{ new LorId(707103), 999 }, //Restrain 3 ISSUE - status does nothing?
                { new LorId(707104), 999 }, //Wound of Sorrow 3 OK

                //BS
                { new LorId(702102), 999 }, //BiteOfFlesh OK
                { new LorId(702103), 999 }, //TailSwipe OK
                { new LorId(702104), 999 }, //Amalgamated Sinews OK
                { new LorId(702105), 999 }, //Spiky Tendrils OK
                { new LorId(702108), 999 }, //Gnaw OK
                //Memory
                { new LorId(702301), 999 }, //yun OK
                { new LorId(702302), 999 }, //dawn OK
                { new LorId(702303), 999 }, //zwei OK
                { new LorId(702304), 999 }, //lovetown OK
                { new LorId(702305), 999 }, //liu OK
                { new LorId(702306), 999 }, //shi OK
                { new LorId(702307), 999 }, //hana OK
                { new LorId(702308), 999 }, //pt OK
                { new LorId(702309), 999 }, //br OK

                { new LorId(702310), 999 }, //rage OK
                { new LorId(702311), 999 }, //sorrow OK
                { new LorId(702312), 999 }, //void OK
                { new LorId(702315), 999 }, //conflict OK
                { new LorId(702316), 999 }, //agony counter
                { new LorId(702320), 999 }, //willpower OK
                //Angelica
                { new LorId(705213), 999 }, //Zelkova Workshop OK
                { new LorId(705214), 999 }, //Allas Workshop OK
                { new LorId(705215), 999 }, //Atelier Logic OK
                { new LorId(705216), 999 }, //Wheels Industry

                //Final
                { new LorId(706001), 999 }, //Trail OK
                { new LorId(706002), 999 }, //Extirpation OK
                { new LorId(706003), 999 }, //Serum R OK
                { new LorId(706004), 999 }, //Serum W OK
                { new LorId(706005), 999 }, //Tri Serum Cocktail OK
                //{ new LorId(706006), 999 }, //Serum K BUG - visual bug next scene
                //{ new LorId(706011), 999 }, //Thin Line BUG - Only Page, wrong keyword
                { new LorId(706012), 999 }, //Line OK
                { new LorId(706013), 999 }, //ThickLine OK
                { new LorId(706014), 999 }, //Shockwave OK
                { new LorId(706015), 999 }, //birdcage OK

                //BlueSicko
                //{ new LorId(604021), 999 }, //Trails of Blue
                { new LorId(604022), 999 }, //Preludio OK
                { new LorId(604024), 999 }, //Scout OK

                //BlueSicko2
                { new LorId(703002), 999 },//Assolo OK
                { new LorId(703003), 999 },//Dissonance OK
                { new LorId(703004), 999 },//Scythe Slash OK
                { new LorId(703005), 999 },//Unhinged Melodia OK
                { new LorId(703011), 999 },//Sequential Blitz OK
                //Skip Trails of Blue, there's already a player version
                //DBlueSicko
                { new LorId(707002), 999 }, //Oscillating Sickle OK
                { new LorId(707003), 999 }, //Cleave OK

                //Eileen
                { new LorId(703201), 999 }, //TG Accel OK
                { new LorId(703202), 999 }, //TG Preach OK
                { new LorId(703203), 999 }, //TG Propagate OK
                //DEileen
                { new LorId(707201), 999 }, //TG Fortell OK
                { new LorId(707202), 999 }, //TG Combust OK 
                { new LorId(707203), 999 }, //TG Oxide Overflow
                { new LorId(707204), 999 }, //MG Smoke Cycle OK
                { new LorId(707205), 999 }, //MG Imbue OK

                //Greta
                { new LorId(703311), 999 }, //Slap and Fold OK
                { new LorId(703313), 999 }, //Break an Egg OK
                { new LorId(703314), 999 }, //Season OK
               //Mince already has player version
                //DGreta
                { new LorId(707301), 999 }, //Powsowdie Slam OK
                { new LorId(707302), 999 }, //Tail Whisk OK
                { new LorId(707303), 999 }, //Hunting Hour OK
                { new LorId(707304), 999 }, //Roundhouse Tail OK

                //Musicians
                { new LorId(703411), 999 }, //Rarf RARF RARF!! OK
                { new LorId(703412), 999 }, //Barkruff! BARK~!!! OK
                { new LorId(703413), 999 }, //BAWKBAWKBAWK!!! OK
                { new LorId(703414), 999 }, //Cockadoodledoo~!!!! OK
                { new LorId(703416), 999 }, //Neiiigh~!!! OK
                { new LorId(703421), 999 }, //Powerful Tendon Chords OK
                { new LorId(703422), 999 }, //Everlasting Melody OK
                { new LorId(703423), 999 }, //Dark Shrine to Music OK
                { new LorId(703424), 999 }, //Explosive Tempo OK
                { new LorId(703425), 999 }, //Trio OK
                //Dmusicians
                { new LorId(707401), 999 }, //Menacing Noise OK
                { new LorId(707402), 999 }, //Concerto OK
                { new LorId(707403), 999 }, //Fanciful Tune OK
                { new LorId(707404), 999 }, //Music Therapy OK
                { new LorId(707405), 999 }, //Wohlklang OK

                //Clowns
                { new LorId(703502), 999 }, //Readyforsurprise red OK
                { new LorId(703503), 999 }, //Pow Kablammo 

                { new LorId(703511), 999 }, //Casual Toss OK
                { new LorId(703514), 999 }, //Knife Barrage OK
                { new LorId(703521), 999 }, //AriaEncourage OK
                { new LorId(703522), 999 }, //AriaAuspice OK
                { new LorId(703523), 999 }, //AriaCourage OK
                { new LorId(703524), 999 }, //Horrendous Pitch OK
                //DClown
                { new LorId(707508), 999 }, //Don't Resist OK
                { new LorId(707510), 999 }, //FANFARE!!! OK

                //Tanya
                { new LorId(703601), 999 }, //Fisticufs (NOTE: Duplicated, only give 1) OK
                { new LorId(703602), 999 }, //Kicks and stomps (duplicated) OK
                { new LorId(703611), 999 }, //Lupine Onslaught (duplicated) OK

                //Puppeteer
                { new LorId(703717), 999 }, //Grgh.. OK
                { new LorId(703718), 999 }, //Gh..Gigi..Gig OK
                { new LorId(703719), 999 }, //Uu…Ghghgh… OK
                //DPuppeteer
                { new LorId(707705), 999 }, //NeedleWork OK
                { new LorId(707706), 999 }, //Backstich OK
                { new LorId(707707), 999 }, //Cripple OK

                //Elena/VC
                { new LorId(703802), 999 }, //Siphon OK
                { new LorId(703804), 999 }, //Inject OK
                { new LorId(703811), 999 }, //CrossBlade OK
                { new LorId(703812), 999 }, //Shockwave OK
                { new LorId(703813), 999 }, //HeatedWeapon OK
                //Delena
                { new LorId(707802), 999 }, //Regurgitation OK
                { new LorId(707804), 999 }, //Absorb OK

                //Pluto
                { new LorId(703911), 999 }, //Mdeflect OK
                { new LorId(703912), 999 }, //MMissile OK
                { new LorId(703913), 999 }, //Monslaught OK
                { new LorId(703914), 999 }, //MSafeguard OK
                { new LorId(703918), 999 }, //Deluge of Brachial Quietuses OK

                //Dpluto
                { new LorId(707904), 999 }, //MImpact OK
                { new LorId(707905), 999 }, //Mspear OK
                { new LorId(707922), 999 }, //shaded assault OK


                

                //ABNO
                //History
                { new LorId(900303), 999 }, //FourthMatch OK
                { new LorId(901103), 999 }, //Predation (v1) OK
                { new LorId(9901303), 999 }, //Predation (v2) OK
                { new LorId(901105), 999 }, //Gluttony (v1) OK
                { new LorId(9901306), 999 }, //Gluttony (v2) OK
                { new LorId(902001), 999 }, //Vigilance OK

                //{ new LorId(9901501), 999 }, //GreenStems BUGGED - unusable
                { new LorId(9901502), 999 }, //Vines Fraught with Spite OK
                { new LorId(9901503), 999 }, //Vines Entwined with Delusion OK
                { new LorId(9901504), 999 }, //Encroaching Malice OK
                { new LorId(9901505), 999 }, //Crumbling Life OK

                //TechSc
                //{ new LorId(9902103), 999 }, //Ends, Begins, Ends BUGGED - chance to softlock if used consecutively

                { new LorId(9902201), 999 }, //Charge Mk2 OK
                { new LorId(9902202), 999 }, //Rest Mk2 OK
                { new LorId(9902203), 999 }, //Clean Mk2 OK
                //{ new LorId(9902204), 999 }, //Disable Limiter BUGGED - user does not become staggered

                { new LorId(9902301), 999 }, //Grind OK
                { new LorId(9902302), 999 }, //Tiny Performance OK
                { new LorId(9902303), 999 }, //Let's create a song OK
                { new LorId(9902304), 999 }, //Harmony of Despair OK
                { new LorId(901402), 999 }, //Shaking Blow 1 OK
                { new LorId(9902306), 999 }, //Shaking Blow 2 OK

                { new LorId(902201), 999 }, //TheQuiet (Dupe) OK
                { new LorId(902202), 999 }, //GuidingHand (Ver 1) OK
                { new LorId(902211), 999 }, //Tranquility (Dupe) OK
                { new LorId(902212), 999 }, //LiberationFromAnger (Dupe) OK
                { new LorId(902213), 999 }, //LiberationFromPain (Dupe) OK
                { new LorId(902214), 999 }, //LiberationFromObsession (Dupe) OK

                //{ new LorId(9902507), 999 }, //BulletOfDespair BUGGED - Description wrong, it is not mass
                //freischutz
                { new LorId(920002), 999 }, //Floodingbullet OK
                { new LorId(920003), 999 }, //Magicbullet OK
                { new LorId(920004), 999 }, //silentbullet OK
                { new LorId(920005), 999 }, //inevitablebullet OK
                { new LorId(9902510), 999 }, //magicbullet 2 (dupe) OK
                { new LorId(1100005), 999 }, //request OK

                //Lit
                { new LorId(900701), 999 }, //Today's Expression OK
                { new LorId(900801), 999 }, //Sanguine Desire OK
                { new LorId(9903203), 999 }, //Bursting Desire (v2) OK

                { new LorId(902412), 999 }, //Dontgethurt(Dupe) OK
                { new LorId(902413), 999 }, //letshavefun(Dupe) OK
                { new LorId(902431), 999 }, //#$@!#*#$@ (Dupe) OK
                { new LorId(902432), 999 }, //!?$%@!?!! (Dupe) OK
                

                //Art
                { new LorId(9904203), 999 }, //Waiting (v2) OK
                { new LorId(901003), 999 }, //Glimmer (v1) OK
                { new LorId(9904205), 999 }, //Glimmer (v2) OK

                { new LorId(902601), 999 }, //Full Bloom (Ver1) OK
                { new LorId(902602), 999 }, //SpringGenesis (Ver1) OK
                { new LorId(902603), 999 }, //Autumn Passing (Dupe, same effect but diff rarity) OK
                { new LorId(902611), 999 }, //Mound of Flowers (Dupe) OK
                { new LorId(9904422), 999 }, //Crack in heart v2 OK
                { new LorId(902613), 999 }, //Entangling Despair (Dupe, same effect but diff rarity) OK

                //NatSc
                { new LorId(901602), 999 }, //With Love! (v1/Dupe) OK
                { new LorId(9905612), 999 }, //With Love! (v2) OK
                { new LorId(9905103), 999 }, //In the name of justice (v1) OK
                { new LorId(9905104), 999 }, //love/justice (v2) OK
                //{ new LorId(901605), 999 }, //arcana slave 1 (Single use) BUGGED - No animation
                //{ new LorId(901608), 999 }, //arcana slave (v2) BUGGED - No animation
                { new LorId(9905112), 999 }, //light of hatred(v2) OK
                { new LorId(9905113), 999 }, //In the name of Love and Hate(v2) OK
                //{ new LorId(9905105), 999 }, //Arcana slave! BUGGED - No animation, single use?
                { new LorId(9905514), 999 }, //Arcana slave (black, reuse) OK

                // { new LorId(9905211), 999 }, //Sword Sharpened with Tear(v2) BUGGED - Excessive screen movement
                //{ new LorId(9905212), 999 }, //Sword Laced with Grief(v2) BUGGED - Excessive screen movement
                { new LorId(901704), 999 }, //Weathered Pride (v1) OK
                { new LorId(9905521), 999 }, //HeartPiercing OK
                { new LorId(9905522), 999 }, //Hearttearing OK
                { new LorId(9905523), 999 }, //Heartbreaking OK

                { new LorId(902503), 999 }, //Ecstasy of Triumph (Dupe) OK
                { new LorId(9905311), 999 }, //Hunger (v2) OK
                { new LorId(9905312), 999 }, //Edacity (v2) OK
                { new LorId(9905313), 999 }, //Consuming Desire OK
                { new LorId(9905544), 999 }, //EMBODIMENTS OF EVIL!!! OK
                { new LorId(9905644), 999 }, //For the Justice and Balance of this Land! OK

                
                { new LorId(9905641), 999 }, //I’ll Protect My Friend
                { new LorId(9905642), 999 }, //If I Can be of Help!
                { new LorId(9905643), 999 }, //I Can’t Lose Here Counter
                { new LorId(950411), 999 }, //Grrhrrr! (Dupe) OK
                { new LorId(950412), 999 }, //AAACK!! (Ver 1) OK
                { new LorId(950413), 999 }, //Aaah! (Dupe) Counter Only
                { new LorId(950423), 999 }, //Kindly Make Way (Dupe) OK
                { new LorId(950424), 999 }, //Dear Companion…! (Dupe) OK
                { new LorId(950425), 999 }, //You Shall Fall! (Dupe) OK

                //Lang
                //redhood
                { new LorId(607001), 999 }, //greater split : Horizontal

                { new LorId(901801), 999 }, //catch breath 1 OK
                { new LorId(9906101), 999 }, //catch breath 2 OK
                { new LorId(901802), 999 }, //Beast Hunt 1 OK
                { new LorId(920104), 999 }, //Beast Hunt 2 OK
                { new LorId(9906103), 999 }, //Beast Hunt 3 OK
                { new LorId(920102), 999 }, //Strike without hestitation OK
                { new LorId(920103), 999 }, //bullet shower OK
                { new LorId(920105), 999 }, //hollow point shell OK

                { new LorId(902301), 999 }, //PointyClaws (Ver1) OK
                { new LorId(902302), 999 }, //Grr... OK
                { new LorId(902304), 999 }, //Wolf! Wolf! Counter Only
                { new LorId(9906211), 999 }, //Unsparing Ungues 2 OK
                { new LorId(9906214), 999 }, //Ambush 2 OK

                { new LorId(9906301), 999 }, //Devour 2 OK
                { new LorId(9906303), 999 }, //Horrid Screech 2 OK
                { new LorId(9906304), 999 }, //Vomit 2 OK
                { new LorId(960304), 999 }, //Flop Down 1 OK
                { new LorId(9906305), 999 }, //Flop Down 2 OK

                { new LorId(9906422), 999 }, //Digging Teeth 2 OK
                { new LorId(9906431), 999 }, //Looming Presence 2 OK

                { new LorId(9906501), 999 }, //DenseFlesh OK
                { new LorId(9906502), 999 }, //EyeContact 
                { new LorId(9906503), 999 }, //ReachingHand OK
                { new LorId(9906511), 999 }, //HardCocoon OK
                { new LorId(9906521), 999 }, //Follow OK
                { new LorId(9906522), 999 }, //Flail Skin OK
                { new LorId(9906524), 999 }, //Hi OK
                { new LorId(9906525), 999 }, //Bye OK

                //SocSc
                { new LorId(9907111), 999 }, //Squeak, Creak OK
                { new LorId(9907114), 999 }, //Reap the Rice OK
                { new LorId(9907115), 999 }, //Harvest OK
                { new LorId(9907121), 999 }, //Till Soil OK

                //{ new LorId(902101), 999 }, //Empty Chest 1 Instakill does not work
                { new LorId(9907216), 999 }, //Empty Chest 2 Counter Only
                { new LorId(902106), 999 }, //Lumber1 OK
                { new LorId(902107), 999 }, //Help Me! OK
                { new LorId(970324), 999 }, //Play Tag! (Dupe) OK
                { new LorId(970334), 999 }, //Alertness (Dupe) OK
                { new LorId(970413), 999 }, //Squash OK
                { new LorId(9907213), 999 }, //Cozy Beating OK
                { new LorId(9907214), 999 }, //Boisterous Ringing OK
                
                { new LorId(9907413), 999 }, //Earnest Mind OK
                { new LorId(9907414), 999 }, //Begone, Silently OK
                { new LorId(9907515), 999 }, //Welcoming Salutations OK
                { new LorId(9907516), 999 }, //That's not it OK


                { new LorId(9907511), 999 }, //Brimming Light OK
                { new LorId(9907512), 999 }, //How Noisy OK
                { new LorId(9907513), 999 }, //please be gentle OK
                { new LorId(9907514), 999 }, //Behave Yourself, Will You? OK
                
                //{ new LorId(9907631), 999 },//Courage BUGGED - gives 10 str instead of 5
                //{ new LorId(9907641), 999 },//FriendDontBeHurt BUGGED - only work on foes
                //{ new LorId(9907642), 999 },//StrongerTogether BUGGED - only work on foes
                { new LorId(9907652), 999 },//HelpmeJack OK

                //Philosophy
                { new LorId(9908121), 999 }, //Ocular Stab 2 OK
                { new LorId(9908122), 999 }, //Nip 2 OK
                { new LorId(980222), 999 }, //ring 1 OK
                //{ new LorId(9908222), 999 }, //ring 2 BUGGED - break speed dice doesnt work?
                { new LorId(980313), 999 }, //stare 1 counter only
                { new LorId(9908316), 999 }, //stare 2 OK
                { new LorId(9908322), 999 }, //Piercing Shriek 2 OK

                { new LorId(9908212), 999 }, //Rapid Flutters OK
                { new LorId(9908214), 999 }, //PUNISHMENT!! OK
                { new LorId(9908223), 999 }, //Pinioning OK
                { new LorId(9908314), 999 }, //ForPeace OK
                { new LorId(9908315), 999 }, //Unjust Scale OK
                { new LorId(9908321), 999 }, //Terrified Flutter 2 OK
                { new LorId(9908513), 999 }, //Prowl OK
                { new LorId(9908514), 999 }, //Light Illuminating the Forest OK
                { new LorId(9908531), 999 }, //TiltedScale OK
                { new LorId(9908532), 999 }, //Adjudication OK
                { new LorId(9908541), 999 }, //TornMouth OK
                { new LorId(9908542), 999 }, //Comeuppance OK
                
                { new LorId(9908114), 999 }, //Darkness OK
                { new LorId(9908516), 999 }, //Peaceforall OK

                //Religion
                //All counter only
                { new LorId(980101), 999 }, //Burrowing Gaze
                { new LorId(980102), 999 }, //Lean Pinions 
                { new LorId(980103), 999 }, //Bloody Wings
                { new LorId(980111), 999 }, //Bony Barbs
                { new LorId(980112), 999 }, //Scarlet Spikes
                { new LorId(980113), 999 }, //Outstretching Thorns

                { new LorId(990322), 999 }, //Our Faith is Never Wrong OK
                { new LorId(990323), 999 }, //We’re All Sinners OK
                { new LorId(990324), 999 }, //Hear the Sound of the Star! OK
                { new LorId(990325), 999 }, //We’ll Soon Meet as Stars!!! OK
                
                { new LorId(920201), 999 }, //Fear Thou Not 1 OK
                { new LorId(9909111), 999 }, //Fear Thou Not 2 OK
                { new LorId(920301), 999 }, //Thou art His Son 1
                { new LorId(9909121), 999 }, //Thou art His Son 2 OK
                { new LorId(920302), 999 }, //Thou art the king 1
                { new LorId(9909122), 999 }, //Thou art the king 2 OK
                { new LorId(920303), 999 }, //Wilt thou that We Command Fire? 1 OK
                { new LorId(9909123), 999 }, //Wilt thou that We Command Fire? 2 OK
                { new LorId(920501), 999 }, //Thou wilt Light My Candle 1 OK
                { new LorId(9909141), 999 }, //Thou wilt Light My Candle 2 OK
                { new LorId(920401), 999 }, //I will Follow Thee1 OK
                { new LorId(9909131), 999 }, //I will Follow Thee2 OK
                { new LorId(920402), 999 }, //Thy Will be Done 1 OK
                { new LorId(9909132), 999 }, //Thy Will be Done 2 OK
                { new LorId(920502), 999 }, //Thy Words 1 OK
                { new LorId(9909142), 999 }, //Thy Words 2 OK
                { new LorId(9909144), 999 }, //You hath not Left Me Alone OK
                { new LorId(9909152), 999 }, //The Will of the Lord be Done 2 OK
                { new LorId(920202), 999 }, //Benediction OK
                { new LorId(920203), 999 }, //I am thy savior OK
                { new LorId(920204), 999 }, //Behold My Power OK
                { new LorId(920403), 999 }, //I shall preserve thee OK
                { new LorId(920503), 999 }, //Give us rest OK
                { new LorId(920601), 999 }, //For he is holy OK
                //{ new LorId(9909114), 999 }, //Do Not Deny Me ISSUE - Only works on players

                //GenWorks
                { new LorId(900101), 999 }, //Depression OK
                { new LorId(900102), 999 }, //PaleHands OK
                { new LorId(900202), 999 }, //Beats of Aspiration OK
                //{ new LorId(9910204), 999 }, //Beats of Aspiration 2 BUG - Does not full heal; only heals 80

                { new LorId(9910401), 999 }, //Icesplinters 2 OK
                { new LorId(9910402), 999 }, //1stkiss 2 OK 
                { new LorId(9910403), 999 }, //2ndkiss 2 OK
                { new LorId(902904), 999 }, //FrigidGaze 1 OK
                { new LorId(9910404), 999 }, //FrigidGaze 2 OK

                { new LorId(9910101), 999 }, //Numbness OK
                { new LorId(9910102), 999 }, //Profound Sorrow OK
                { new LorId(9910411), 999 }, //Crystallize OK
                { new LorId(9910501), 999 }, //LeerAnxiety OK
                { new LorId(9910502), 999 }, //LeerFright OK
                { new LorId(9910503), 999 }, //LeerReproach OK
                //{ new LorId(9910511), 999 }, //Stout Spike ISSUE - buff uses same name, might be confusing
                { new LorId(9910533), 999 }, //Just be honest OK
                

                //Angela
                { new LorId(9910001), 999 }, //Shyness OK
                { new LorId(9910002), 999 }, //TokenofFriendship OK
                { new LorId(9910003), 999 }, //Lean, Bloody Wings OK
                { new LorId(9910004), 999 }, //Display OK 
                { new LorId(9910005), 999 }, //Coffin OK

            }));
        }
    }
}
