using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Parallel
    {
       public void test()
        {

            //Parallel.For(0, 10, i =>
            //{
            //    for (int j = 0; j < matBCols; j++)
            //    {
            //        double temp = 0;
            //        for (int k = 0; k < matACols; k++)
            //        {
            //            temp += matA[i, k] * matB[k, j];
            //        }
            //        result[i, j] = temp;
            //    }
            //}); // Parallel.For

            //Parallel.ForEach(files, (currentFile) =>
            //{
            //    // The more computational work you do here, the greater 
            //    // the speedup compared to a sequential foreach loop.
            //    string filename = Path.GetFileName(currentFile);
            //    var bitmap = new Bitmap(currentFile);

            //    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
            //    bitmap.Save(Path.Combine(newDir, filename));

            //    // Peek behind the scenes to see how work is parallelized.
            //    // But be aware: Thread contention for the Console slows down parallel loops!!!

            //    Console.WriteLine($"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}");
            //    //close lambda expression and method invocation
            //});

            //async Task<Toast> MakeToastWithButterAndJamAsync(int number)
            //{
            //    var toast = await ToastBreadAsync(number);
            //    ApplyButter(toast);
            //    ApplyJam(toast);
            //    return toast;
            //}

            //var t = Task.Run(() => ShowThreadInfo("Task"));
            //t.Wait();

            //tasks[0] = Task.Factory.StartNew(() => files = Directory.GetFiles(docsDirectory));
        }
    }
}
