using Quintessential;

namespace BOM;

internal class BloodsOfMetallurgy : QuintessentialMod
{
    public override string ModId => "bloods_of_metallurgy";
    public static BloodsOfMetallurgy Instance { get; }

    public override void Load()
    {
        Logger.Log("BOM: Letting the quicksilver flow");
        
    }
    public static bool BloodProjection(Sim sim, Part part)
    {
        if (!sim.GetAtomReference(part, new HexIndex(1, 0), false, out var projected) ||
            !AtomTag.AtomTags["om:$successor_proj"].HasAtom(projected, out var result) ||
            !sim.GetAtomReference(part, new HexIndex(0, 0), false, out var consumed) ||
            consumed.isHeldByArm || consumed.inMultiAtomMolecule || (consumed.atomType != (AtomTypes.quicksilver) 
            && consumed.atomType != (AtomTypes.GetByID("bloods_of_metallurgy:quickLead")) 
            && consumed.atomType != (AtomTypes.GetByID("bloods_of_metallurgy:quickTin")) 
            && consumed.atomType != (AtomTypes.GetByID("bloods_of_metallurgy:quickIron")) 
            && consumed.atomType != (AtomTypes.GetByID("bloods_of_metallurgy:quickCopper")) 
            && consumed.atomType != (AtomTypes.GetByID("bloods_of_metallurgy:quickGold")))) 
            return false;
        int inMetallicity = 0;
        int bloodMetallicity = 0;

        switch (projected.atomType.Id)
        {
            case "om:lead":
                inMetallicity = 1;
                break;
            case "om:tin":
                inMetallicity = 2;
                break;
            case "om:iron":
                inMetallicity = 4;
                break;
            case "om:copper":
                inMetallicity = 8;
                break;
            case "om:silver":
                inMetallicity = 16;
                break;
            default:
                inMetallicity = 999;
                break;
        }
        switch (consumed.atomType.Id)
        {
            case "bloods_of_metallurgy:quickLead":
                bloodMetallicity = 1;
                break;
            case "bloods_of_metallurgy:quickTin":
                bloodMetallicity = 2;
                break;
            case "bloods_of_metallurgy:quickIron":
                bloodMetallicity = 4;
                break;
            case "bloods_of_metallurgy:quickCopper":
                bloodMetallicity = 8;
                break;
            case "om:quicksilver":
                bloodMetallicity = 16;
                break;
            default:
                bloodMetallicity = 0;
                break;
        }
        if (inMetallicity > bloodMetallicity)
        {
            return false;
        }

        sim.RecipeInputs.Add(new HexIndex(1, 0), projected);
        sim.RecipeInputs.Add(new HexIndex(0, 0), consumed);
        sim.RecipeOutputs.Add(new HexIndex(0, 0), AtomTypes.GetByID(result.Value));
        return true;
    }

    public override void LoadContent()
    {
        
        BloodsOfMetallurgy.Instance.AddRecipe(new(BloodProjection), "bloods_of_metallurgy:bloodProjection", "om:projection");
        Atoms.AddAtomTypes();
        // Util.GlyphLUT.GenerateLUTs();
        MutationsAPI.AddTransmutations();
        Parts.AddParts();
        Logger.Log("BOM: successfully drenched in the bloods of the metals");
    }
    public override void LoadCompatContent() { }
    public override void FinaliseContent() { }

    public override void PostLoad() { }
    public override void Unload()
    {
        Logger.Log("BOM: patching my wounds and going to sleep.");
    }
}