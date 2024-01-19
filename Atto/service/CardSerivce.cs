using AttoProject.dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttoProject.service
{
    public class CardSerivce
    {
        /*private readonly Managing _managing;
        public CardSerivce(Managing managing)
        {
            _managing = managing;
        }*/

        private Card[] cardList = new Card[100];
        private int cardIndex = 0;
        private int cardId = 1;

        private Terminal[] termialList = new Terminal[100];
        private int termialIndex = 0;








        // Card Block
        public void createCard()
        {
            Console.Write("Enter card balance: ");
            double balance = double.Parse(Console.ReadLine());

            Console.Write("Enter card Exp_Date: ");
            string exp_date = Console.ReadLine();

            Card card = new Card();
            card.Id = cardId++;
            card.Balance += balance;
            card.CreatedDate = DateTime.Now;
            card.Exp_Date = exp_date;
            card.Status = enums.Status.BOLOCK;
            cardList[cardIndex++] = card;
            Console.WriteLine("CARD SUCCESSFULLY CREATED\n");
        }
        public void getcardList()
        {
            Console.WriteLine("-----   CARD LIST -----");
            foreach (var item in cardList)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());

                }
            }
        }
        public void updateCard()
        {
            Console.Write("Enter card Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter card Exp_Date: ");
            string exp_date = Console.ReadLine();


            foreach (var card in cardList)
            {
                if (card != null && card.Id == id && card.Exp_Date.Equals(exp_date))
                {
                    card.Status = enums.Status.ACTIVE;
                    card.Balance += 5000;
                }
            }
            Console.WriteLine("CARD SUCCESSFULLY UPDATE");
        }
        public void changeCardStatus()
        {
            Console.Write("Enter card Id: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in cardList)
            {
                if (item != null && item.Id == id)
                {
                    item.Status = enums.Status.ACTIVE;
                }
            }
            Console.WriteLine("SUCCESSFULLY CARD STATUS CHANGED");

        }
        public void DeleteCard()
        {
            Console.Write("Enter card Id: ");
            int id = int.Parse(Console.ReadLine());
            int deleteIndex = 0;

            for (int i = 0; i < cardList.Length; i++)
            {
                Card card = cardList[i];

                if (card != null && card.Id == id)
                {
                    deleteIndex = i;
                }
            }


            for (int i = deleteIndex; i < cardList.Length - 1; i++)
            {
                cardList[i] = cardList[i + 1];
            }

            cardList[cardList.Length - 1] = null;
            cardIndex--;
            Console.WriteLine("CARD SUCCESSFULLY DELETED");
        }
        public Card getCardById(int id)
        {
            foreach (var card in cardList)
            {
                if (card != null && card.Id == id)
                {
                    return card;
                }
            }
            return null;
        }


        // Terminal Block

        public void createTerminal()
        {
            Console.Write("Enter terminal Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Terminal exist = getTerminalById(id);
            if (exist != null)
            {
                Console.WriteLine("Sorry Termial already exist!!! ");
            }
            Terminal terminal = new Terminal();
            terminal.Id = id;
            terminal.Address = address;
            terminal.Status = enums.Status.BOLOCK;
            terminal.CreatedDate = DateTime.Now;
            termialList[termialIndex++] = terminal;
            Console.WriteLine("TERMINAL SUCCESSFULLY CREATED\n");
        }
        public void updateTerminal()
        {
            Console.Write("Enter Id: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter address: ");
            string address = Console.ReadLine();

            Console.Write("Enter new address: ");
            string updateAddress = Console.ReadLine();

            Terminal exist = getTerminalById(id);
            if (exist != null && exist.Address.Equals(address))
            {
                exist.Address = updateAddress;
                exist.CreatedDate = DateTime.UtcNow;
            }
            else if (exist != null && exist.Address != address)
            {
                Console.WriteLine("ADDRESS ERROR!");
            }
            else
            {
                Console.WriteLine("SUCCESSFULLY TERMINAL UPDATE");
            }

        }
        public void changeTerminalStatus()
        {
            Console.Write("Enter id: ");
            int id = int.Parse(Console.ReadLine());

            foreach (var item in termialList)
            {
                if (item != null && item.Id == id)
                {
                    item.Status = enums.Status.ACTIVE;
                }
            }
            Console.WriteLine("SUCCESSFULLY TERMINAL CHANGED STATUS");


        }
        
        public void terminalList()
        {
            foreach (var item in termialList)
            {
                if (item != null)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }
     
        public void DeleteTerminal()
        {
            Console.Write("Enter termial id: ");
            int id = int.Parse(Console.ReadLine());
            int deleteIndex = 0;

            for (int i = 0; i < termialList.Length; i++)
            {
                Terminal terminal = termialList[i];
                if (terminal != null && terminal.Id == id)
                {
                    deleteIndex = i;
                }
            }

            for (int i = deleteIndex; i < termialList.Length - 1; i++)
            {
                termialList[i] = termialList[i + 1];

            }
            termialList[termialList.Length - 1] = null;
            termialIndex--;

            Console.WriteLine("Terminal successfully deleted");
        }
        public Terminal getTerminalById(int id)
        {
            foreach (var terminal in termialList)
            {
                if (terminal != null && terminal.Id == id)
                {
                    return terminal;
                }
            }
            return null;
        }


        



        // Transaction Block
        public void transactionList()
        {

        }
        public void companyCardBalance()
        {
        }







    }
}
