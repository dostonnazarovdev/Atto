using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttoProject.dto
{
    public class Transaction
    {
        public int Id { get; set; }
        public double Fair { get; set; }
        public Card Card { get; set; }
        public Terminal Terminal { get; set; }
        public DateTime CreatedDate { get; set; }





        public Card getCard()
        {
            return null;
        }

        public Terminal getTerminal()
        {
            return null;
        }

        public override string ToString()
        {
            return $"id: {Id} Fair: {Fair} card: {Card}, Terminal: {Terminal}, CreadedDate: {CreatedDate}";
        }
    }
}
