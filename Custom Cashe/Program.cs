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
        
        var showDataDownloder = new ShowDataDownloder();
        
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
public class Cashe<TKey, TData>
{
    private readonly Dictionary<TKey, TData> _cashData = new();

    public TData Get(TKey key,Func<TKey,TData> getForTheFirstTime)
    {
        if(! _cashData.ContainsKey(key))
        {
            _cashData[key] = getForTheFirstTime(key);
        }
        return _cashData[key];
    }

  
}

public class ShowDataDownloder : IDataDownloder 
{
    private readonly Cashe<string, string> _cash = new();

    public string DataDownload  (string resource)
    {

        return _cash.Get(resource,DataDownloadWithOutCashing);
        
    }
    private string DataDownloadWithOutCashing(string resource)
    {

        Thread.Sleep(2000);
        return $"some data for {resource}";

    }

}
