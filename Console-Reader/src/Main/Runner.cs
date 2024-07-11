using Console_Reader.src.Services;

namespace Console_Reader.src.Main
{
    public class Runner
    {
        public static IReturn _Return = new Return();
        public static void Main() => _Return.PrintResult();
    }
}
