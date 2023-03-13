namespace ViewModel
{
    #region select-query-view-models
    public class AccountRoot
    {
        public AccountData Data { get; set; }
    }

    public class AccountData
    {
        public AccountList Accounts { get; set; }
    }

    public class AccountList
    {
        public IList<Account> Nodes { get; set; }
    }

    public class Account
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int PostalCode { get; set; }
        public string City { get; set; }
    }
    #endregion

    #region create-query-view-models
    public class CreateAccount
    {
        public Account Account { get; set; }
    }

    public class CreateAccountData
    {
        public CreateAccount CreateAccount { get; set; }
    }

    public class CreateAccountRoot
    {
        public CreateAccountData Data { get; set; }
    }
    #endregion

    #region update-query-view-models
    public class UpdateAccountData
    {
        public UpdateAccount UpdateAccount { get; set; }
    }

    public class UpdateAccountRoot
    {
        public UpdateAccountData Data { get; set; }
    }

    public class UpdateAccount
    {
        public Account Account { get; set; }
    }
    #endregion

    #region delete-query-view-models
    public class DeleteAccountData
    {
        public DeleteAccount DeleteAccount { get; set; }
    }

    public class DeleteAccount
    {
        public Account Account { get; set; }
    }

    public class DeleteAccountRoot
    {
        public DeleteAccountData Data { get; set; }
    }
    #endregion
}