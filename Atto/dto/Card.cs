using AttoProject.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttoProject.dto
{
    public class Card
    {

        public int Id { get; set; }
        public double Balance { get; set; }
        public string Exp_Date { get; set; }
        public DateTime CreatedDate { get; set; }
        public Status Status { get; set; }



        // bugungi transaction lar ro'yxati
        public List<Transaction> todayTransactionList()
        {
            return null;
        }

        // xozirgi balansdagi pul
        public double currentAmount()
        {
            return 0.0;
        }

        // berilgan kun bo'yicha ishlatilgan pul miqdori yyyy.MM.dd
        public double getTransactionAmountByDay(String date)
        {
            return 0.0;
        }

        internal void subtractBalance(double amount)
        {
          Balance -= amount;
        }

        public void addBalance(double fair)
        {
           Balance += fair;
        }

        public override string ToString()
        {
            return $"id = {Id}, balance = {Balance}, {Exp_Date}, {CreatedDate}, {Status}";
        }
    }
}

