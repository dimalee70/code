using System;
namespace lesson10
{
    class Account
    {
        int _sum;
        public Account(int sum)
        {
            _sum = sum;
        }
        
           // Объявляем делегат
        public delegate void AccountStateHandler(string message);
        // Создаем переменную делегата
        AccountStateHandler _del;
        // public void RegisterHandler(AccountStateHandler del)
        // {
        //     _del = del;
        // }
        public void Withdraw(int sum)
        {
            if (sum <= _sum)
            {
                _sum -= sum;
 
                if (_del != null)
                    _del($"Сумма {sum} снята со счета");
            }
            else
            {
                if (_del != null)
                    _del("Недостаточно денег на счете");
            }
        }
        
        // Регистрируем делегат
        public void RegisterHandler(AccountStateHandler del)
        {
            _del += del; // добавляем делегат
        }
        // Отмена регистрации делегата
        public void UnregisterHandler(AccountStateHandler del)
        {
            _del -= del; // удаляем делегат
        }  
    }
}