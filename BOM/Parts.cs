using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using Quintessential;
using static Quintessential.PartCycleDelegate;

namespace BOM;

internal class Parts
{
    public static PartType Coronation;
    public static Texture CoroBase = Assets.textures.parts.projection_glyph.@base;
    public static Texture CoroBowlSkin = Assets.textures.parts.projection_glyph.metal_bowl;
    public static Texture CoroHoleSkin = Assets.textures.parts.projection_glyph.quicksilver_input;
    public static Texture CoroIcon = Assets.textures.parts.icons.projection;
    public static Texture CoroIconHover = Assets.textures.parts.icons.projection_hover;
    public static HexIndex CoroBowl = new HexIndex(0, 0);
    public static HexIndex CoroHole = new HexIndex(1, 0);

    public static PartType Royalty;
    public static Texture RoyalBase = Assets.textures.parts.projection_glyph.@base;
    public static Texture RoyalBowlISkin = Assets.textures.parts.projection_glyph.metal_bowl;
    public static Texture RoyalHoleOSkin = Assets.textures.parts.rejection_glyph.metal_bowl;
    public static Texture RoyalIcon = Assets.textures.parts.icons.rejection;
    public static Texture RoyalIconHover = Assets.textures.parts.icons.rejection_hover;
    public static HexIndex RoyalBowlI = new HexIndex(0, 0);
    public static HexIndex RoyalBowlO = new HexIndex(1, 0);

    public static PartType Divergence;
    public static Texture DiverBase = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Divergence/base");
    public static Texture DiverConnectors = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Divergence/connectors");
    public static Texture DiverInHole = Assets.textures.parts.animismus.input;
    public static Texture DiverOut1 = Assets.textures.parts.output_base;
    public static Texture DiverOut1Ring = Assets.textures.parts.rejection_glyph.metal_bowl;
    public static Texture DiverOut2 = Assets.textures.parts.output_base;
    public static Texture DiverOut2Ring = Assets.textures.parts.rejection_glyph.metal_bowl;
    public static Texture DiverIcon = Assets.textures.parts.icons.purification;
    public static Texture DiverIconHover = Assets.textures.parts.icons.purification_hover;
    public static HexIndex DiverInLoc = new HexIndex(0, 1);
    public static HexIndex DiverOut1Loc = new HexIndex(0, 0);
    public static HexIndex DiverOut2Loc = new HexIndex(1, 0);

    public static PartType Insurrection;
    public static Texture InsurBase = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Insurrection/base");
    public static Texture InsurConnectors = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Insurrection/connectors");
    public static Texture InsurConnectorsShadow = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Insurrection/connectors_shadows");
    public static Texture InsurInput = Assets.textures.parts.animismus.input;
    public static Texture InsurOutLowerer = Assets.textures.parts.output_base;
    public static Texture InsurOutLower = Assets.textures.parts.animismus.output_under_iris;
    public static Texture InsurOutUpper = Assets.textures.parts.animismus.output_above_iris;
    public static Texture InsurIcon = Assets.textures.parts.icons.animismus;
    public static Texture InsurIconHover = Assets.textures.parts.icons.animismus_hover;
    public static HexIndex InsurIn1Loc = new HexIndex(0, 0);
    public static HexIndex InsurIn2Loc = new HexIndex(1, 0);
    public static HexIndex InsurOut1Loc = new HexIndex(1, -1);
    public static HexIndex InsurOut2Loc = new HexIndex(0, 1);

    public static PartType Promotion;
    public static Texture ProBase = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Promotion/base");
    public static Texture ProBase2 = AssetLoaderHelper.LoadTexture("textures/parts/CharlieW/BOM/Promotion/top");
    public static Texture ProMetals = Assets.textures.parts.proliferation_glyph.proliferation_metals;
    public static Texture ProBowl = Assets.textures.parts.proliferation_glyph.proliferation_bowl;
    public static Texture ProInputRing = Assets.textures.parts.animismus.output_above_iris;
    public static Texture ProIcon = Assets.textures.parts.icons.proliferation;
    public static Texture ProIconHover = Assets.textures.parts.icons.proliferation_hover;
    public static HexIndex ProBloodExcessLoc = new HexIndex(1, 0);
    public static HexIndex ProMetalBowlLoc = new HexIndex(-1, 0);
    public static HexIndex ProBloodInLoc = new HexIndex(1, -2);

