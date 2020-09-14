using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace vcm
{
    class vcm
    {
        protected List<Account> list = new List<Account>();


        public vcm()
        {
            list.Add(new Account("Ilia", 1111, 10000));
            list.Add(new Account("Roma", 2222, 9000));
            list.Add(new Account("Geoff", 3333, 8000));
        }

        public void showAccounts()
        {
            int i = 0;
            Console.Clear();
            Console.WriteLine("Список аккаунтов");
            foreach (Account l in list)
            {
                Console.WriteLine(i + ". "+l.name);
                i++;
            }
        }

        public void showAccount(int id)
        {
            Console.Clear();
            Console.WriteLine("Информация об аккаунте");
            Account account = list.ElementAt(id);
            Console.WriteLine("Имя: " + account.name + "\nДеньги: " + account.money);
        }

        public bool checkNameAndPin(int id, int pin)
        {
            int i = 0;
            foreach (Account l in list)
            {
                if (i == id && l.pin == pin)
                {
                    return true;
                }
                i++;
            }
            return false;
        }

        public void AddMoney(int id, int money)
        {
            Account account = list.ElementAt(id);
            account.money = account.money + money;
            Console.Clear();
            Console.WriteLine("Имя: " + account.name + "\nДеньги: " + account.money + "(+" + money + ")");
        }

        public void GetMoney(int id, int money)
        {
            Account account = list.ElementAt(id);
            account.money = account.money - money;
            Console.Clear();
            Console.WriteLine("Имя: " + account.name + "\nДеньги: " + account.money + "(-" + money + ")");

        }
    }
}
