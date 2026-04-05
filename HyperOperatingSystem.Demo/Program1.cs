using System.Runtime;
namespace Global.HyperOperatingSystem.Demo;
using System;
using System.CodeDom;
using Global;
using static Core.CoreObject;
public static class Program1 {
    public static void Main(string[] args) {
        try
        {
            DebugOutput = true;
            ShowDetail = false;
            SetupConsoleEncoding();
            Log(
                "⁅markup⁆[green]Hello! ハロー© ⁅EMOJI⁆◉▶▸⸝↪️ ↩️ ℴ𝓬➺➢ᰔヾ➠✅🈂️❓❗＼／：＊“≪≫￤；‘｀＃％＄＆＾～￤﴾﴿⁅⁆【】≪≫＋ー＊＝⚽ 𝑪𝒉𝒆𝒄𝒌 🌐🪩[/]");
            var greeting = new string[] { "Hello", "World", "my", "name", "is", "Tom" };
            Debug(new { args });
            var answer = HyperOperatingSystem.Add2(11, 22);
            Debug(new { answer });
        }
        catch (Exception ex)
        {
            Console.Error.WriteLine(ex);
        }
    }
}