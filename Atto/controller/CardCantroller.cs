
using AttoProject.dto;
using AttoProject.service;

namespace AttoProject.controller
{
    public class CardCantroller
    {
        private readonly Managing _managing;
        public CardCantroller(Managing managing)
        {
            _managing = managing;
        }

        CardSerivce cardSerivce = new CardSerivce();
        UserService userService = new UserService();
        




        // User Menu
        public void userMenu()
        {
            Console.WriteLine("---- User Menu ----");
            Console.WriteLine("1.Add Card");
            Console.WriteLine("2.CardList");
            Console.WriteLine("3.Card Change status");
            Console.WriteLine("4.Delete Card");
            Console.WriteLine("5.ReFill");
            Console.WriteLine("6.Transaction");
            Console.WriteLine("7.MakePayment");
            Console.WriteLine("0.Exist");
            int num = getAction();
            switch (num)
            {
                case 1:
                    userService.addCard();
                    break;
                case 2:
                    userService.cardList();
                    break;
                case 3:
                    userService.cardChangeStatus();
                    break;
                case 4:
                    userService.DeleteCard();
                    break;
                case 5:
                    userService.ReFill();
                    break;
                case 6:
                    userService.Transaction();
                    break;
                case 7:
                    userService.MakePayment();
                    break;
                case 0:
					_managing.start();
                    break;
                default:
                    Console.WriteLine("wrong option!");
                    break;
            }
        }


        // Admin Section
        public void adminMenu()
        {
            Console.WriteLine("\n----- ADMIN MENU -----\n");
            Console.WriteLine("1.Card Section");
            Console.WriteLine("2.Terminal Section");
            Console.WriteLine("3.Profile Section");
            Console.WriteLine("4.Transaction");
            Console.WriteLine("5.Statistic");
            Console.WriteLine("0.Go back");
            int num = getAction();
            switch (num)
            {
                case 1:
                   CardSection();
                    break;
                case 2:
                    TerminalSection();
                    break;
                case 3:
                   ProfleSection();
                    break;
                case 4:
                   Transaction();
                    break;
                case 5:
                  Statistic();
                    break;
                case 0:
					_managing.start();
                    break;
                default:
                    Console.WriteLine("wrong option!");
                    break;
            }
        }
        public void CardSection()
        {  
            while (true)
            {
                Console.WriteLine("\n------    CARD MENU   ------\n");
                Console.WriteLine("1.Create Card");
                Console.WriteLine("2.Card List");
                Console.WriteLine("3.Update Card");
                Console.WriteLine("4.Change Status");
                Console.WriteLine("5.Delete Card");
                Console.WriteLine("0.Go back");
                int card = getAction();
                switch (card)
                {
                    case 1:
                        cardSerivce.createCard();
                        break;
                    case 2:
                        cardSerivce.getcardList();
                        break;
                    case 3:
                        cardSerivce.updateCard();
                        break;
                    case 4:
                        cardSerivce.changeCardStatus();
                        break;
                    case 5:
                        cardSerivce.DeleteCard();
                        break;
                    case 0:
                        adminMenu();
                        break;
                    default:
                        Console.WriteLine("wrong option!");
                        break;
                }
            }
           
        }
        public void TerminalSection()
        {
            bool s = true;
            while(s)
            {
                Console.WriteLine("\n---------   TERMINAL MENU   ---------\n");
                Console.WriteLine("1.Create Terminal");
                Console.WriteLine("2.Update Terminal");
                Console.WriteLine("3.Change Status");
                Console.WriteLine("4.Terminal List");
                Console.WriteLine("5.Delete Terminal");
                Console.WriteLine("0.Go back");

                int terminal = getAction();
                switch (terminal)
                {
                    case 1:
                        cardSerivce.createTerminal();
                        break;
                    case 2:
                        cardSerivce.updateTerminal();
                        break;
                    case 3:
                        cardSerivce.changeTerminalStatus();
                        break;
                    case 4:
                        cardSerivce.terminalList();
                        break;
                    case 5:
                        cardSerivce.DeleteTerminal();
                        break;
                    case 0:
                        adminMenu();
                        break;
                    default:
                        Console.WriteLine("wrong option!");
                        break;
                }
            }
            
        }
        public void ProfleSection()
        {
            while (true)
            {
            Console.WriteLine("\n-------   PROFILE MENU  ------\n");
            Console.WriteLine("1.Profile List");
            Console.WriteLine("2.Change status ");
            Console.WriteLine("0.Go back");
            int terminal = getAction();
            switch (terminal)
            {
                case 1:
                    proList();
                    break;
                case 2:
                    changeStatus();
                    break;
                case 0:
                    adminMenu();
                    break;
                default:
                    Console.WriteLine("wrong option!");
                    break;
            }
            }
        }


        public void Transaction()
        {
            Console.WriteLine("1.Transaction List");
            Console.WriteLine("2.Company card Balance");
            Console.WriteLine("0.Go back");

            int terminal = getAction();
            switch (terminal)
            {
                case 1:
                    cardSerivce.transactionList();
                    break;
                case 2:
                    cardSerivce.companyCardBalance();
                    break;
                case 0:
                    adminMenu();
                    break;
                default:
                    Console.WriteLine("wrong option!");
                    break;
            }
        }
        public void Statistic()
        {
            Console.WriteLine("hali statistika qilinmadi");
        }

        //getAction
        private static int getAction()
        {
            Console.Write("Enter Action: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        //profileList
        public void proList()
        {
            Profile[] list = _managing.getProfileList();
            Console.WriteLine("------   PROFILE LIST  -------");
            foreach (var item in list)
            {
                if (item != null)
                {
                    Console.WriteLine($"Id: {item.Id}, name: {item.Name}, surname: {item.Surname}, Phone: {item.Phone}, password: {item.Password}, createdDate: {item.CreatedDate}, status: {item.Status}, role: {item.Role}");
                }
            }
        }
      
        //change profile status
        private void changeStatus()
        {
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();

            Profile[] list =_managing.getProfileList();
            foreach (var item in list)
            {
                 if(item!=null && item.Phone.Equals(phone))
                {
                    item.Status = "BLOCK";
                    item.Role = "USER";
                }
            }
            Console.WriteLine("Profile  statsu successfully changed");
        }
    }
}
