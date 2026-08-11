using BuilderPattern;

internal class Program
{
    public static void Print(ComputerBuilder builder)
    {
        var computer = builder.Build();
        Console.WriteLine(computer.Cpu);
    }
    private static void Main(string[] args)
    {
        var computer = new ComputerBuilder()
             .SetCpu("abc")
             .SetRam(32)
             .SetStorage(1000)
             .SetGpu("gpu")
             .SetWifi(true);

        Print(computer);
    }
}