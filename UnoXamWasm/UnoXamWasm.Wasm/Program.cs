namespace UnoXamWasm.Wasm
{
    public class Program
    {
        static int Main(string[] args)
        {
            Windows.UI.Xaml.Application.Start(_ => new UWP.App());

            return 0;
        }
    }
}
