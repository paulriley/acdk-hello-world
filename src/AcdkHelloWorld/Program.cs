using Amazon.CDK;

namespace AcdkHelloWorld
{
    public sealed class Program
    {
        public static void Main()
        {
            var app = new App();
            _ = new AcdkHelloWorldStack(app, "AcdkHelloWorldStack");

            _ = app.Synth();
        }
    }
}
