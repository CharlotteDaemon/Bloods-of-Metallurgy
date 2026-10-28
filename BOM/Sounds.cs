namespace BOM
{
    internal class Sounds
    {
        public static Sound Coronation_Sound, Divergence_Sound, Insurrection_Sound, Promotion_Sound, Promotion_Excess, Royalty_Metal, Royalty_Quix;
        public static void AddSounds()
        {
            Coronation_Sound = AssetLoaderHelper.LoadSound("sounds/Coronation_Trigger");
            Divergence_Sound = AssetLoaderHelper.LoadSound("sounds/Divergence_Trigger");
            Insurrection_Sound = AssetLoaderHelper.LoadSound("sounds/Insurrection_Trigger");
            Promotion_Sound = AssetLoaderHelper.LoadSound("sounds/Promotion_Trigger");
            Promotion_Excess = AssetLoaderHelper.LoadSound("sounds/Promotion_Excess_Ejected");
            Royalty_Metal = AssetLoaderHelper.LoadSound("sounds/Royalty_Rejects_Metal");
            Royalty_Quix = AssetLoaderHelper.LoadSound("sounds/Royalty_Rejects_Quix");


            Volume.SetVolume(Coronation_Sound, 0.35f);
            Volume.SetVolume(Divergence_Sound, 0.35f);
            Volume.SetVolume(Insurrection_Sound, 0.35f);
            Volume.SetVolume(Promotion_Sound, 0.35f);
            Volume.SetVolume(Promotion_Excess, 0.35f);
            Volume.SetVolume(Royalty_Metal, 0.35f);
            Volume.SetVolume(Royalty_Quix, 0.35f);

        }
    }
}