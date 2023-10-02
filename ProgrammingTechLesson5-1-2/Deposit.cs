using System;

namespace ProgrammingTechLesson5_1_2
{
    public class Deposit : IShowInfoAboutDeposit, IGetMoneyFromDeposit
    {
        private static string _bankName;
        private static decimal _rate;
        private static DateTime _timeOfDeposit;
        public string FullNameOfDepositHolder;
        public DateTime OpenDate;
        public decimal Summ;

        static Deposit()
        {
            _bankName = "Bank of Russia";
            _rate = 5;
            _timeOfDeposit = DateTime.Parse("05.05.2030");
        }

        public Deposit(string fullNameOfDepositHolder, string openDate, decimal summ)
        {
            FullNameOfDepositHolder = fullNameOfDepositHolder;
            OpenDate = DateTime.Parse(openDate);
            Summ = summ;
        }

        public void ShowInfo()
        {
            Console.WriteLine("Информация о вкладе");
            Console.WriteLine($"{_bankName}");
            Console.WriteLine($"Ставка в год {_rate}%");
            Console.WriteLine($"ФИО вкладчика {FullNameOfDepositHolder}");
            Console.WriteLine($"Дата открытия вклада {OpenDate}");
            Console.WriteLine($"Дата закрытия вклада {_timeOfDeposit}");
            Console.WriteLine($"Сумма на счету {Summ}");
        }

        public void GetMoney()
        {
            Console.WriteLine("пробуем вывести деньги со счёта");
            if (DateTime.Now >= _timeOfDeposit)
            {
                Console.WriteLine($"Выводим деньги в размере {Summ}");
                Summ = 0;
            }
            else
            {
                Console.WriteLine($"Время снятия ещё не пришло! Ждите до {_timeOfDeposit}");
            }
        }

        //Вычисляем количество прошедших лет с открытия вклада
        public void TimeFlow()
        {
            //вытаскиваем год из даты открытия
            string open = OpenDate.ToString();
            open.ToCharArray();
            string openYear = "";
            int startYear = 0;
            for (int i = 6; i < 10; i++)
            {
                openYear += open[i];
            }

            //получили год открытия
            startYear = int.Parse(openYear);

            //получаем год закрытия
            string close = _timeOfDeposit.ToString();
            close.ToCharArray();
            string closeYear = "";
            int endYear = 0;
            for (int i = 6; i < 10; i++)
            {
                closeYear += close[i];
            }

            endYear = int.Parse(closeYear);
            //вычисляем количество лет
            int result = endYear - startYear;
            //расчитываем сумму выплат
            CalculationOfSum(result);
        }

        //Расчёт суммы с течением времени
        public void CalculationOfSum(int years)
        {
            decimal sumAtYear = 0;
            for (int i = 0; i < years; i++)
            {
                sumAtYear = (Summ * _rate) / 100;
                Summ += sumAtYear;
            }
        }
    }
}