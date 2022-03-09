using System.Threading;
using System.Diagnostics;

namespace MultithreadingStuff;

public class Program
{
    static int taskResult = 0;
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");

        CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        Task<int> task = Task.Run(
        () => Increment('.', cancellationTokenSource.Token),
        cancellationTokenSource.Token);

        Task<int> task2 = Task.Run(
        () => Decrement('.', cancellationTokenSource.Token),
        cancellationTokenSource.Token);

        Console.WriteLine("Press ENTER to stop");
        Console.ReadLine();
        cancellationTokenSource.Cancel();
        taskResult = task.Result;
        Console.WriteLine(task.Result);

        taskResult = task2.Result;
        Console.WriteLine(task2.Result);

        task.Wait();
        Console.WriteLine("Exiting!!!!");

        Task<int> task3 = Task.Run(
        () => StartProcess());

        Console.WriteLine("Process exited with: " + task3.Result);
    }

    static int Increment(char character, CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            taskResult++;
            Console.Write(character);
            Console.Write(taskResult);
        }
        return taskResult;
    }

    static int Decrement(char character, CancellationToken token)
    {
        while (!token.IsCancellationRequested)
        {
            taskResult--;
            Console.Write(character);
            Console.Write(taskResult);
        }
        return taskResult;
    }

    static int StartProcess()
    {
        Process p = Process.Start("ping", "google.com");
        p.WaitForExit();

        return p.ExitCode;
    }
}
