using System.Diagnostics;

try
{

    new Main().Run();

    new Main().End();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
    Console.ReadLine();
}


public class Main
{
    public void Run()
    {
        Stopwatch stopwatch = new Stopwatch();
        ShowDataDownloder showDataDownloder = new ShowDataDownloder();
        
        stopwatch.Start();
        Console.WriteLine(showDataDownloder.DataDownload("id1"));
        Console.WriteLine(showDataDownloder.DataDownload("id2"));
        Console.WriteLine(showDataDownloder.DataDownload("id3"));
        Console.WriteLine(showDataDownloder.DataDownload("id1"));
        Console.WriteLine(showDataDownloder.DataDownload("id5"));
        Console.WriteLine(showDataDownloder.DataDownload("id3"));
        Console.WriteLine(showDataDownloder.DataDownload("id1"));
        stopwatch.Stop();
        Console.WriteLine($"Time is : {stopwatch.ElapsedMilliseconds}s");
        Console.WriteLine("\n\n\n");
        stopwatch.Start();
        Console.WriteLine(showDataDownloder.SlowDataDownload("id1"));
        Console.WriteLine(showDataDownloder.SlowDataDownload("id2"));
        Console.WriteLine(showDataDownloder.SlowDataDownload("id3"));
        Console.WriteLine(showDataDownloder.SlowDataDownload("id1"));
        Console.WriteLine(showDataDownloder.SlowDataDownload("id5"));
        Console.WriteLine(showDataDownloder.SlowDataDownload("id3"));
        Console.WriteLine(showDataDownloder.SlowDataDownload("id1"));
        stopwatch.Stop();
        Console.WriteLine($"Time is : {stopwatch.ElapsedMilliseconds}s");

    }
    public void End()
    {
        Console.WriteLine("Enter Any Key To Exit Programe.");
        Console.ReadKey();
    }
}

public interface IDataDownloder 
{
    public string DataDownload(string resource);
}
public class ShowDataDownloder  : IDataDownloder 
{
    public List<string> CashData = new List<string>();

    public string DataDownload(string resource)
    {
        if (!CashData.Contains(resource))
        {
            
            CashData.Add(resource);
            Thread.Sleep(2000);
            return $"some data for {resource}";
        }

        return $"some data for {resource} cash";
        
    }
    public string SlowDataDownload(string resource)
    {  
            Thread.Sleep(2000);
            return $"some data for {resource}";

    }

}
