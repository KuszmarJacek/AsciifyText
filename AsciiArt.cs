using Figgle;
using System.Reflection;

namespace AsciifyText
{
    public static class AsciiArt
    {
        public static string Write(string text, string? fontName = null)
        {
            FiggleFont? font = null;
            if (!string.IsNullOrWhiteSpace(fontName))
            {
                PropertyInfo? fontPropertyInfo =
                    typeof(FiggleFonts)
                    .GetProperty(fontName, BindingFlags.Public | BindingFlags.Static);
                if (fontPropertyInfo != null)
                {
                    // pass null to GetValue(...) since we want to get static fields
                    font = fontPropertyInfo.GetValue(null) as FiggleFont;
                }
            }
            if (font == null) {
                font = FiggleFonts.Standard;
            }
            return font.Render(text);
        }

        public static Lazy<IEnumerable<string>> AllFonts =
            new(() =>
                typeof(FiggleFonts).GetProperties(BindingFlags.Public | BindingFlags.Static)
                .Select(p => p.Name)
            );
    }
}