    public static Texture Blank = Assets.textures.transparent;


    public static void AddParts()
    {
        Coronation = new()
        {
            cost = 20,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.double_glow,
            strokeTexture = Assets.textures.select.double_stroke,
            baseTexture = CoroIcon,
            hoverTexture = CoroIconHover,
            glyphHexes = new HexIndex[] { CoroBowl, CoroHole },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(BloodsOfMetallurgy.Instance.GetIdentifier("coronation"))
        };
        BloodsOfMetallurgy.Instance.AddPartType(Coronation, "coronation", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(CoroBase, Vector2.Zero, new Vector2(42f, 48f), 0f);
            renderer.RenderRotating(CoroBowlSkin, CoroBowl, Vector2.Zero);
            renderer.RenderRotating(CoroHoleSkin, CoroHole, Vector2.Zero);
        });
        Royalty = new()
        {
            cost = 40,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.double_glow,
            strokeTexture = Assets.textures.select.double_stroke,
            baseTexture = RoyalIcon,
            hoverTexture = RoyalIconHover,
            glyphHexes = new HexIndex[] { RoyalBowlI, RoyalBowlO },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(BloodsOfMetallurgy.Instance.GetIdentifier("royalty"))
        };
        BloodsOfMetallurgy.Instance.AddPartType(Royalty, "royalty", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(RoyalBase, Vector2.Zero, new Vector2(42f, 48f), 0f);
            renderer.RenderRotating(RoyalBowlISkin, RoyalBowlI, Vector2.Zero);
            renderer.RenderRotating(RoyalHoleOSkin, RoyalBowlO, Vector2.Zero);
        });
        Divergence = new()
        {
            cost = 30,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.triple_glow,
            strokeTexture = Assets.textures.select.triple_stroke,
            baseTexture = DiverIcon,
            hoverTexture = DiverIconHover,
            glyphHexes = new HexIndex[] { DiverInLoc, DiverOut1Loc, DiverOut2Loc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(BloodsOfMetallurgy.Instance.GetIdentifier("divergence"))
        };
        BloodsOfMetallurgy.Instance.AddPartType(Divergence, "divergence", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(DiverBase, Vector2.Zero, DiverBase.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(DiverInHole, DiverInLoc, Vector2.Zero);
            renderer.RenderUpright(DiverOut1, DiverOut1Loc, Vector2.Zero);
            renderer.RenderUpright(DiverOut2, DiverOut2Loc, Vector2.Zero);
            renderer.RenderBase(DiverConnectors, Vector2.Zero, DiverConnectors.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(DiverOut2Ring, DiverOut2Loc, Vector2.Zero);
            renderer.RenderRotating(DiverOut1Ring, DiverOut1Loc, Vector2.Zero);
        });
        Insurrection = new()
        {
            cost = 50,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.diamond_glow,
            strokeTexture = Assets.textures.select.diamond_stroke,
            baseTexture = InsurIcon,
            hoverTexture = InsurIconHover,
            glyphHexes = new HexIndex[] { InsurIn1Loc, InsurIn2Loc, InsurOut1Loc, InsurOut2Loc },
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(BloodsOfMetallurgy.Instance.GetIdentifier("insurrection"))
        };
        BloodsOfMetallurgy.Instance.AddPartType(Insurrection, "insurrection", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(InsurBase, Vector2.Zero, InsurBase.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(InsurInput, InsurIn1Loc, Vector2.Zero);
            renderer.RenderRotating(InsurInput, InsurIn2Loc, Vector2.Zero);
            renderer.RenderUpright(InsurOutLowerer, InsurOut1Loc, Vector2.Zero);
            renderer.RenderUpright(InsurOutLowerer, InsurOut2Loc, Vector2.Zero);
            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            renderer.RenderBase(InsurConnectors, Vector2.Zero, InsurConnectors.GetHalfSizeRounded(), 0f);
            renderer.RenderBase(InsurConnectors, Vector2.Zero, InsurConnectorsShadow.GetHalfSizeRounded(), 0f);
            renderer.RenderIris(intermState, InsurOut1Loc, time, InsurOutLower, Assets.textures.parts.iris_full, InsurOutUpper, pss.wasActivated ? pss.processingAtoms[0] : null);
            renderer.RenderIris(intermState, InsurOut2Loc, time, InsurOutLower, Assets.textures.parts.iris_full, InsurOutUpper, pss.wasActivated ? pss.processingAtoms[1] : null);
            // renderer.RenderUpright(DiverOut1Ring, InsurOut1Loc, Vector2.Zero);
            // renderer.RenderUpright(DiverOut1Ring, InsurOut2Loc, Vector2.Zero);
        });
        Promotion = new()
        {
            cost = 50,
            isFullHexCover = true,
            glowTexture = Assets.textures.select.proliferation_glow,
            strokeTexture = Assets.textures.select.proliferation_stroke,
            baseTexture = ProIcon,
            hoverTexture = ProIconHover,
            glyphHexes = new HexIndex[] { ProBloodInLoc, ProMetalBowlLoc, ProBloodExcessLoc},
            permissionCategory = PuzzlePermissions.None,
            CustomPermissionCheck = perms => perms.Contains(BloodsOfMetallurgy.Instance.GetIdentifier("promotion"))
        };
        BloodsOfMetallurgy.Instance.AddPartType(Promotion, "promotion", (part, pos, editor, renderer) =>
        {
            renderer.RenderBase(ProBase, Vector2.Zero, ProBase.GetHalfSizeRounded(), 0f);
            renderer.RenderBase(ProBase2, Vector2.Zero, ProBase2.GetHalfSizeRounded(), 0f);
            renderer.RenderRotating(ProInputRing, ProBloodInLoc, Vector2.Zero);
            renderer.RenderRotating(ProBowl, ProMetalBowlLoc, Vector2.Zero);
            renderer.RenderUpright(ProMetals, ProMetalBowlLoc, Vector2.Zero);
            IntermediatePartState intermState = editor.GetIntermState(part, pos);
            float time = editor.GetCycleTime();
            PartSimState pss = editor.GetSimulation().GetSimState(part);
            renderer.RenderIris(intermState, ProBloodExcessLoc, time, Blank, Assets.textures.parts.iris_full, ProInputRing, pss.isProcessing ? pss.processingAtoms[0] : null);
        });
        QApi.AddPartTypeToPanel(Coronation, false);
        QApi.AddPartTypeToPanel(Royalty, false);
        QApi.AddPartTypeToPanel(Divergence, false);
        QApi.AddPartTypeToPanel(Insurrection, false);
        QApi.AddPartTypeToPanel(Promotion, false);
        BloodsOfMetallurgy.Instance.AddPuzzlePermission("coronation");
        BloodsOfMetallurgy.Instance.AddPuzzlePermission("royalty");
        BloodsOfMetallurgy.Instance.AddPuzzlePermission("divergence");
        BloodsOfMetallurgy.Instance.AddPuzzlePermission("insurrection");
        BloodsOfMetallurgy.Instance.AddPuzzlePermission("promotion");
        QApi.BindGlyphCycle(Coronation, new(PartCycleExecutionType.Normal, CoronationCycle));
        QApi.BindGlyphCycle(Royalty, new(PartCycleExecutionType.Normal, RoyalCycle));
        QApi.BindGlyphCycle(Divergence, new(PartCycleExecutionType.Normal, DiverCycle));
        QApi.BindGlyphCycle(Insurrection, new(PartCycleExecutionType.Normal, InsurCycle));
        QApi.BindGlyphCycle(Promotion, new(PartCycleExecutionType.Normal, ProCycle));
        BloodsOfMetallurgy.Instance.AddRecipe(new(), Coronation.Id, Coronation.Id);
        BloodsOfMetallurgy.Instance.AddRecipe(new(), Royalty.Id, Royalty.Id);
        BloodsOfMetallurgy.Instance.AddRecipe(new(), Divergence.Id, Divergence.Id);
        BloodsOfMetallurgy.Instance.AddRecipe(new(), Insurrection.Id, Insurrection.Id);
        BloodsOfMetallurgy.Instance.AddRecipe(new(), Promotion.Id, Promotion.Id);

    }

    public static bool CoronationCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if ((!sim.FindAtomRelative(part, CoroBowl).GetOrDefault(out AtomReference CoroA)) || 
            (!sim.FindAtomRelative(part, CoroHole).GetOrDefault(out AtomReference CoroB)))
        {
            return false;
        }
        if (CoroB.isHeldByArm || CoroB.inMultiAtomMolecule)
        {
            return false;
        }
        foreach (var recipe in MutationsAPI.coronationTransmutations)
        {
            if (recipe.input == CoroA.atomType && recipe.host == CoroB.atomType)
            {
                CoroB.molecule.RemoveAtom(CoroB.pos);
                CoroA.molecule.ReplaceAtom(recipe.output, CoroA.pos);
                CoroA.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, CoroA.atomType, Assets.textures.atoms.projection_effect, 30f);
                return true;
            }
        }
        return false;
    }
    public static bool RoyalCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if (!sim.FindAtomRelative(part, RoyalBowlI).GetOrDefault(out AtomReference RoyalA))
        {
            return false;
        }
        if (sim.FindAtomRelative(part, RoyalBowlO).GetOrDefault(out AtomReference RoyalB))
        {
            return false;
        }
        foreach (var recipe in MutationsAPI.royaltyTransmutations)
        {
            if (recipe.input == RoyalA.atomType)
            {
                RoyalA.molecule.ReplaceAtom(recipe.output1, RoyalA.pos);
                sim.SpawnAtomRelative(recipe.output2, part, RoyalBowlO);
                RoyalA.atom.transmutationEffect = new TransmutationEffect(sim.solutionEditor, (TransmutationEffectRenderMode)1, RoyalA.atomType, Assets.textures.atoms.projection_effect, 30f);
                return true;
            }
        }
        return false;
    }
    public static bool DiverCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if ((!sim.FindAtomRelative(part, DiverInLoc).GetOrDefault(out AtomReference Subject)))
        {
            return false;
        }
        if ((Subject.isHeldByArm || Subject.inMultiAtomMolecule))
        {
            return false;
        }
        if (sim.FindAtomRelative(part, DiverOut1Loc).GetOrDefault(out AtomReference IDC) ||
            sim.FindAtomRelative(part, DiverOut2Loc).GetOrDefault(out AtomReference IDC2))
        {
            return false;
        }
        foreach (var recipe in MutationsAPI.divergenceTransmutations)
        {
            if (recipe.input == Subject.atomType)
            {
                Subject.molecule.RemoveAtom(Subject.pos);
                sim.solutionEditor.DrawFallingAtom(Subject);
                sim.SpawnAtomRelative(recipe.output1, part, DiverOut1Loc);
                sim.SpawnAtomRelative(recipe.output2, part, DiverOut2Loc);
                
                return true;
            }
        }
        return false;
    }
    public static bool InsurCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if (!pss.isProcessing)
        {
            if (first)
            {
                if ((!sim.FindAtomRelative(part, InsurIn1Loc).GetOrDefault(out AtomReference Subject1)) || // Make sure input atoms exist
                (!sim.FindAtomRelative(part, InsurIn2Loc).GetOrDefault(out AtomReference Subject2)))
                {
                    return false;
                }
                if ((Subject1.isHeldByArm || Subject1.inMultiAtomMolecule) || // Check if atom 1 is a singlet 
                    (Subject2.isHeldByArm || Subject2.inMultiAtomMolecule) || // Check if atom 2 is a singlet
                    (Subject1.atomType == Subject2.atomType))                 // Check to make sure atoms aren't the same
                {
                    return false;
                }
                if (sim.FindAtomRelative(part, InsurOut1Loc).GetOrDefault(out AtomReference IDC) || // make sure outputs are clear
                    sim.FindAtomRelative(part, InsurOut2Loc).GetOrDefault(out AtomReference IDC2))
                {
                    return false;
                }
                if (!(MutationsAPI.AttributesFromMetal(Subject1.atomType, out bool isQuix1, out int metalSize1)) || // grab atoms 1 & 2 data
                    !(MutationsAPI.AttributesFromMetal(Subject2.atomType, out bool isQuix2, out int metalSize2)))
                {
                    return false;
                }
                if (isQuix1 == isQuix2) // make sure atoms aren't both metal or quix
                {
                    return false;
                }

                bool temp = isQuix1; // swap quicknesses
                isQuix1 = isQuix2;
                isQuix2 = temp;
                AtomType Output1;
                AtomType Output2;
                if (isQuix1)
                {
                    MutationsAPI.MetalFromAttributes(isQuix1, metalSize1, out Output1); // get output atoms from our modified attributes
                    MutationsAPI.MetalFromAttributes(isQuix2, metalSize2, out Output2);
                }
                else
                {
                    MutationsAPI.MetalFromAttributes(isQuix1, metalSize1, out Output2); // get output atoms from our modified attributes 
                    MutationsAPI.MetalFromAttributes(isQuix2, metalSize2, out Output1); // but flipped because quix on bottom
                }

               

                Subject1.molecule.RemoveAtom(Subject1.pos); // Kill inputs
                Subject2.molecule.RemoveAtom(Subject2.pos);

                sim.solutionEditor.DrawFallingAtom(Subject1); // draw falling atoms
                sim.solutionEditor.DrawFallingAtom(Subject2);

                pss.processingAtoms = new AtomType[] { Output1, Output2 }; // send out outputs pt1
                pss.isProcessing = true;

                sim.SpawnColliderRelative(part, InsurOut1Loc); // Colliders for rising atoms
                sim.SpawnColliderRelative(part, InsurOut2Loc);

                return true;
            }
            
        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, InsurOut1Loc); // send out outputs pt2
            sim.SpawnAtomRelative(pss.processingAtoms[1], part, InsurOut2Loc);
            return true;
        }
        return false;
    }
    public static bool ProCycle(Sim sim, Part part, PartSimState pss, GlyphRecipe _, bool first)
    {
        if (!pss.isProcessing)
        {
            if (first)
            {
                if ((!sim.FindAtomRelative(part, ProBloodInLoc).GetOrDefault(out AtomReference BloodIn)) || // Make sure input atoms exist
                (!sim.FindAtomRelative(part, ProMetalBowlLoc).GetOrDefault(out AtomReference MetalIn)))
                {
                    return false;
                }
                if (BloodIn.isHeldByArm || BloodIn.inMultiAtomMolecule) // Check to make sure blood input isn't held or in a molecule
                {
                    return false;
                }
                if (sim.FindAtomRelative(part, ProBloodExcessLoc).GetOrDefault(out AtomReference IDC)) // Make sure output isn't covered
                {
                    return false;
                }
                if (!(MutationsAPI.AttributesFromMetal(BloodIn.atomType, out bool isQuix1, out int metalSize1)) || // grab atoms 1 & 2 data
                    !(MutationsAPI.AttributesFromMetal(MetalIn.atomType, out bool isQuix2, out int metalSize2)))
                {
                    return false;
                }
                if (!isQuix1 || isQuix2 || // make sure atoms are the proper metal type and that the blood is big enough to do anything
                    metalSize1 < metalSize2) 
                {
                    return false;

                }
                while (metalSize1 >= metalSize2)
                {
                    metalSize1 -= metalSize2;
                    metalSize2 += metalSize2;
                    Logger.Log(metalSize1 + " " + metalSize2);
                }
                AtomType Output1;
                AtomType Output2;
                Logger.Log(metalSize1 + " " + metalSize2);
                if (metalSize1 != 0)
                {
                    MutationsAPI.MetalFromAttributes(isQuix1, metalSize1, out Output1);
                    sim.SpawnColliderRelative(part, ProBloodExcessLoc); // Colliders for rising atoms
                    pss.processingAtoms = new AtomType[] { Output1 }; // send out outputs pt1
                    pss.isProcessing = true;
                }
                MutationsAPI.MetalFromAttributes(isQuix2, metalSize2, out Output2);

                BloodIn.molecule.RemoveAtom(BloodIn.pos); // Kill inputs

                sim.solutionEditor.DrawFallingAtom(BloodIn); // draw falling atoms

                MetalIn.molecule.ReplaceAtom(Output2, MetalIn.pos);

                return true;
            }
            
        }
        else if (!pss.wasActivated)
        {
            sim.SpawnAtomRelative(pss.processingAtoms[0], part, ProBloodExcessLoc); // send out outputs pt2
            return true;
        }
        return false;
    }
}