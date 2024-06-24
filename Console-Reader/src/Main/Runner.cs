using Console_Reader.src.Services;

namespace Console_Reader.src.Main
{
    public class Runner
    {
        public static void Main()
        {
            IReturn _Return = new Return();

            _Return.PrintResult();
        }
    }
}
