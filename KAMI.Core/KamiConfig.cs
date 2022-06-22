using KAMI.Core.Utilities;

namespace KAMI.Core
{
    public class KamiConfig: IConfig
    {
        public int? ToggleKey { get; set; }
        public int? Mouse1Key { get; set; }
        public int? Mouse2Key { get; set; }
        public float Sensitivity { get; set; }
        public bool HideCursor { get; set; }

        public static IConfig GetDefaultConfig()
        {
            return new KamiConfig
            {
                ToggleKey = null,
                Mouse1Key = null,
                Mouse2Key = null,
                Sensitivity = 0.003f,
                HideCursor = false,
            };
        }
    }
}
