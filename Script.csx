using System.Runtime.CompilerServices;
using System.Threading;

public static class Script
{
    private static string scriptFolder;

    public static void Bootstrap(IList<string> args, [CallerFilePath] string path = null)
    {
        if (string.IsNullOrEmpty(path))
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine("The bootstrapping script path must not be null or empty.");
            throw new Exception("Script boot strapping error.");
        }

        Args = args;

        scriptFolder = Path.GetDirectoryName(path);
    }

    public static string ScriptFolder
    {
        get
        {
            if (string.IsNullOrEmpty(scriptFolder))
            {
                WriteLine("The script has not been bootstrapped.");
                throw new Exception("Script boot strapping error.");
            }

            return scriptFolder;
        }
    }

    public static IList<string> Args { get; private set; }

    public static void WaitForDebugger()
    {
        WriteLine("Waiting to attach debugger from VSCode. ");
        while(!Debugger.IsAttached)
        {
            Thread.Sleep(1000);
            Write(". ");
        }
    }
}