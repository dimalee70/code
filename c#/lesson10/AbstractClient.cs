using System;
namespace lesson10{

abstract class BaseClient : IAccount, IClient
{
    protected int _sum;
    public string name;
    public int CurrentSum { get { return _sum; } }

    public string Name{
        get {
            return name;
        }
    } 

    public int age(int age)
    {
        return age;
    }

    public abstract void Put(int sum);
    public abstract void Withdraw(int sum);
}
class AbstractClient : BaseClient
{
    public AbstractClient(string name, int sum)
    {
        name = name;
        _sum = sum;
    }
    public override void Put(int sum)
    {
        _sum += sum;
    }
    public override void Withdraw(int sum)
    {
        if (sum <= _sum)  _sum -= sum;
    }
}
}