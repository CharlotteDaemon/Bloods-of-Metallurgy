using Quintessential;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOM;


internal static class MutationsAPI
{
    public struct CoronationRecipe
    {
        public CoronationRecipe(AtomType input, AtomType host, AtomType output)
        {
            this.input = input;
            this.host = host;
            this.output = output;
        }

        public bool IsMatch(AtomType input, AtomType host)
        {
            return this.input == input && this.host == host;
        }

        public AtomType input;
        public AtomType host;
        public AtomType output;
    }
    public struct RoyaltyRecipe
    {
        public RoyaltyRecipe(AtomType input, AtomType output1, AtomType output2)
        {
            this.input = input;
            this.output1 = output1;
            this.output2 = output2;
        }

        public bool IsMatch(AtomType input)
        {
            return this.input == input;
        }

        public AtomType input;
        public AtomType output1;
        public AtomType output2;
    }
    public struct DivergenceRecipe
    {
        public DivergenceRecipe(AtomType input, AtomType output1, AtomType output2)
        {
            this.input = input;
            this.output1 = output1;
            this.output2 = output2;
        }

        public bool IsMatch(AtomType input)
        {
            return this.input == input;
        }

        public AtomType input;
        public AtomType output1;
        public AtomType output2;
    }
    public struct InsurrectionData
    {
        public AtomType MetalAtom;
        public bool IsQuix;
        public int MetalSize;
        public InsurrectionData(AtomType metalAtom, bool isQuix, int metalSize )
        {
            MetalAtom = metalAtom;
            IsQuix = isQuix;
            MetalSize = metalSize;
        }
    }

    public static List<CoronationRecipe> coronationTransmutations = new();
    public static List<RoyaltyRecipe> royaltyTransmutations = new();
    public static List<DivergenceRecipe> divergenceTransmutations = new();
    public static List<InsurrectionData> metalChart = new();

    public static void AddTransmutations()
    {
        var QGold = Atoms.QuickGold;
        var QSilver = AtomTypes.quicksilver;
        var QCopper = Atoms.QuickCopper;
        var QIron = Atoms.QuickIron;
        var QTin = Atoms.QuickTin;
        var QLead = Atoms.QuickLead;

        var Gold = AtomTypes.gold;
        var Silver = AtomTypes.silver;
        var Copper = AtomTypes.copper;
        var Iron = AtomTypes.iron;
        var Tin = AtomTypes.tin;
        var Lead = AtomTypes.lead;
        
        /*** Coronation ***/
        /* Hole Atom, Bowl Atom, Result */
        coronationTransmutations.Add(new(QCopper, QCopper, QSilver));
        coronationTransmutations.Add(new(QIron, QIron, QCopper));
        coronationTransmutations.Add(new(QTin, QTin, QIron));
        coronationTransmutations.Add(new(QLead, QLead, QTin));
        /*** Royalty ***/
        /* Bowl Atom, Bowl Atom Result, Other Bowl New Atom Result */
        royaltyTransmutations.Add(new(Gold, Silver, QSilver));
        royaltyTransmutations.Add(new(Silver, Copper, QCopper));
        royaltyTransmutations.Add(new(Copper, Iron, QIron));
        royaltyTransmutations.Add(new(Iron, Tin, QTin));
        royaltyTransmutations.Add(new(Tin, Lead, QLead));

        /* Bowl Atom, Bowl Atom Result, Other Bowl New Atom Result */
        royaltyTransmutations.Add(new(QGold, QSilver, QSilver));
        royaltyTransmutations.Add(new(QSilver, QCopper, QCopper));
        royaltyTransmutations.Add(new(QCopper, QIron, QIron));
        royaltyTransmutations.Add(new(QIron, QTin, QTin));
        royaltyTransmutations.Add(new(QTin, QLead, QLead));
        /*** Divergence ***/
        /* Hole Atom, Left Atom Out, Right Atom Out (Usually same at Left Atom) */
        divergenceTransmutations.Add(new(Gold, Silver, Silver));
        divergenceTransmutations.Add(new(Silver, Copper, Copper));
        divergenceTransmutations.Add(new(Copper, Iron, Iron));
        divergenceTransmutations.Add(new(Iron, Tin, Tin));
        divergenceTransmutations.Add(new(Tin, Lead, Lead));
        /*** Metallicity Chart ***/
        /* Atoms.<AtomName>, true if this is meant to be a quicksilver-like, metallicity */
        metalChart.Add(new InsurrectionData(Gold, false, 32));
        metalChart.Add(new InsurrectionData(Silver, false, 16));
        metalChart.Add(new InsurrectionData(Copper, false, 8));
        metalChart.Add(new InsurrectionData(Iron, false, 4));
        metalChart.Add(new InsurrectionData(Tin, false, 2));
        metalChart.Add(new InsurrectionData(Lead, false, 1));

        metalChart.Add(new InsurrectionData(QGold, true, 32));
        metalChart.Add(new InsurrectionData(QSilver, true, 16));
        metalChart.Add(new InsurrectionData(QCopper, true, 8));
        metalChart.Add(new InsurrectionData(QIron, true, 4));
        metalChart.Add(new InsurrectionData(QTin, true, 2));
        metalChart.Add(new InsurrectionData(QLead, true, 1));
        /*** End ***/

    }

    public static bool MetalFromAttributes(bool isQuix, int metalSize, out AtomType metalAtom)
    {
        metalAtom = default;

        foreach (var entry in metalChart)
        {
            if (entry.IsQuix == isQuix && entry.MetalSize == metalSize)
            {
                metalAtom = entry.MetalAtom;
                return true;
            }

        }
        return false;
    }

    public static bool AttributesFromMetal(AtomType metalAtom, out bool isQuix, out int metalSize)
    {
        isQuix = false;
        metalSize = 0;

        foreach (var entry in metalChart)
        {
            if (entry.MetalAtom == metalAtom)
            {
                metalSize = entry.MetalSize;
                isQuix = entry.IsQuix;
                return true;
            }

        }
        return false;
    }
}
