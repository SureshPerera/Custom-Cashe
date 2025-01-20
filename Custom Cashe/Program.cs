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
        ShowDataDownloder showDataDownloder = new ShowDataDownloder();

        Console.WriteLine(showDataDownloder.DataDownload("id1"));
        Console.WriteLine(showDataDownloder.DataDownload("id2"));
        Console.WriteLine(showDataDownloder.DataDownload("id3"));
        Console.WriteLine(showDataDownloder.DataDownload("id1"));
        Console.WriteLine(showDataDownloder.DataDownload("id2"));
        Console.WriteLine(showDataDownloder.DataDownload("id3"));
        Console.WriteLine(showDataDownloder.DataDownload("id5"));
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

   
    public string DataDownload  (string resource)
    {
        Thread.Sleep(1000);

        return $"some data for {resource}";
    }
}
