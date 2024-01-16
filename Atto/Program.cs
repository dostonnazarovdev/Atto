using AttoProject;

namespace Atto
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Managing managing = new Managing();
            managing.start();






            // Managing section
            /* Managing manging = new Managing();
             manging.setFaire(1400);
             manging.init();*/


            // AddCard section
            /*    Card card1 = manging.addCard(1, 7400);
                Card card2 = manging.addCard(2, 5800);
                Card card3 = manging.addCard(3, 8400);*/



            // GetCardList section
            /* Card[] cardList = manging.getCardList();
           foreach (var item in cardList)
           {
               if (item != null)
               {
                   Console.WriteLine(item.ToString());
               }
           }
           Console.ReadKey();*/


            // Recharge section
            /*  Card rechargeCard = manging.recharge(3, 1000);
              Console.WriteLine(rechargeCard.ToString());*/


            // Add Terminal section
            /* Terminal terminal1 = manging.addTerminal(22, "chilonzor");
             Terminal terminal2 = manging.addTerminal(12, "Novza");
             Terminal terminal3 = manging.addTerminal(43, "Yunsobod");*/


            // TerminalList section

            /* Terminal[] terminals = manging.terminalList();
             foreach (var item in terminals)
             {    
                 if (item != null)
                 {
                     Console.WriteLine(item.ToString());
                 }
             }*/


            // MakeTransaction
            /*  Transaction transaction1 = manging.makeTransaction(card1.Id, terminal1.Id);
              Transaction transaction2 = manging.makeTransaction(card2.Id, terminal2.Id);
              Transaction transaction3 = manging.makeTransaction(card3.Id, terminal3.Id);*/


            //transactionListByTerminal
            /* Transaction[] transactions = manging.transactionListByTerminal(terminal1.Id);
             foreach (var item in transactions)
             {
                 if (item != null)
                 {
                     Console.WriteLine(item.ToString());
                 }
             }*/


            // transactionListByCard 
            /*      Transaction[] transactions = manging.transactionListByCard(card1.Id);
              foreach (var item in transactions)
              {
                  if (item != null)
                  {
                      Console.WriteLine(item.ToString());
                  }
              }*/


            //getTransactionsByDate
            /*Transaction[] transactions= manging.getTransactionsByDate(DateTime.Now);

            try
            {
            foreach (var item in transactions)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            }
            catch (Exception e)
            {
                throw new Exception("null kelayabdi");
            }*/
            //??????


            //terminalList_orderedByTransactionsCount_aDay
            // Terminal[] terminal = manging.terminalList_orderedByTransactionsCount_aDay(DateTime.Now);


        }
    }
}