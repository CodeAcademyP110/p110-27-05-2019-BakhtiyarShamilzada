namespace _27_May_2019
{
    public class Phone
    {
        private int indexContact = 0;

        private readonly Contact[] contacts;

        #region Indexer Name Number
        public string this[string name]
        {
            get
            {
                foreach (Contact contact in contacts)
                {
                    if (contact != null && name == contact.Name)
                    {
                        return contact.Number;
                    }
                }
                return "Bu adla contact yoxdur";
            }
            set
            {
                contacts[indexContact++] = new Contact { Name = name, Number = value };
            }
        }
        #endregion

        #region Indexer Index
        public Contact this[int i]
        {
            get
            {
                return contacts[i];
            }
        }
        #endregion

        public Phone()
        {
            contacts = new Contact[100];
        }

        public void AddContact(Contact contact)
        {
            contacts[indexContact++] = contact;
        }
        public override string ToString()
        {
            foreach (Contact contact in contacts)
            {
                if(contact !=null)
                {
                    System.Console.WriteLine("Name:" + contact.Name + "\n"
                    + "Number:" + contact.Number);
                }
            }
            return "";
        }
    }
}
