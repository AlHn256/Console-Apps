using System;
using System.Threading;
using System.Threading.Tasks;

namespace TaskStop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Start();
        }

        async static void Start()
        {

            var cts = new CancellationTokenSource();
            var task = Task.Run(() => Process(cts.Token));
            //Task.Delay(3500).GetAwaiter().GetResult();
            //cts.Cancel();

            try
            {
                for (int j = 0; j < 11; j++)
                {

                    //var GetResult = task.GetAwaiter().GetResult();
                    Console.WriteLine("j " + j);
                    //if (j== 6)
                    //{
                    //    var GetAwaiter = task.GetAwaiter();
                    //    Console.WriteLine(j + "GetAwaiter.IsCompleted " + GetAwaiter.IsCompleted);
                    //    Task.Delay(400).GetAwaiter().GetResult();
                    //}

                    await Task.Delay(500);
                }
                await task;
            }
            catch(OperationCanceledException)
            {
                Console.WriteLine("Canceled");
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception " + e.Message);
            }
        }

        async static Task Process(CancellationToken ct)
        {
            var i = 0;
            while (true)
            {
                ct.ThrowIfCancellationRequested();
                Console.WriteLine("i"+i++);
                await Task.Delay(400);
            }
        }
    }
}
