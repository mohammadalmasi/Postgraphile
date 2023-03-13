namespace ViewModel
{
    #region select-query-view-models
    public class ContactRoot
    {
        public ContactData Data { get; set; }
    }

    public class ContactData
    {
        public ContactList Contacts { get; set; }
    }

    public class ContactList
    {
        public IList<Contact> Nodes { get; set; }
    }

    public class Contact
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
    #endregion

    #region create-query-view-models
    public class CreateContact
    {
        public Contact Contact { get; set; }
    }

    public class CreateContactData
    {
        public CreateContact CreateContact { get; set; }
    }

    public class CreateContactRoot
    {
        public CreateContactData Data { get; set; }
    }
    #endregion

    #region update-query-view-models
    public class UpdateContactData
    {
        public UpdateContact UpdateContact { get; set; }
    }

    public class UpdateContactRoot
    {
        public UpdateContactData Data { get; set; }
    }

    public class UpdateContact
    {
        public Contact Contact { get; set; }
    }
    #endregion

    #region delete-query-view-models
    public class DeleteContactData
    {
        public DeleteContact DeleteContact { get; set; }
    }

    public class DeleteContact
    {
        public Contact Contact { get; set; }
    }

    public class DeleteContactRoot
    {
        public DeleteContactData Data { get; set; }
    }
    #endregion
}
