namespace Dalion.WebAppTemplate {
    public class Program {
        public static int Main(string[] args) {
            return Startup.Bootstrapper.RunForResolvedEnvironment(args);
        }
    }
}