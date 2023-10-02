using System;

namespace ProgrammingTechLesson5_1_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Deposit deposit = new Deposit("Петров Иван Васильевич", "2023,05,06", 7000);
            deposit.ShowInfo();
            deposit.TimeFlow();
            deposit.GetMoney();
        }
    }
}