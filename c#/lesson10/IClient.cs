
interface IClient
{
    string Name { get;}
    int age (int age);
}
public class Client2 : IClient
{
    private string name;
    public string Name 
    {
        get
        {
            return name;
        }
    }
    public void say(){
        System.Console.WriteLine("fvdf");
    }

    public int age(int age)
    {
        return age;
    }
}







interface IAccount
{
    int CurrentSum { get; }
    void Put(int sum);
    void Withdraw(int sum);
}