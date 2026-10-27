using Quintessential;
using System;
using System.Collections.Generic;
using System.Text;

namespace BOM;

internal static class Atoms
{
    public static AtomType QuickLead, QuickTin, QuickIron, QuickCopper, QuickGold;
    public static void AddAtomTypes()
    {
        QuickLead = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qlead_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qlead_diffuse"),
                shade = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qlead_shade")
            }
        };
        BOM.BloodsOfMetallurgy.Instance.AddAtomType(QuickLead, "quickLead");
        QuickTin = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qtin_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qtin_diffuse"),
                shade = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qtin_shade")
            }
        };
        BOM.BloodsOfMetallurgy.Instance.AddAtomType(QuickTin, "quickTin");
        QuickIron = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qIron_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qIron_diffuse"),
                shade = Assets.textures.atoms.salt_shade
            }
        };
        BOM.BloodsOfMetallurgy.Instance.AddAtomType(QuickIron, "quickIron");
        QuickCopper = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qcopper_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qcopper_diffuse"),
                shade = Assets.textures.atoms.salt_shade
            }
        };
        BOM.BloodsOfMetallurgy.Instance.AddAtomType(QuickCopper, "quickCopper");
        QuickGold = new()
        {
            shadow = Assets.textures.atoms.shadow,
            symbol = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qGold_symbol"),
            matteTextures = new()
            {
                diffuse = AssetLoaderHelper.LoadTexture("textures/atoms/CharlieW/BOM/qGold_diffuse"),
                shade = Assets.textures.atoms.salt_shade
            }
        };
        BOM.BloodsOfMetallurgy.Instance.AddAtomType(QuickGold, "quickGold");
    }
}