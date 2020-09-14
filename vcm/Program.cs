using System;

namespace vcm
{
    class Program
    {
        
        static void Main(string[] args)
        {
            vcm vcm = new vcm();
            int exit = 1, exitAccount = 1, choice = 1, pin, id;
            while (exit != 0) {
                Console.WriteLine("1 - Показать список аккаунтов");
                Console.WriteLine("2 - Войти");
                Console.WriteLine("0 - Выйти из программы");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 0)
                {
                    exit = 0;
                }
                else if (choice == 1)
                {
                    vcm.showAccounts();
                }
                else if (choice == 2)
                {
                    int choiceAccount = 1, money = 0;

                    Console.WriteLine("Введите id: ");
                    id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите пин: ");
                    pin = Convert.ToInt32(Console.ReadLine());

                    if (vcm.checkNameAndPin(id, pin) == true)
                    {
                        while (exitAccount != 0)
                        {
                            Console.WriteLine("1 - Информация об аккаунте");
                            Console.WriteLine("2 - Положить деньги на счёт");
                            Console.WriteLine("3 - Снять деньги");
                            Console.WriteLine("0 - Завершить сессию");
                            choiceAccount = Convert.ToInt32(Console.ReadLine());
                            if (choiceAccount == 0)
                            {
                                exitAccount = 0;
                            }
                            if (choiceAccount == 1)
                            {
                                vcm.showAccount(id);
                            }
                            else if (choiceAccount == 2)
                            {
                                Console.Write("Сколько положить: ");
                                money = Convert.ToInt32(Console.ReadLine());
                                vcm.AddMoney(id, money);
                            }
                            else if (choiceAccount == 3)
                            {
                                Console.Write("Сколько снять: ");
                                money = Convert.ToInt32(Console.ReadLine());
                                vcm.GetMoney(id, money);
                            }
                        }
                    }
                }
            }
        }
    }
}
