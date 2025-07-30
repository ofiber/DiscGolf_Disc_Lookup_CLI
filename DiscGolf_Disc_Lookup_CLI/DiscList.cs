using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DiscGolf_Disc_Lookup_CLI
{
    public class DiscList
    {
        public static List<DiscGolfDisc> Discs = new List<DiscGolfDisc>
        {
            new DiscGolfDisc("Delirium", "Axiom Discs", "Distance Driver", 14.5, 5, -0.5, 3),
            new DiscGolfDisc("Excite", "Axiom Discs", "Distance Driver", 14.5, 5.5, -2, 2),
            new DiscGolfDisc("Mayhem", "Axiom Discs", "Distance Driver", 13, 5, -1.5, 2),
            new DiscGolfDisc("Panic", "Axiom Discs", "Distance Driver", 13, 4, -0.5, 3),
            new DiscGolfDisc("Tantrum", "Axiom Discs", "Distance Driver", 14.5, 5, -1.5, 3),
            new DiscGolfDisc("Tenacity", "Axiom Discs", "Distance Driver", 13, 5, -2.5, 2),
            new DiscGolfDisc("Time-Lapse", "Axiom Discs", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("Vanish", "Axiom Discs", "Distance Driver", 11, 5, -3, 2),
            new DiscGolfDisc("Crave", "Axiom Discs", "Fairway Driver", 6.5, 5, -1, 1),
            new DiscGolfDisc("Fireball", "Axiom Discs", "Fairway Driver", 9, 3.5, 0, 3.5),
            new DiscGolfDisc("Insanity", "Axiom Discs", "Fairway Driver", 9, 5, -2, 1.5),
            new DiscGolfDisc("Rhythm", "Axiom Discs", "Fairway Driver", 7, 5, -2, 1),
            new DiscGolfDisc("Virus", "Axiom Discs", "Fairway Driver", 9, 5, -3.5, 1),
            new DiscGolfDisc("Hex", "Axiom Discs", "Mid Range", 5, 5, -1, 1),
            new DiscGolfDisc("Pyro", "Axiom Discs", "Mid Range", 5, 4, 0, 2.5),
            new DiscGolfDisc("Balance", "Axiom Discs", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("Envy", "Axiom Discs", "Putt & Approach", 3, 3, 0, 2),
            new DiscGolfDisc("Pixel", "Axiom Discs", "Putt & Approach", 2, 4, 0, 0.5),
            new DiscGolfDisc("Proxy", "Axiom Discs", "Putt & Approach", 3, 3, -1, 0.5),
            new DiscGolfDisc("Cinnamon", "Clash Discs", "Distance Driver", 9, 5, -1.5, 2),
            new DiscGolfDisc("Pepper", "Clash Discs", "Distance Driver", 11, 5, 0, 4),
            new DiscGolfDisc("Sage", "Clash Discs", "Distance Driver", 12, 6, -1, 3),
            new DiscGolfDisc("Salt", "Clash Discs", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("Spice", "Clash Discs", "Distance Driver", 10, 4, 0, 4),
            new DiscGolfDisc("Vanilla", "Clash Discs", "Distance Driver", 11, 6, -2, 1),
            new DiscGolfDisc("Wild Honey", "Clash Discs", "Distance Driver", 12, 5, -2, 2),
            new DiscGolfDisc("Cookie", "Clash Discs", "Fairway Driver", 7, 5, 0, 2),
            new DiscGolfDisc("Ginger", "Clash Discs", "Fairway Driver", 9, 4, 0, 2),
            new DiscGolfDisc("Lotus", "Clash Discs", "Fairway Driver", 8, 5, -1, 2),
            new DiscGolfDisc("Millet", "Clash Discs", "Fairway Driver", 7, 6, -3, 1),
            new DiscGolfDisc("Soda", "Clash Discs", "Fairway Driver", 7, 5, -2, 2),
            new DiscGolfDisc("Berry", "Clash Discs", "Mid Range", 5, 5, -1, 1),
            new DiscGolfDisc("Cherry", "Clash Discs", "Mid Range", 5, 5, -2, 1),
            new DiscGolfDisc("Guava", "Clash Discs", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("Mango", "Clash Discs", "Mid Range", 5, 4, 0, 4),
            new DiscGolfDisc("Peach", "Clash Discs", "Mid Range", 4, 5, -2, 1),
            new DiscGolfDisc("Butter", "Clash Discs", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Candy", "Clash Discs", "Putt & Approach", 3, 3, -1, 1),
            new DiscGolfDisc("Fudge", "Clash Discs", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Mint", "Clash Discs", "Putt & Approach", 4, 3, 0, 3),
            new DiscGolfDisc("Peppermint", "Clash Discs", "Putt & Approach", 4, 2, 0, 4),
            new DiscGolfDisc("Popcorn", "Clash Discs", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Hurricane", "DGA", "Distance Driver", 12, 5, -1, 2),
            new DiscGolfDisc("Rogue", "DGA", "Distance Driver", 11, 4, -1, 1),
            new DiscGolfDisc("Sail", "DGA", "Distance Driver", 11, 5, -5, 1),
            new DiscGolfDisc("Tempest", "DGA", "Distance Driver", 13, 5, -3, 2),
            new DiscGolfDisc("Torrent", "DGA", "Distance Driver", 14, 5, -1, 2),
            new DiscGolfDisc("Hellfire", "DGA", "Fairway Driver", 10, 3, 0, 5),
            new DiscGolfDisc("Pipeline", "DGA", "Fairway Driver", 8, 5, 0, 2),
            new DiscGolfDisc("Tsunami", "DGA", "Fairway Driver", 10, 3, 0, 4),
            new DiscGolfDisc("Undertow", "DGA", "Fairway Driver", 10, 4, -1, 1),
            new DiscGolfDisc("Aftershock", "DGA", "Mid Range", 4, 3, 0, 2),
            new DiscGolfDisc("Quake", "DGA", "Mid Range", 5, 3, 0, 3),
            new DiscGolfDisc("Shockwave", "DGA", "Mid Range", 4, 2, 0, 3),
            new DiscGolfDisc("Squall", "DGA", "Mid Range", 6, 4, -1, 1),
            new DiscGolfDisc("Bowfly", "DGA", "Putt & Approach", 2, 2, 0, 2),
            new DiscGolfDisc("Breaker", "DGA", "Putt & Approach", 3, 3, 0, 3),
            new DiscGolfDisc("Gumbputt", "DGA", "Putt & Approach", 2, 2, 0, 2),
            new DiscGolfDisc("Reef", "DGA", "Putt & Approach", 2, 2, -1, 1),
            new DiscGolfDisc("Steady", "DGA", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Surf", "DGA", "Putt & Approach", 3, 3, -1, 1),
            new DiscGolfDisc("Titanic", "DGA", "Putt & Approach", 2, 2, 0, 2),
            new DiscGolfDisc("Astronaut", "Discmania", "Distance Driver", 12, 6, -4, 1),
            new DiscGolfDisc("CD3", "Discmania", "Distance Driver", 11, 5, -1, 2),
            new DiscGolfDisc("Cloud Breaker", "Discmania", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("DD1", "Discmania", "Distance Driver", 11, 5, -1, 2),
            new DiscGolfDisc("DD2", "Discmania", "Distance Driver", 13, 5, -2, 2),
            new DiscGolfDisc("DD3", "Discmania", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("DDX", "Discmania", "Distance Driver", 12, 6, -1, 2),
            new DiscGolfDisc("Enigma", "Discmania", "Distance Driver", 12, 5, -1, 2),
            new DiscGolfDisc("Majesty", "Discmania", "Distance Driver", 13, 5, -2, 2),
            new DiscGolfDisc("Mentor", "Discmania", "Distance Driver", 11, 5, -2, 2),
            new DiscGolfDisc("Paradigm", "Discmania", "Distance Driver", 12, 6, -1.5, 2),
            new DiscGolfDisc("PD", "Discmania", "Distance Driver", 10, 4, 0, 3),
            new DiscGolfDisc("PD2", "Discmania", "Distance Driver", 12, 4, 0, 4),
            new DiscGolfDisc("PD3", "Discmania", "Distance Driver", 11, 3, 0, 5),
            new DiscGolfDisc("TD", "Discmania", "Distance Driver", 10, 5, -2, 1),
            new DiscGolfDisc("CD1", "Discmania", "Fairway Driver", 9, 5, -2, 1),
            new DiscGolfDisc("CD2", "Discmania", "Fairway Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Essence", "Discmania", "Fairway Driver", 8, 6, -2, 1),
            new DiscGolfDisc("FD", "Discmania", "Fairway Driver", 7, 6, 0, 1),
            new DiscGolfDisc("FD1", "Discmania", "Fairway Driver", 7, 4, 0, 2),
            new DiscGolfDisc("FD2", "Discmania", "Fairway Driver", 7, 4, 0, 2),
            new DiscGolfDisc("FD3", "Discmania", "Fairway Driver", 9, 4, 0, 3),
            new DiscGolfDisc("Genius", "Discmania", "Fairway Driver", 7, 5, -4, 1),
            new DiscGolfDisc("Glacier", "Discmania", "Fairway Driver", 6, 5, 0, 2),
            new DiscGolfDisc("Instinct", "Discmania", "Fairway Driver", 7, 5, 0, 2),
            new DiscGolfDisc("Magician", "Discmania", "Fairway Driver", 6, 4, 0, 2),
            new DiscGolfDisc("Mermaid", "Discmania", "Fairway Driver", 7, 4, -1, 2),
            new DiscGolfDisc("Rockstar", "Discmania", "Fairway Driver", 8, 5, -2, 1),
            new DiscGolfDisc("Solar Flare", "Discmania", "Fairway Driver", 9, 4, 0, 3),
            new DiscGolfDisc("Splice", "Discmania", "Fairway Driver", 9, 3, 0, 4),
            new DiscGolfDisc("Tilt", "Discmania", "Fairway Driver", 9, 1, 1, 6),
            new DiscGolfDisc("Vanguard", "Discmania", "Fairway Driver", 9, 5, 0, 2),
            new DiscGolfDisc("Maestro", "Discmania", "Mid Range", 4, 3, 0, 2),
            new DiscGolfDisc("MD", "Discmania", "Mid Range", 4, 5, 0, 0),
            new DiscGolfDisc("MD1", "Discmania", "Mid Range", 5, 6, 0, 0),
            new DiscGolfDisc("MD2", "Discmania", "Mid Range", 4, 5, 0, 2),
            new DiscGolfDisc("MD3", "Discmania", "Mid Range", 5, 5, 0, 1),
            new DiscGolfDisc("MD3x", "Discmania", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("MD4", "Discmania", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("MD5", "Discmania", "Mid Range", 5, 3, 0, 4),
            new DiscGolfDisc("Method", "Discmania", "Mid Range", 5, 5, 0, 3),
            new DiscGolfDisc("Mutant", "Discmania", "Mid Range", 5, 3, 0, 4),
            new DiscGolfDisc("Origin", "Discmania", "Mid Range", 5, 5, -1, -1),
            new DiscGolfDisc("Drop", "Discmania", "Putt & Approach", 4, 3, 0, 3),
            new DiscGolfDisc("Link", "Discmania", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Logic", "Discmania", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Notion", "Discmania", "Putt & Approach", 2, 3, -1, 0),
            new DiscGolfDisc("P1", "Discmania", "Putt & Approach", 2, 3, 0, 0),
            new DiscGolfDisc("P1X", "Discmania", "Putt & Approach", 2, 3, 0, 0),
            new DiscGolfDisc("P2", "Discmania", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("P2X", "Discmania", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("P3X", "Discmania", "Putt & Approach", 3, 2, 0, 3),
            new DiscGolfDisc("P4", "Discmania", "Putt & Approach", 4, 3, 0, 2),
            new DiscGolfDisc("Rainmaker", "Discmania", "Putt & Approach", 2, 3, 0.5, 0.5),
            new DiscGolfDisc("Razor Claw", "Discmania", "Putt & Approach", 4, 2, 0, 4),
            new DiscGolfDisc("Sensei", "Discmania", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Shogun", "Discmania", "Putt & Approach", 2, 4, 0, 2),
            new DiscGolfDisc("Spore", "Discmania", "Putt & Approach", 1, 7, 0, 1),
            new DiscGolfDisc("Tactic", "Discmania", "Putt & Approach", 4, 2, 0, 3),
            new DiscGolfDisc("Anax", "Discraft", "Distance Driver", 10, 6, 0, 3),
            new DiscGolfDisc("Avenger", "Discraft", "Distance Driver", 11, 5, 0, 3),
            new DiscGolfDisc("Crank", "Discraft", "Distance Driver", 13, 5, -2, 2),
            new DiscGolfDisc("Crush", "Discraft", "Distance Driver", 11, 5, 0, 4),
            new DiscGolfDisc("Drive", "Discraft", "Distance Driver", 11, 5, -1, 2),
            new DiscGolfDisc("Drive", "Discraft", "Distance Driver", 11, 5, -1, 2),
            new DiscGolfDisc("Flash", "Discraft", "Distance Driver", 10, 5, -2, 3),
            new DiscGolfDisc("Flick", "Discraft", "Distance Driver", 12, 3, 1, 5),
            new DiscGolfDisc("Force", "Discraft", "Distance Driver", 12, 5, 0, 3),
            new DiscGolfDisc("Hades", "Discraft", "Distance Driver", 12, 6, -3, 2),
            new DiscGolfDisc("Heat", "Discraft", "Distance Driver", 9, 6, -3, 1),
            new DiscGolfDisc("Nuke", "Discraft", "Distance Driver", 13, 5, -1, 3),
            new DiscGolfDisc("Pulse", "Discraft", "Distance Driver", 11, 4, 0, 4),
            new DiscGolfDisc("Punisher", "Discraft", "Distance Driver", 12, 5, 0, 3),
            new DiscGolfDisc("Scorch", "Discraft", "Distance Driver", 11, 6, -2, 2),
            new DiscGolfDisc("Spectra", "Discraft", "Distance Driver", 12, 5, -2, 2),
            new DiscGolfDisc("Surge", "Discraft", "Distance Driver", 11, 5, -1, 3),
            new DiscGolfDisc("Surge SS", "Discraft", "Distance Driver", 11, 5, -2, 2),
            new DiscGolfDisc("Thrasher", "Discraft", "Distance Driver", 12, 5, -2, 3),
            new DiscGolfDisc("Undertaker", "Discraft", "Distance Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Venom", "Discraft", "Distance Driver", 13, 5, 0, 3),
            new DiscGolfDisc("XL", "Discraft", "Distance Driver", 7, 4, -2, 1),
            new DiscGolfDisc("XS", "Discraft", "Distance Driver", 8, 5, 0, 3),
            new DiscGolfDisc("Zeus", "Discraft", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("Captain's Raptor", "Discraft", "Fairway Driver", 9, 3, 1, 4),
            new DiscGolfDisc("Athena", "Discraft", "Fairway Driver", 7, 5, 0, 2),
            new DiscGolfDisc("Cicada", "Discraft", "Fairway Driver", 7, 6, -1, 1),
            new DiscGolfDisc("Cyclone", "Discraft", "Fairway Driver", 7, 4, -1, 2),
            new DiscGolfDisc("Glide", "Discraft", "Fairway Driver", 6, 5, -3, 2),
            new DiscGolfDisc("Heat", "Discraft", "Fairway Driver", 9, 6, -3, 1),
            new DiscGolfDisc("Impact", "Discraft", "Fairway Driver", 6, 6, -3, 1),
            new DiscGolfDisc("Mantis", "Discraft", "Fairway Driver", 8, 4, -2, 2),
            new DiscGolfDisc("Passion", "Discraft", "Fairway Driver", 8, 5, -1, 1),
            new DiscGolfDisc("Predator", "Discraft", "Fairway Driver", 9, 4, 1, 4),
            new DiscGolfDisc("Raptor", "Discraft", "Fairway Driver", 9, 4, 0, 3),
            new DiscGolfDisc("Reaper", "Discraft", "Fairway Driver", 8, 3, 0, 4),
            new DiscGolfDisc("Stalker", "Discraft", "Fairway Driver", 7, 5, -1, 2),
            new DiscGolfDisc("Sting", "Discraft", "Fairway Driver", 7, 5, -2, 1),
            new DiscGolfDisc("Tracker", "Discraft", "Fairway Driver", 8, 5, -1, 3),
            new DiscGolfDisc("Vulture", "Discraft", "Fairway Driver", 10, 5, 0, 2),
            new DiscGolfDisc("XL", "Discraft", "Fairway Driver", 7, 4, -2, 1),
            new DiscGolfDisc("Xpress", "Discraft", "Fairway Driver", 8, 5, -3, 1),
            new DiscGolfDisc("Zombee", "Discraft", "Fairway Driver", 6, 4, -1, 1),
            new DiscGolfDisc("Archer", "Discraft", "Mid Range", 5, 4, -4, 1),
            new DiscGolfDisc("Buzzz", "Discraft", "Mid Range", 5, 4, -1, 1),
            new DiscGolfDisc("Buzzz OS", "Discraft", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("Buzzz SS", "Discraft", "Mid Range", 5, 4, -2, 1),
            new DiscGolfDisc("Comet", "Discraft", "Mid Range", 4, 5, -2, 1),
            new DiscGolfDisc("Drone", "Discraft", "Mid Range", 5, 3, 1, 4),
            new DiscGolfDisc("Hawk", "Discraft", "Mid Range", 4, 3, -2, 2),
            new DiscGolfDisc("Hornet", "Discraft", "Mid Range", 5, 5, 0, 4),
            new DiscGolfDisc("Malta", "Discraft", "Mid Range", 5, 4, 1, 3),
            new DiscGolfDisc("Meteor", "Discraft", "Mid Range", 5, 5, -3, 1),
            new DiscGolfDisc("Sol", "Discraft", "Mid Range", 4, 5, -3, 0),
            new DiscGolfDisc("Stratus", "Discraft", "Mid Range", 5, 4, -4, 1),
            new DiscGolfDisc("Swarm", "Discraft", "Mid Range", 5, 3, 0, 4),
            new DiscGolfDisc("Wasp", "Discraft", "Mid Range", 5, 3, 0, 2),
            new DiscGolfDisc("APX", "Discraft", "Putt & Approach", 2, 2, -1, 1),
            new DiscGolfDisc("Banger-GT", "Discraft", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Challenger", "Discraft", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Fierce", "Discraft", "Putt & Approach", 3, 4, -2, 0),
            new DiscGolfDisc("Focus", "Discraft", "Putt & Approach", 2, 2, -1, 2),
            new DiscGolfDisc("Kratos", "Discraft", "Putt & Approach", 3, 3, 0, 3),
            new DiscGolfDisc("MacBeth Luna", "Discraft", "Putt & Approach", 3, 3, 0, 3),
            new DiscGolfDisc("Magnet", "Discraft", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Putt'r", "Discraft", "Putt & Approach", 2, 2, -1, 1),
            new DiscGolfDisc("Rattler", "Discraft", "Putt & Approach", 2, 2, -2, 1),
            new DiscGolfDisc("Ringer", "Discraft", "Putt & Approach", 4, 4, 0, 2),
            new DiscGolfDisc("Roach", "Discraft", "Putt & Approach", 2, 4, 0, 1),
            new DiscGolfDisc("Zone", "Discraft", "Putt & Approach", 4, 3, 0, 3),
            new DiscGolfDisc("Zone OS", "Discraft", "Putt & Approach", 4, 2, 1, 5),
            new DiscGolfDisc("Captain", "Dynamic Discs", "Distance Driver", 13, 5, -2, 2),
            new DiscGolfDisc("Enforcer", "Dynamic Discs", "Distance Driver", 12, 4, 0.5, 4),
            new DiscGolfDisc("Sergeant", "Dynamic Discs", "Distance Driver", 11, 4, 0, 2.5),
            new DiscGolfDisc("Sheriff", "Dynamic Discs", "Distance Driver", 13, 5, -1, 2),
            new DiscGolfDisc("Trespass", "Dynamic Discs", "Distance Driver", 12, 5, -0.5, 3),
            new DiscGolfDisc("Sockibomb General", "Dynamic Discs", "Distance Driver", 12, 4, 0, 4),
            new DiscGolfDisc("Convict", "Dynamic Discs", "Fairway Driver", 9, 4, -0.5, 3),
            new DiscGolfDisc("Escape", "Dynamic Discs", "Fairway Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Felon", "Dynamic Discs", "Fairway Driver", 9, 3, 0.5, 4),
            new DiscGolfDisc("Getaway", "Dynamic Discs", "Fairway Driver", 9, 5, -0.5, 3),
            new DiscGolfDisc("Maverick", "Dynamic Discs", "Fairway Driver", 7, 4, -1.5, 2),
            new DiscGolfDisc("EMAC Truth", "Dynamic Discs", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("Justice", "Dynamic Discs", "Mid Range", 5, 3, 0.5, 4),
            new DiscGolfDisc("Suspect", "Dynamic Discs", "Mid Range", 4, 3, 0, 3),
            new DiscGolfDisc("Verdict", "Dynamic Discs", "Mid Range", 5, 4, 0, 3.5),
            new DiscGolfDisc("Agent", "Dynamic Discs", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Culprit", "Dynamic Discs", "Putt & Approach", 4, 2, 0, 3.5),
            new DiscGolfDisc("Deputy", "Dynamic Discs", "Putt & Approach", 3, 4, -1.5, 0),
            new DiscGolfDisc("Guard", "Dynamic Discs", "Putt & Approach", 2, 5, 0, 0.5),
            new DiscGolfDisc("Judge", "Dynamic Discs", "Putt & Approach", 2, 4, 0, 1),
            new DiscGolfDisc("Slammer", "Dynamic Discs", "Putt & Approach", 3, 2, 0, 3),
            new DiscGolfDisc("Warden", "Dynamic Discs", "Putt & Approach", 3, 2, 0, 3),
            new DiscGolfDisc("Spirit", "Gateway", "Distance Driver", 12, 4, 0, 4),
            new DiscGolfDisc("Assassin", "Gateway", "Fairway Driver", 9, 6, -1, 1),
            new DiscGolfDisc("Spear", "Gateway", "Fairway Driver", 9, 6, -2, 1),
            new DiscGolfDisc("Mystic", "Gateway", "Mid Range", 5, 5, -3, 0),
            new DiscGolfDisc("Warrior", "Gateway", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("Chief", "Gateway", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Chief OS", "Gateway", "Putt & Approach", 3, 3, 0, 2),
            new DiscGolfDisc("Devilhawk", "Gateway", "Putt & Approach", 3, 3, 0, 4),
            new DiscGolfDisc("Ghoul", "Gateway", "Putt & Approach", 3, 3, 0, 3),
            new DiscGolfDisc("Houdini", "Gateway", "Putt & Approach", 3, 3, 0, 3),
            new DiscGolfDisc("Magic", "Gateway", "Putt & Approach", 2, 3, -1, 0),
            new DiscGolfDisc("Wizard", "Gateway", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Firestorm", "Innova", "Distance Driver", 14, 4, -1, 3),
            new DiscGolfDisc("Corvette", "Innova", "Distance Driver", 14, 6, -1, 2),
            new DiscGolfDisc("Colossus", "Innova", "Distance Driver", 14, 5, -1, 3),
            new DiscGolfDisc("Vulcan", "Innova", "Distance Driver", 13, 5, -4, 2),
            new DiscGolfDisc("Shryke", "Innova", "Distance Driver", 13, 6, -2, 2),
            new DiscGolfDisc("Katana", "Innova", "Distance Driver", 13, 5, -3, 3),
            new DiscGolfDisc("Groove", "Innova", "Distance Driver", 13, 6, -2, 2),
            new DiscGolfDisc("Dominator", "Innova", "Distance Driver", 13, 5, -1, 2),
            new DiscGolfDisc("Daedalus", "Innova", "Distance Driver", 13, 6, -3, 2),
            new DiscGolfDisc("Charger", "Innova", "Distance Driver", 13, 5, -1, 2),
            new DiscGolfDisc("Boss", "Innova", "Distance Driver", 13, 5, -1, 3),
            new DiscGolfDisc("Ape", "Innova", "Distance Driver", 13, 5, 0, 4),
            new DiscGolfDisc("Charger", "Innova", "Distance Driver", 12, 6, -1, 2),
            new DiscGolfDisc("Juggernaut", "Innova", "Distance Driver", 12, 4, 1, 4),
            new DiscGolfDisc("XCaliber", "Innova", "Distance Driver", 12, 5, 0, 4),
            new DiscGolfDisc("Wahoo", "Innova", "Distance Driver", 12, 6, -2, 2),
            new DiscGolfDisc("Tern", "Innova", "Distance Driver", 12, 6, -3, 2),
            new DiscGolfDisc("TeeDevil", "Innova", "Distance Driver", 12, 5, -1, 2),
            new DiscGolfDisc("Racer", "Innova", "Distance Driver", 12, 6, -1, 2),
            new DiscGolfDisc("Teedevil", "Innova", "Distance Driver", 12, 5, -1, 2),
            new DiscGolfDisc("Destroyer", "Innova", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("Wraith", "Innova", "Distance Driver", 11, 5, -1, 3),
            new DiscGolfDisc("TeeRex", "Innova", "Distance Driver", 11, 4, 0, 4),
            new DiscGolfDisc("Mystere", "Innova", "Distance Driver", 11, 6, -2, 2),
            new DiscGolfDisc("Max", "Innova", "Distance Driver", 11, 3, 0, 5),
            new DiscGolfDisc("Mamba", "Innova", "Distance Driver", 11, 6, -5, 1),
            new DiscGolfDisc("Max", "Innova", "Distance Driver", 11, 5, 0, 3),
            new DiscGolfDisc("Orc", "Innova", "Distance Driver", 11, 4, -1, 3),
            new DiscGolfDisc("Krait", "Innova", "Distance Driver", 11, 5, -1, 2),
            new DiscGolfDisc("Archon", "Innova", "Distance Driver", 11, 5, -2, 2),
            new DiscGolfDisc("Starfire", "Innova", "Distance Driver", 10, 4, 0, 3),
            new DiscGolfDisc("Orc", "Innova", "Distance Driver", 10, 4, -1, 3),
            new DiscGolfDisc("Monster", "Innova", "Distance Driver", 10, 3, 0, 5),
            new DiscGolfDisc("Gorgon", "Innova", "Distance Driver", 10, 6, -3, 1),
            new DiscGolfDisc("Monarch", "Innova", "Distance Driver", 10, 5, -4, 1),
            new DiscGolfDisc("Invictus", "Innova", "Distance Driver", 10, 4, 0, 3),
            new DiscGolfDisc("Gorgon", "Innova", "Distance Driver", 10, 6, -2, 1),
            new DiscGolfDisc("Beast", "Innova", "Distance Driver", 10, 5, -2, 2),
            new DiscGolfDisc("Viking", "Innova", "Distance Driver", 9, 4, -1, 2),
            new DiscGolfDisc("Valkyrie", "Innova", "Distance Driver", 9, 4, -2, 2),
            new DiscGolfDisc("Thunderbird", "Innova", "Distance Driver", 9, 5, 0, 2),
            new DiscGolfDisc("Sidewinder", "Innova", "Distance Driver", 9, 5, -3, 1),
            new DiscGolfDisc("Savant", "Innova", "Distance Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Roadrunner", "Innova", "Distance Driver", 9, 5, -4, 1),
            new DiscGolfDisc("FL", "Innova", "Distance Driver", 9, 3, 0, 2),
            new DiscGolfDisc("Firebird", "Innova", "Distance Driver", 9, 3, 0, 4),
            new DiscGolfDisc("TL3", "Innova", "Fairway Driver", 8, 4, -1, 1),
            new DiscGolfDisc("TeeBird3", "Innova", "Fairway Driver", 8, 4, 0, 2),
            new DiscGolfDisc("Dragon", "Innova", "Fairway Driver", 8, 5, -2, 2),
            new DiscGolfDisc("Archangel", "Innova", "Fairway Driver", 8, 6, -4, 1),
            new DiscGolfDisc("TL", "Innova", "Fairway Driver", 7, 5, -1, 1),
            new DiscGolfDisc("TeeBird", "Innova", "Fairway Driver", 7, 5, 0, 2),
            new DiscGolfDisc("Leopard3", "Innova", "Fairway Driver", 7, 5, -2, 1),
            new DiscGolfDisc("IT", "Innova", "Fairway Driver", 7, 6, -2, 1),
            new DiscGolfDisc("Hawkeye", "Innova", "Fairway Driver", 7, 5, -1, 1),
            new DiscGolfDisc("Eagle", "Innova", "Fairway Driver", 7, 4, -1, 3),
            new DiscGolfDisc("Dark Rebel", "Innova", "Fairway Driver", 7, 6, -1, 1),
            new DiscGolfDisc("Banshee", "Innova", "Fairway Driver", 7, 3, 0, 3),
            new DiscGolfDisc("Whippet", "Innova", "Fairway Driver", 6, 3, 1, 5),
            new DiscGolfDisc("Viper", "Innova", "Fairway Driver", 6, 4, 1, 5),
            new DiscGolfDisc("Leopard", "Innova", "Fairway Driver", 6, 5, -2, 1),
            new DiscGolfDisc("Gazelle", "Innova", "Fairway Driver", 6, 4, 0, 2),
            new DiscGolfDisc("Cheetah", "Innova", "Fairway Driver", 6, 4, -2, 2),
            new DiscGolfDisc("Caiman", "Innova", "Mid Range", 5.5, 2, 0, 4),
            new DiscGolfDisc("Wombat3", "Innova", "Mid Range", 5, 6, -1, 0),
            new DiscGolfDisc("Wombat", "Innova", "Mid Range", 5, 6, -1, 0),
            new DiscGolfDisc("VCobra", "Innova", "Mid Range", 5, 5, -1, 2),
            new DiscGolfDisc("Spider", "Innova", "Mid Range", 5, 3, 0, 1),
            new DiscGolfDisc("Skeeter", "Innova", "Mid Range", 5, 5, -1, 1),
            new DiscGolfDisc("Shark3", "Innova", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Rollo", "Innova", "Mid Range", 5, 6, -4, 1),
            new DiscGolfDisc("Roc3", "Innova", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("Panther", "Innova", "Mid Range", 5, 4, -2, 1),
            new DiscGolfDisc("Manta", "Innova", "Mid Range", 5, 5, -2, 1),
            new DiscGolfDisc("Mako3", "Innova", "Mid Range", 5, 5, 0, 0),
            new DiscGolfDisc("Lion", "Innova", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Gator3", "Innova", "Mid Range", 5, 2, 0, 3),
            new DiscGolfDisc("Gremlin", "Innova", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Kite", "Innova", "Mid Range", 5, 6, -3, 1),
            new DiscGolfDisc("Jay", "Innova", "Mid Range", 5, 4, 0, 1),
            new DiscGolfDisc("Gator", "Innova", "Mid Range", 5, 2, 0, 4),
            new DiscGolfDisc("Foxbat", "Innova", "Mid Range", 5, 6, -1, 0),
            new DiscGolfDisc("Cro", "Innova", "Mid Range", 5, 3, 0, 2),
            new DiscGolfDisc("Avatar", "Innova", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Atlas", "Innova", "Mid Range", 5, 4, 0, 1),
            new DiscGolfDisc("Wolf", "Innova", "Mid Range", 4, 3, -4, 1),
            new DiscGolfDisc("VRoc", "Innova", "Mid Range", 4, 4, 0, 1),
            new DiscGolfDisc("Toro", "Innova", "Mid Range", 4, 2, 1, 3),
            new DiscGolfDisc("Stingray", "Innova", "Mid Range", 4, 5, -3, 1),
            new DiscGolfDisc("Shark", "Innova", "Mid Range", 4, 4, 0, 2),
            new DiscGolfDisc("Roc+", "Innova", "Mid Range", 4, 5, 0, 2),
            new DiscGolfDisc("Roc", "Innova", "Mid Range", 4, 4, 0, 3),
            new DiscGolfDisc("Rat", "Innova", "Mid Range", 4, 2, 0, 2),
            new DiscGolfDisc("Pig", "Innova", "Mid Range", 4, 1, 0, 3),
            new DiscGolfDisc("Mako", "Innova", "Mid Range", 4, 5, 0, 0),
            new DiscGolfDisc("King Cobra", "Innova", "Mid Range", 4, 5, 0, 2),
            new DiscGolfDisc("Coyote", "Innova", "Mid Range", 4, 5, 0, 1),
            new DiscGolfDisc("Cobra", "Innova", "Mid Range", 4, 5, -2, 2),
            new DiscGolfDisc("Alien", "Innova", "Mid Range", 4, 2, 0, 1),
            new DiscGolfDisc("Wedge", "Innova", "Putt & Approach", 3.5, 3, -3, 1),
            new DiscGolfDisc("XD", "Innova", "Putt & Approach", 3, 4, -1, 1),
            new DiscGolfDisc("Stud", "Innova", "Putt & Approach", 3, 3, 0, 2),
            new DiscGolfDisc("Mirage", "Innova", "Putt & Approach", 3, 4, -3, 0),
            new DiscGolfDisc("Invader", "Innova", "Putt & Approach", 3, 2, 0, 1),
            new DiscGolfDisc("Hydra", "Innova", "Putt & Approach", 3, 3, 0, 2),
            new DiscGolfDisc("Dart", "Innova", "Putt & Approach", 3, 4, 0, 0),
            new DiscGolfDisc("Colt", "Innova", "Putt & Approach", 3, 4, -1, 1),
            new DiscGolfDisc("Bullfrog", "Innova", "Putt & Approach", 3, 1, 0, 1),
            new DiscGolfDisc("AviarX3", "Innova", "Putt & Approach", 3, 2, 0, 3),
            new DiscGolfDisc("Aviar3", "Innova", "Putt & Approach", 3, 2, 0, 2),
            new DiscGolfDisc("Aero", "Innova", "Putt & Approach", 3, 6, 0, 0),
            new DiscGolfDisc("Pig", "Innova", "Putt & Approach", 3, 1, 0, 3),
            new DiscGolfDisc("Yeti Aviar", "Innova", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Xero", "Innova", "Putt & Approach", 2, 3, 0, 0),
            new DiscGolfDisc("Whale", "Innova", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("RhynoX", "Innova", "Putt & Approach", 2, 1, 0, 4),
            new DiscGolfDisc("Rhyno", "Innova", "Putt & Approach", 2, 1, 0, 3),
            new DiscGolfDisc("Nova", "Innova", "Putt & Approach", 2, 3, 0, 0),
            new DiscGolfDisc("KC Aviar", "Innova", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("JK Aviar", "Innova", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Classic Aviar", "Innova", "Putt & Approach", 2, 3, 0, 0),
            new DiscGolfDisc("NS Firefly", "Innova", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Aviar Driver", "Innova", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Aviar", "Innova", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Animal", "Innova", "Putt & Approach", 2, 1, 0, 1),
            new DiscGolfDisc("Yeti Pro Aviar", "Innova", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Sonic", "Innova", "Putt & Approach", 1, 2, -4, 0),
            new DiscGolfDisc("Polecat", "Innova", "Putt & Approach", 1, 3, 0, 0),
            new DiscGolfDisc("Birdie", "Innova", "Putt & Approach", 1, 2, 0, 0),
            new DiscGolfDisc("Älva", "Kastaplast", "Distance Driver", 11, 6, -2, 2),
            new DiscGolfDisc("Grym", "Kastaplast", "Distance Driver", 13, 5, -1, 2),
            new DiscGolfDisc("Grym X", "Kastaplast", "Distance Driver", 12, 5, 0, 3),
            new DiscGolfDisc("Guld", "Kastaplast", "Distance Driver", 13, 5, -0.5, 3),
            new DiscGolfDisc("Krut", "Kastaplast", "Distance Driver", 12, 4, 0, 4),
            new DiscGolfDisc("Rask", "Kastaplast", "Distance Driver", 14, 3, 0, 4),
            new DiscGolfDisc("Vass", "Kastaplast", "Distance Driver", 12, 5, -1.5, 2),
            new DiscGolfDisc("Falk", "Kastaplast", "Fairway Driver", 9, 6, -2, 1),
            new DiscGolfDisc("Idog", "Kastaplast", "Fairway Driver", 7, 5, -0.5, 2),
            new DiscGolfDisc("Lots", "Kastaplast", "Fairway Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Malm", "Kastaplast", "Fairway Driver", 10, 4, 0, 2.5),
            new DiscGolfDisc("Stal", "Kastaplast", "Fairway Driver", 9, 4, 0, 3),
            new DiscGolfDisc("Göte", "Kastaplast", "Mid Range", 4, 5, 0, 1),
            new DiscGolfDisc("Kaxe", "Kastaplast", "Mid Range", 6, 4, 0, 3),
            new DiscGolfDisc("Kaxe Z", "Kastaplast", "Mid Range", 6, 5, 0, 2),
            new DiscGolfDisc("Svea", "Kastaplast", "Mid Range", 5, 6, -1, 0),
            new DiscGolfDisc("Berg", "Kastaplast", "Putt & Approach", 1, 1, 0, 2),
            new DiscGolfDisc("Berg X", "Kastaplast", "Putt & Approach", 1, 1, 1, 2),
            new DiscGolfDisc("Järn", "Kastaplast", "Putt & Approach", 4.5, 3, 0, 3),
            new DiscGolfDisc("Reko", "Kastaplast", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Reko X", "Kastaplast", "Putt & Approach", 3, 3, 0, 2),
            new DiscGolfDisc("Ballista Pro", "Latitude 64", "Distance Driver", 14, 4, 0, 3),
            new DiscGolfDisc("Cutlass", "Latitude 64", "Distance Driver", 13, 5, 0, 3.5),
            new DiscGolfDisc("Ballista", "Latitude 64", "Distance Driver", 14, 5, -1, 3),
            new DiscGolfDisc("Blitz", "Latitude 64", "Distance Driver", 11, 3, 0, 4),
            new DiscGolfDisc("Bolt", "Latitude 64", "Distance Driver", 13, 6, -2, 3),
            new DiscGolfDisc("Flow", "Latitude 64", "Distance Driver", 11, 6, -0.5, 2),
            new DiscGolfDisc("Gladiator", "Latitude 64", "Distance Driver", 13, 5, 0, 3.5),
            new DiscGolfDisc("Grace", "Latitude 64", "Distance Driver", 11, 6, -1, 2),
            new DiscGolfDisc("Halo", "Latitude 64", "Distance Driver", 13, 5, -0.5, 3),
            new DiscGolfDisc("Havoc", "Latitude 64", "Distance Driver", 13, 5, -1, 3),
            new DiscGolfDisc("Knight", "Latitude 64", "Distance Driver", 14, 4, -1.5, 3),
            new DiscGolfDisc("Missilen", "Latitude 64", "Distance Driver", 15, 3, -0.5, 4.5),
            new DiscGolfDisc("Raketen", "Latitude 64", "Distance Driver", 15, 4, -2, 3),
            new DiscGolfDisc("Recoil", "Latitude 64", "Distance Driver", 12, 4, 0, 3),
            new DiscGolfDisc("Riot", "Latitude 64", "Distance Driver", 11, 4, -1, 2),
            new DiscGolfDisc("Rive", "Latitude 64", "Distance Driver", 13, 5, 0, 3.5),
            new DiscGolfDisc("Scythe", "Latitude 64", "Distance Driver", 12, 3, 0, 4),
            new DiscGolfDisc("SPZ3", "Latitude 64", "Distance Driver", 9, 6, -2, 2),
            new DiscGolfDisc("Stiletto", "Latitude 64", "Distance Driver", 13, 2, 1, 6),
            new DiscGolfDisc("Strive", "Latitude 64", "Distance Driver", 13, 5, -1, 3),
            new DiscGolfDisc("Villain", "Latitude 64", "Distance Driver", 12, 4, 0, 4),
            new DiscGolfDisc("Fury", "Latitude 64", "Fairway Driver", 9, 6, -2, 2),
            new DiscGolfDisc("Honor", "Latitude 64", "Fairway Driver", 9, 5, 0, 2.5),
            new DiscGolfDisc("Brave", "Latitude 64", "Fairway Driver", 7, 6, -1, 2),
            new DiscGolfDisc("Bryce", "Latitude 64", "Fairway Driver", 9, 6, -2, 2),
            new DiscGolfDisc("Culverin", "Latitude 64", "Fairway Driver", 9, 5, -0.5, 3),
            new DiscGolfDisc("Diamond", "Latitude 64", "Fairway Driver", 8, 6, -3, 1),
            new DiscGolfDisc("Explorer", "Latitude 64", "Fairway Driver", 7, 5, 0, 2),
            new DiscGolfDisc("Falchion", "Latitude 64", "Fairway Driver", 8, 5, -1, 2),
            new DiscGolfDisc("Glory", "Latitude 64", "Fairway Driver", 7, 5, 0, 3),
            new DiscGolfDisc("Jade", "Latitude 64", "Fairway Driver", 9, 6, -2, 1),
            new DiscGolfDisc("Maul", "Latitude 64", "Fairway Driver", 7, 7, -2, 1),
            new DiscGolfDisc("Pioneer", "Latitude 64", "Fairway Driver", 9, 3, 0, 4),
            new DiscGolfDisc("River", "Latitude 64", "Fairway Driver", 7, 7, -1, 1),
            new DiscGolfDisc("Saint", "Latitude 64", "Fairway Driver", 9, 7, -1, 2),
            new DiscGolfDisc("Saint Pro", "Latitude 64", "Fairway Driver", 8, 5, -0.5, 2),
            new DiscGolfDisc("Sapphire", "Latitude 64", "Fairway Driver", 10, 6, -2, 1.5),
            new DiscGolfDisc("Spark", "Latitude 64", "Fairway Driver", 7, 4, -0.5, 3),
            new DiscGolfDisc("Striker", "Latitude 64", "Fairway Driver", 8, 5, 0, 2),
            new DiscGolfDisc("Sweep", "Latitude 64", "Fairway Driver", 9, 6, -0.5, 2),
            new DiscGolfDisc("Trident", "Latitude 64", "Fairway Driver", 6, 4, -0.5, 3),
            new DiscGolfDisc("Vision", "Latitude 64", "Fairway Driver", 8, 6, -1, 2),
            new DiscGolfDisc("XXX", "Latitude 64", "Fairway Driver", 7, 3, 0, 4),
            new DiscGolfDisc("Zion", "Latitude 64", "Fairway Driver", 9, 4, -0.5, 3),
            new DiscGolfDisc("Anchor", "Latitude 64", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("Claymore", "Latitude 64", "Mid Range", 5, 5, -1, 1),
            new DiscGolfDisc("Compass", "Latitude 64", "Mid Range", 5, 5, 0, 1),
            new DiscGolfDisc("Core", "Latitude 64", "Mid Range", 6, 5, -0.5, 1),
            new DiscGolfDisc("Fuji", "Latitude 64", "Mid Range", 4, 4, 0, 2),
            new DiscGolfDisc("Fuse", "Latitude 64", "Mid Range", 5, 6, -1, 0),
            new DiscGolfDisc("Gobi", "Latitude 64", "Mid Range", 6, 5, -0.5, 1),
            new DiscGolfDisc("Mace", "Latitude 64", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("Medius", "Latitude 64", "Mid Range", 5, 5, -1, 2),
            new DiscGolfDisc("Pain", "Latitude 64", "Mid Range", 4, 4, 0, 3),
            new DiscGolfDisc("Pearl", "Latitude 64", "Mid Range", 4, 6, -4, 0),
            new DiscGolfDisc("Trust", "Latitude 64", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("Beetle", "Latitude 64", "Putt & Approach", 1, 7, -1, 0),
            new DiscGolfDisc("Caltrop", "Latitude 64", "Putt & Approach", 2, 2, 0, 0),
            new DiscGolfDisc("Dagger", "Latitude 64", "Putt & Approach", 2, 5, 0, 1),
            new DiscGolfDisc("Faith", "Latitude 64", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Gauntlet", "Latitude 64", "Putt & Approach", 2, 4, 0, 1),
            new DiscGolfDisc("Hope", "Latitude 64", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Keystone", "Latitude 64", "Putt & Approach", 2, 5, -1, 1),
            new DiscGolfDisc("Macana", "Latitude 64", "Putt & Approach", 2, 5, 0, 1),
            new DiscGolfDisc("Mercy", "Latitude 64", "Putt & Approach", 2, 4, 0, 1),
            new DiscGolfDisc("Peak", "Latitude 64", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Pure", "Latitude 64", "Putt & Approach", 3, 3, -1, 1),
            new DiscGolfDisc("Quasar", "Millenium", "Distance Driver", 13, 5, 0, 3),
            new DiscGolfDisc("Scorpius", "Millenium", "Distance Driver", 12, 5, -1, 3),
            new DiscGolfDisc("Standard Falcon", "Millenium", "Distance Driver", 13, 5, -2, 2),
            new DiscGolfDisc("Draco", "Millenium", "Fairway Driver", 9, 3, 0, 4),
            new DiscGolfDisc("Orion", "Millenium", "Fairway Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Aurora MS", "Millenium", "Mid Range", 4, 5, 0, 0),
            new DiscGolfDisc("Mortar", "Millenium", "Mid Range", 5, 3, 0, 3),
            new DiscGolfDisc("Omega", "Millenium", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("Omega Big Bead", "Millenium", "Putt & Approach", 2, 3, 0, 1),
            new DiscGolfDisc("GOAT", "Mint", "Distance Driver", 12, 4, -1, 3),
            new DiscGolfDisc("Longhorn", "Mint", "Distance Driver", 11, 4, -1, 2.5),
            new DiscGolfDisc("Alpha", "Mint", "Fairway Driver", 8, 4, 0, 2),
            new DiscGolfDisc("Diamondback", "Mint", "Fairway Driver", 9, 5, -2, 2),
            new DiscGolfDisc("Freetail", "Mint", "Fairway Driver", 10, 5, -4, 1),
            new DiscGolfDisc("Grackle", "Mint", "Fairway Driver", 7, 5, -1, 2),
            new DiscGolfDisc("Jackalope", "Mint", "Fairway Driver", 8, 5, -2, 1),
            new DiscGolfDisc("Bobcat", "Mint", "Mid Range", 5, 5, 0, 2),
            new DiscGolfDisc("Lobster", "Mint", "Mid Range", 5, 5, -3, 1),
            new DiscGolfDisc("Mustang", "Mint", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Bullet", "Mint", "Putt & Approach", 2, 4, 0, 1),
            new DiscGolfDisc("Profit", "Mint", "Putt & Approach", 2, 3, 0, 2),
            new DiscGolfDisc("Catalyst", "MVP", "Distance Driver", 13, 5.5, -2, 2),
            new DiscGolfDisc("Dimension", "MVP", "Distance Driver", 14.5, 5, 0, 3),
            new DiscGolfDisc("Energy", "MVP", "Distance Driver", 13, 4, 0, 4),
            new DiscGolfDisc("Impulse", "MVP", "Distance Driver", 9, 5, -3, 1),
            new DiscGolfDisc("Inertia", "MVP", "Distance Driver", 9, 5, -2, 2),
            new DiscGolfDisc("Limit", "MVP", "Distance Driver", 14.5, 3.5, 0, 4),
            new DiscGolfDisc("Motion", "MVP", "Distance Driver", 9, 3.5, 0, 4),
            new DiscGolfDisc("Nitro", "MVP", "Distance Driver", 13, 4, -0.5, 3),
            new DiscGolfDisc("Octane", "MVP", "Distance Driver", 13, 5, -1, 2),
            new DiscGolfDisc("Orbital", "MVP", "Distance Driver", 11, 5, -4.5, 1),
            new DiscGolfDisc("Phase", "MVP", "Distance Driver", 11, 3.5, 0, 4),
            new DiscGolfDisc("Photon", "MVP", "Distance Driver", 11, 5, -1, 2.5),
            new DiscGolfDisc("Relativity", "MVP", "Distance Driver", 14.5, 5.5, -3, 1.5),
            new DiscGolfDisc("Teleport", "MVP", "Distance Driver", 14.5, 5, -1.5, 2.5),
            new DiscGolfDisc("Tesla", "MVP", "Distance Driver", 9, 5, -1, 2),
            new DiscGolfDisc("Trail", "MVP", "Distance Driver", 10, 5, -1, 1),
            new DiscGolfDisc("Wave", "MVP", "Distance Driver", 11, 5, -2, 2),
            new DiscGolfDisc("Zenith", "MVP", "Distance Driver", 11, 5, -0.5, 2),
            new DiscGolfDisc("Amp", "MVP", "Fairway Driver", 8, 5, -1.5, 1),
            new DiscGolfDisc("Relay", "MVP", "Fairway Driver", 6, 5, -2, 1),
            new DiscGolfDisc("Resistor", "MVP", "Fairway Driver", 6.5, 4, 0, 3.5),
            new DiscGolfDisc("Servo", "MVP", "Fairway Driver", 6.5, 5, -1, 2),
            new DiscGolfDisc("Shock", "MVP", "Fairway Driver", 8, 5, 0, 2.5),
            new DiscGolfDisc("Signal", "MVP", "Fairway Driver", 6, 5, -3, 1),
            new DiscGolfDisc("Switch", "MVP", "Fairway Driver", 6.5, 5, -1.5, 1),
            new DiscGolfDisc("Terra", "MVP", "Fairway Driver", 8, 5, 0, 3),
            new DiscGolfDisc("Volt", "MVP", "Fairway Driver", 8, 5, -0.5, 2),
            new DiscGolfDisc("Axis", "MVP", "Mid Range", 5, 5, -1, 1),
            new DiscGolfDisc("Deflector", "MVP", "Mid Range", 5, 3.5, 0, 4),
            new DiscGolfDisc("Detour", "MVP", "Mid Range", 5, 5, -2, 1),
            new DiscGolfDisc("Matrix", "MVP", "Mid Range", 5, 4, -1, 2),
            new DiscGolfDisc("Reactor", "MVP", "Mid Range", 5, 5, -0.5, 1.5),
            new DiscGolfDisc("Tangent", "MVP", "Mid Range", 4, 4, -0.5, 0.5),
            new DiscGolfDisc("Tensor", "MVP", "Mid Range", 4, 4, 0, 2.5),
            new DiscGolfDisc("Vector", "MVP", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("Vertex", "MVP", "Mid Range", 4, 4, -2, 0.5),
            new DiscGolfDisc("Anode", "MVP", "Putt & Approach", 2.5, 3, 0, 0.5),
            new DiscGolfDisc("Atom", "MVP", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Entropy", "MVP", "Putt & Approach", 4, 3, 0, 3),
            new DiscGolfDisc("Glitch", "MVP", "Putt & Approach", 1, 7, 0, 0),
            new DiscGolfDisc("Ion", "MVP", "Putt & Approach", 2.5, 3, 0, 1.5),
            new DiscGolfDisc("Nomad", "MVP", "Putt & Approach", 2, 4, 0, 1),
            new DiscGolfDisc("Ohm", "MVP", "Putt & Approach", 2, 5, 0, 1),
            new DiscGolfDisc("Particle", "MVP", "Putt & Approach", 3, 3, 0, 2.5),
            new DiscGolfDisc("Spin", "MVP", "Putt & Approach", 2.5, 4, -2, 0),
            new DiscGolfDisc("Watt", "MVP", "Putt & Approach", 2, 5, 0.5, 0.5),
            new DiscGolfDisc("D Model OS", "Prodigy", "Distance Driver", 13, 5, 0, 4),
            new DiscGolfDisc("D Model S", "Prodigy", "Distance Driver", 13, 6, 0, 2),
            new DiscGolfDisc("D1", "Prodigy", "Distance Driver", 12, 5, 0, 3),
            new DiscGolfDisc("D2", "Prodigy", "Distance Driver", 12, 6, -1, 3),
            new DiscGolfDisc("D3", "Prodigy", "Distance Driver", 13, 5, -2, 2),
            new DiscGolfDisc("D4", "Prodigy", "Distance Driver", 12, 6, -3, 2),
            new DiscGolfDisc("Falcor", "Prodigy", "Distance Driver", 13, 6, -1, 2.5),
            new DiscGolfDisc("Reverb", "Prodigy", "Distance Driver", 13, 5, 0, 3.5),
            new DiscGolfDisc("X1", "Prodigy", "Distance Driver", 13, 3, 0, 5),
            new DiscGolfDisc("X2", "Prodigy", "Distance Driver", 13, 4.5, 0, 4),
            new DiscGolfDisc("X3", "Prodigy", "Distance Driver", 12, 5, -1, 2),
            new DiscGolfDisc("F1", "Prodigy", "Fairway Driver", 7, 4, 0, 3),
            new DiscGolfDisc("F2", "Prodigy", "Fairway Driver", 7, 5, -1, 3),
            new DiscGolfDisc("F3", "Prodigy", "Fairway Driver", 7, 5, -1, 2),
            new DiscGolfDisc("F5", "Prodigy", "Fairway Driver", 7, 5, -2, 1),
            new DiscGolfDisc("F7", "Prodigy", "Fairway Driver", 7, 5, -3, 1),
            new DiscGolfDisc("F9", "Prodigy", "Fairway Driver", 8, 6, -4, 0.5),
            new DiscGolfDisc("FX-2", "Prodigy", "Fairway Driver", 9, 4, -0.5, 3),
            new DiscGolfDisc("FX-3", "Prodigy", "Fairway Driver", 9, 4, -1.5, 2),
            new DiscGolfDisc("FX-4", "Prodigy", "Fairway Driver", 9, 4, -2, 2),
            new DiscGolfDisc("H3", "Prodigy", "Fairway Driver", 11, 5, -1, 2),
            new DiscGolfDisc("M1", "Prodigy", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("M2", "Prodigy", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("M3", "Prodigy", "Mid Range", 5, 5, -1, 2),
            new DiscGolfDisc("M4", "Prodigy", "Mid Range", 5, 5, -1, 1),
            new DiscGolfDisc("MX-3", "Prodigy", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("A1", "Prodigy", "Putt & Approach", 3, 3, 0, 3),
            new DiscGolfDisc("A2", "Prodigy", "Putt & Approach", 3, 4, 0, 3),
            new DiscGolfDisc("A3", "Prodigy", "Putt & Approach", 4, 4, 0, 3),
            new DiscGolfDisc("A4", "Prodigy", "Putt & Approach", 4, 4, -1, 2),
            new DiscGolfDisc("Distortion", "Prodigy", "Putt & Approach", 4, 4, 0, 4),
            new DiscGolfDisc("PA-3", "Prodigy", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("PX-3", "Prodigy", "Putt & Approach", 3, 4, 0, 2.5),
            new DiscGolfDisc("Kahu", "RPM", "Distance Driver", 13, 5, -1, 2),
            new DiscGolfDisc("Boost", "Streamline", "Distance Driver", 10, 5, -1, 3),
            new DiscGolfDisc("Flare", "Streamline", "Distance Driver", 9, 4, 0, 3.5),
            new DiscGolfDisc("Jet", "Streamline", "Distance Driver", 11, 5, -3, 2),
            new DiscGolfDisc("Lift", "Streamline", "Distance Driver", 9, 5, -2, 1.5),
            new DiscGolfDisc("Trace", "Streamline", "Distance Driver", 11, 5, -1, 2),
            new DiscGolfDisc("Ascend", "Streamline", "Fairway Driver", 6, 5, -3, 0.5),
            new DiscGolfDisc("Drift", "Streamline", "Fairway Driver", 7, 5, -1, 2),
            new DiscGolfDisc("Turbulence", "Streamline", "Fairway Driver", 7, 2, 0, 3.5),
            new DiscGolfDisc("Echo", "Streamline", "Mid Range", 5, 5, -1.5, 1),
            new DiscGolfDisc("Runway", "Streamline", "Mid Range", 5, 4, 0, 3.5),
            new DiscGolfDisc("Pilot", "Streamline", "Putt & Approach", 2, 5, 0, 1),
            new DiscGolfDisc("Stabilizer", "Streamline", "Putt & Approach", 3, 3.5, 0, 3),
            new DiscGolfDisc("Range", "Streamline", "Putt & Approach", 2, 1, -0.5, 0.5),
            new DiscGolfDisc("Construct", "Thought Space Athletics", "Distance Driver", 10, 6, -1, 2),
            new DiscGolfDisc("Animus", "Thought Space Athletics", "Distance Driver", 11, 5, 0, 2),
            new DiscGolfDisc("Synapse", "Thought Space Athletics", "Distance Driver", 12, 5, -1.5, 3),
            new DiscGolfDisc("Coalesce", "Thought Space Athletics", "Fairway Driver", 9, 5, 0, 3),
            new DiscGolfDisc("Mantra", "Thought Space Athletics", "Fairway Driver", 9, 6, -2, 1),
            new DiscGolfDisc("Nuance", "Thought Space Athletics", "Fairway Driver", 7, 5, -2, 1),
            new DiscGolfDisc("Omen", "Thought Space Athletics", "Fairway Driver", 9, 4, 0, 4),
            new DiscGolfDisc("Persona", "Thought Space Athletics", "Fairway Driver", 8, 5, -3, 1),
            new DiscGolfDisc("Votum", "Thought Space Athletics", "Fairway Driver", 7, 5, 0, 3),
            new DiscGolfDisc("Crux", "Thought Space Athletics", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Mana", "Thought Space Athletics", "Mid Range", 5, 5, -2, 1),
            new DiscGolfDisc("Pathfinder", "Thought Space Athletics", "Mid Range", 5, 5, 0, 1),
            new DiscGolfDisc("Alter", "Thought Space Athletics", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Temple", "Thought Space Athletics", "Putt & Approach", 4, 3, 0, 3),
            new DiscGolfDisc("Muse", "Thought Space Athletics", "Putt & Approach", 3, 3, 0, 2),
            new DiscGolfDisc("Praxis", "Thought Space Athletics", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Adder", "Westside Discs", "Distance Driver", 13, 5, 0, 4),
            new DiscGolfDisc("Catapult", "Westside Discs", "Distance Driver", 14, 4, -0.5, 3),
            new DiscGolfDisc("Destiny", "Westside Discs", "Distance Driver", 14, 6, -2, 3),
            new DiscGolfDisc("Giant", "Westside Discs", "Distance Driver", 13, 4, 0, 3.5),
            new DiscGolfDisc("King", "Westside Discs", "Distance Driver", 14, 5, -1, 4),
            new DiscGolfDisc("Prince", "Westside Discs", "Distance Driver", 13, 5, 0, 3),
            new DiscGolfDisc("Queen", "Westside Discs", "Distance Driver", 14, 5, -3, 2),
            new DiscGolfDisc("Sword", "Westside Discs", "Distance Driver", 12, 5, -0.5, 2),
            new DiscGolfDisc("Tide", "Westside Discs", "Distance Driver", 12, 6, -0.5, 3),
            new DiscGolfDisc("War Horse", "Westside Discs", "Distance Driver", 13, 4, 0, 4),
            new DiscGolfDisc("World", "Westside Discs", "Distance Driver", 14, 4, -0.5, 3),
            new DiscGolfDisc("Ahti", "Westside Discs", "Fairway Driver", 9, 3, 0, 4),
            new DiscGolfDisc("Fortress", "Westside Discs", "Fairway Driver", 10, 4, 0, 3),
            new DiscGolfDisc("Hatchet", "Westside Discs", "Fairway Driver", 9, 6, -2, 1),
            new DiscGolfDisc("Longbowman", "Westside Discs", "Fairway Driver", 9, 4, 0, 3),
            new DiscGolfDisc("Sampo", "Westside Discs", "Fairway Driver", 10, 4, -1, 2),
            new DiscGolfDisc("Seer", "Westside Discs", "Fairway Driver", 7, 5, -2, 1),
            new DiscGolfDisc("Stag", "Westside Discs", "Fairway Driver", 8, 6, -1, 2),
            new DiscGolfDisc("Underworld", "Westside Discs", "Fairway Driver", 7, 6, -3, 1),
            new DiscGolfDisc("Anvil", "Westside Discs", "Mid Range", 4, 2, 0, 4),
            new DiscGolfDisc("Bard", "Westside Discs", "Mid Range", 5, 4, 0, 3),
            new DiscGolfDisc("Pine", "Westside Discs", "Mid Range", 5, 4, 0, 2),
            new DiscGolfDisc("Warship", "Westside Discs", "Mid Range", 5, 6, 0, 1),
            new DiscGolfDisc("Crown", "Westside Discs", "Putt & Approach", 3, 4, 0, 1),
            new DiscGolfDisc("Harp", "Westside Discs", "Putt & Approach", 4, 3, 0, 3),
            new DiscGolfDisc("Maiden", "Westside Discs", "Putt & Approach", 3, 4, 0, 1),
            new DiscGolfDisc("Shield", "Westside Discs", "Putt & Approach", 3, 3, 0, 1),
            new DiscGolfDisc("Swan", "Westside Discs", "Putt & Approach", 3, 3, -1, 0),
            new DiscGolfDisc("Swan 1 Reborn", "Westside Discs", "Putt & Approach", 3, 3, -2.5, 0),
            new DiscGolfDisc("She Gong", "Yikun", "Distance Driver", 13, 5, 0, 2),
            new DiscGolfDisc("Twin Swords", "Yikun", "Distance Driver", 12, 5, 0, 2),
            new DiscGolfDisc("Tomahawk", "Yikun", "Mid Range", 5, 6, 0, 0),
            new DiscGolfDisc("YAO", "Yikun", "Mid Range", 4, 4, 0, 3),
        };

        private static readonly Dictionary<string, DiscGolfDisc> discByName = FillDictionary_Name();
        private static readonly Dictionary<string, DiscGolfDisc> discByBrand = FillDictionary_Brand();
        private static readonly Dictionary<string, DiscGolfDisc> discByType = FillDictionary_Type();
        private static readonly Dictionary<string, DiscGolfDisc> discBySpeed = FillDictionary_Speed();
        private static readonly Dictionary<string, DiscGolfDisc> discByGlide = FillDictionary_Glide();
        private static readonly Dictionary<string, DiscGolfDisc> discByTurn = FillDictionary_Turn();
        private static readonly Dictionary<string, DiscGolfDisc> discByFade = FillDictionary_Fade();


        private static Dictionary<string, DiscGolfDisc> FillDictionary_Name()
        {
            Dictionary<string, DiscGolfDisc> discByName = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discByName.ContainsKey(disc.Name))
                    discByName.Add(disc.Name, disc);
            }

            return discByName;
        }

        private static Dictionary<string, DiscGolfDisc> FillDictionary_Brand()
        {
            Dictionary<string, DiscGolfDisc> discByBrand = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discByBrand.ContainsKey(disc.Brand))
                    discByBrand.Add(disc.Brand, disc);
            }

            return discByBrand;
        }

        private static Dictionary<string, DiscGolfDisc> FillDictionary_Type()
        {
            Dictionary<string, DiscGolfDisc> discByType = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discByType.ContainsKey(disc.Type))
                    discByType.Add(disc.Type, disc);
            }

            return discByType;
        }

        private static Dictionary<string, DiscGolfDisc> FillDictionary_Speed()
        {
            Dictionary<string, DiscGolfDisc> discBySpeed = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discBySpeed.ContainsKey(disc.Speed.ToString()))
                    discBySpeed.Add(disc.Speed.ToString(), disc);
            }

            return discBySpeed;
        }

        private static Dictionary<string, DiscGolfDisc> FillDictionary_Glide()
        {
            Dictionary<string, DiscGolfDisc> discByGlide = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discByGlide.ContainsKey(disc.Glide.ToString()))
                    discByGlide.Add(disc.Glide.ToString(), disc);
            }

            return discByGlide;
        }

        private static Dictionary<string, DiscGolfDisc> FillDictionary_Turn()
        {
            Dictionary<string, DiscGolfDisc> discByTurn = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discByTurn.ContainsKey(disc.Turn.ToString()))
                    discByTurn.Add(disc.Turn.ToString(), disc);
            }

            return discByTurn;
        }

        private static Dictionary<string, DiscGolfDisc> FillDictionary_Fade()
        {
            Dictionary<string, DiscGolfDisc> discByFade = new Dictionary<string, DiscGolfDisc>(); // Initialize the dictionary

            foreach (DiscGolfDisc disc in Discs)
            {
                if (!discByFade.ContainsKey(disc.Fade.ToString()))
                    discByFade.Add(disc.Fade.ToString(), disc);
            }

            return discByFade;
        }

        public static DiscGolfDisc GetDiscByName(string name)
        {
            DiscGolfDisc disc;

            if (discByName.TryGetValue(name, out disc))
            {
                return disc;
            }
            else
            {
                throw new KeyNotFoundException($"Disc with name '{name}' not found.");
            }
        }

        public static List<DiscGolfDisc> GetDiscsByBrand(string brand)
        {
            List<DiscGolfDisc> discs = Discs.Where(d => d.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase)).ToList();

            if (discs.Count > 0)
            {
                return discs;
            }
            else
            {
                throw new KeyNotFoundException($"No discs found for brand '{brand}'.");
            }
        }

        public static List<DiscGolfDisc> GetDiscsByType(string type)
        {
            List<DiscGolfDisc> discs = Discs.Where(d => d.Type.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();
            if (discs.Count > 0)
            {
                return discs;
            }
            else
            {
                throw new KeyNotFoundException($"No discs found for type '{type}'.");
            }
        }
    }
}
