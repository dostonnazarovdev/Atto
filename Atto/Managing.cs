using AttoProject.controller;
using AttoProject.dto;
using AttoProject.enums;
using AttoProject.service;

namespace AttoProject
{
    public class Managing
    {
        private readonly CardCantroller _cardController;
     

        public Managing()
        {
			_cardController = new CardCantroller(this);
           
		}



		private static int companyCardId = 444;
        private Double fair;
        private int generalId = 1;

        private static Profile[] profileList = new Profile[100];
        private static int profileIndex = 0;
        private static int profileId = 1;

        private Card[] addCardList = new Card[100];
        private int addCardIndex = 0;


        private Card[] cardList = new Card[100];
        private int cardIndex = 0;

        

        private Transaction[] transactionList = new Transaction[100];
        private int transactionIndex = 0;







        // show menu
        public  void start()
        {
            bool isTrue = true;
            while (isTrue)
            {
                Console.WriteLine("--------- Atto Menu --------");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Registor");
                Console.WriteLine("0.Exist");
                int num = getAction();
                switch (num)
                {
                    case 1:
                        Login();
                        break;
                    case 2:
                        Register();
                        break;
                    case 0:
                        Console.WriteLine("System end!");
                        return;
                    default:
                        Console.WriteLine("wrong option");
                        break;
                }
            }
        }


        // Register section
        public  Profile Register()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();
            Console.Write("Enter status: ");
            string status = Console.ReadLine();
            Console.Write("Enter role: ");
            string role = Console.ReadLine();


            Profile profile = new Profile();
            profile.Id = profileId++;
            profile.Name = name;
            profile.Surname = surname;
            profile.Phone = phone;
            profile.Password = password;
            profile.Status = status;
            profile.Role = role;
            profileList[profileIndex++] = profile; ;
            return profile;
        }


        // Login section
        public  void Login()
        {
            Console.Write("Enter phone: ");
            string phone = Console.ReadLine();

            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            Profile exist = getProfileByIdAndName(phone, password);
           


            if (exist != null && exist.Phone.Equals(phone) && exist.Password.Equals(password) &&
                exist.Status.Equals("ACTIVE") && exist.Role.Equals("USER"))
            {
				_cardController.userMenu();
            }
            else if (exist != null && exist.Phone.Equals(phone) && exist.Password.Equals(password) &&
              exist.Status.Equals("ACTIVE") && exist.Role.Equals("ADMIN"))
            {
				_cardController.adminMenu();
            }
            else
            {
                Console.WriteLine("Passord or phone 0R STATUS OR ROLE is errror!");
            }
        }

       

        // / GetProfileList
        public  Profile[] getProfileList()
        {
            return profileList;
        }


        //getProfileByIdandName
        public  Profile getProfileByIdAndName(string phone, string pass)
        {
            foreach (var item in profileList)
            {
                if (item != null && item.Phone == phone && item.Password == pass)
                {
                    return item;
                }
            }

            return null;
        }



        //getAction
        private  int getAction()
        {
            Console.Write("Enter Action: ");
            int num = int.Parse(Console.ReadLine());
            return num;
        }






















        // yo'l xaqqini o'rnatish (14,000)
        public void setFaire(double fair)
        {
            this.fair = fair;
        }


        // Create Card
        public Card createdCard(int id, double balance)
        {
            Card exist = getCardById(id);
            if (exist != null)
            {
                Console.WriteLine("Sorry Card already exist!!! ");
                return null;

            }
            Card card = new Card();
            card.Id = id;
            card.Balance = balance;
            cardList[cardIndex++] = card;
            return card;
        }


        // get card by id
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


        // cartaga pul tashlash uchun ishlatiladi.
        public Card recharge(int id, double balance)
        {
            Card card = getCardById(id);

            if (card == null)
            {
                Console.WriteLine("Sorry Card does not exist!!!");
                return null;
            }
            Card cardRecharge = new Card();
            card.Id = id;
            card.Balance += balance;
            return card;
        }


        // get card list
        public Card[] getCardList()
        {
            return cardList;
        }


       


      



        //makeTransaction
    /*    public Transaction makeTransaction(int cardId, int terminalId)
        {
            // 1. null  agar terminal topilmasa
            // 2. null agar  carta topilmasa
            // 3. null agar cartada yetarli pul bo'lmasa
            // 4. null agar shu 1 munit ichida  terminal va carta dan qayta foydalanilsa
            // 5.  agar hammasi to'g'ri bo'lsa  Transaction objecti

            Transaction transaction = new Transaction();
          Terminal terminal = getTerminalById(terminalId);
            Card card = getCardById(cardId);

            if (terminal == null && card == null && card.Balance < 1399)
            {
                return null;
            }
            transaction.Id = generalId++;
            transaction.Terminal = terminal;
            transaction.Card = card;
            transaction.CreatedDate = DateTime.Now;
            transaction.Fair = fair;
            card.subtractBalance(fair);

            Card companyCard = getCardById(companyCardId);
            companyCard.addBalance(fair);

            transactionList[transactionIndex++] = transaction;
            return transaction;
        }
*/

        // Transaction getById
        public Transaction getById(int id)
        {
            foreach (var transaction in transactionList)
            {
                if (transaction != null && transaction.Id == id)
                {
                    return transaction;
                }
            }
            return null;
        }


        //  terminal id bo'yicha barcha  transaction lar
        public Transaction[] transactionListByTerminal(int terminalId)
        {
            foreach (var transaction in transactionList)
            {
                if (transaction != null && transaction.Terminal.Id == terminalId)
                {
                    return transactionList;
                }
            }
            return null;
        }


        //  carta id si  bo'yicha barcha  transaction lar
        public Transaction[] transactionListByCard(int cardId)
        {
            foreach (var transaction in transactionList)
            {
                if (transaction != null && transaction.Card.Id == cardId)
                {
                    return transactionList;
                }
            }


            return null;
        }


        // kun bo'yicha barcha transaction lar (yyyy.MM.dd    keladigan  kun formati)
        public Transaction[] getTransactionsByDate(DateTime createdDate)
        {
            foreach (var transaction in transactionList)
            {
                if (transaction != null && transaction.CreatedDate == createdDate)
                {
                    return transactionList;
                }
            }
            return null;
        }


        //  berilgan kunda  transaction lar soni bo'yicha tartiblangan terminallar yo'yxatini return qiling.
        public Terminal[] terminalList_orderedByTransactionsCount_aDay(DateTime createdDate)
        {


            return null;
        }


        // umumiy yo'l kira xaqqini olish
        public double getTotalFaire()
        {
            return fair;
        }


        public void init()
        {
            createdCard(companyCardId, 0);
        }

        
    }
}
