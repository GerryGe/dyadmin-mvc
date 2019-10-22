using System.Collections.Generic;

namespace Dychar.Dyadmin.Configuration.Ui
{
    public static class UiThemes
    {
        public static List<UiThemeInfo> All { get; }

        static UiThemes()
        {
            All = new List<UiThemeInfo>
            {
                new UiThemeInfo("Black", "skin-black"),
                new UiThemeInfo("Black Light", "skin-black-light"),
                new UiThemeInfo("Blue", "skin-blue"),
                new UiThemeInfo("Blue Light", "skin-blue-light"),
                new UiThemeInfo("Green", "skin-green"),
                new UiThemeInfo("Green Light", "skin-green-light"),
                new UiThemeInfo("Purple", "skin-purple"),
                new UiThemeInfo("Purple Light", "skin-purple-light"),
                new UiThemeInfo("Red", "skin-red"),
                new UiThemeInfo("Red Light", "skin-red-light"),
                new UiThemeInfo("Yellow", "skin-yellow"),
                new UiThemeInfo("Yellow Light", "skin-yellow-light"),
            };
        }
    }
}
