using AttoProject.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace AttoProject.dto
{
    public class Terminal
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }









        // yyyy.MM.dd
        public double getAmountByDay(String date)
        {
            return 0.0;
        }

        public List<Transaction> transactionList()
        {
            return null;
        }

        public override string ToString()
        {
            return $"id: {Id}, address: {Address}";
        }

    }
}
