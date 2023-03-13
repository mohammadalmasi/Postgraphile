using GraphQL;
using GraphQL.Client.Http;
using GraphQL.Client.Serializer.Newtonsoft;
using ViewModel;
using WinFormsApp.Builders;

namespace WinFormsApp
{
    public partial class Demo : Form
    {
        public string _endPoint = "http://localhost:5261/api";
        AccountData AccountList { get; set; }
        ContactData ContactList { get; set; }

        public Demo()
        {
            InitializeComponent();
        }

        private async void Demo_Load(object sender, EventArgs e)
        {
            await GetAndFillData();
        }

        private void cmbAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstContactOfAccount.Items.Clear();
            if (cmbAccount.SelectedValue.GetType() == typeof(Account))
            {
                var account = cmbAccount.SelectedValue as Account;
                txtAccountId.Text = account?.Id.ToString();
                txtAccountName.Text = account?.Name;
                txtAccountStreet.Text = account?.Street;
                txtAccountPostalCode.Text = account?.PostalCode.ToString();
                txtAccountCity.Text = account?.City;

                FillLstContactOfAccount(account?.Id);
            }
            else
            {
                var id = (int)cmbAccount.SelectedValue;
                var result = AccountList.Accounts.Nodes.Where(x => x.Id == id).FirstOrDefault();
                txtAccountId.Text = cmbAccount.SelectedValue.ToString();
                txtAccountName.Text = result?.Name;
                txtAccountStreet.Text = result?.Street;
                txtAccountPostalCode.Text = result?.PostalCode.ToString();
                txtAccountCity.Text = result?.City;

                FillLstContactOfAccount(id);
            }
        }

        private void lstContactOfAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstContactOfAccount.GetItemText(lstContactOfAccount.SelectedItem);
            int id = Convert.ToInt32(text.Substring(0, text.IndexOf(":", StringComparison.Ordinal)));
            var contact = ContactList.Contacts.Nodes.Where(x => x.Id == id).FirstOrDefault();

            textContactId.Text = id.ToString();
            txtFirstname.Text = contact?.Firstname;
            txtLastname.Text = contact?.Lastname;
        }

        private async void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var mutationBuilder = new MutationBuilder();
            mutationBuilder.AddOperationName("createAccount");
            mutationBuilder.AddObjectName("account");

            mutationBuilder.AddProperty("name", txtAccountName.Text);
            mutationBuilder.AddProperty("street", txtAccountStreet.Text);
            mutationBuilder.AddProperty("postalcode", Convert.ToInt32(txtAccountPostalCode.Text));
            mutationBuilder.AddProperty("city", txtAccountCity.Text);

            mutationBuilder.AddReturnField("id");
            mutationBuilder.AddReturnField("name");
            mutationBuilder.AddReturnField("street");
            mutationBuilder.AddReturnField("postalcode");
            mutationBuilder.AddReturnField("city");

            string query = mutationBuilder.Build(MutationType.Create);

            var response = await SendQueryAsync<CreateAccountData>(_endPoint, "account", "create", query);
            await GetAndFillData();
            MessageBox.Show("Your AccountId is : " + response.Data.CreateAccount.Account.Id + " ");
        }

        private async void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            var mutationBuilder = new MutationBuilder();
            mutationBuilder.AddOperationName("updateAccount");
            mutationBuilder.AddObjectName("account");
            mutationBuilder.AddId(Convert.ToInt32(txtAccountId.Text));

            mutationBuilder.AddProperty("name", txtAccountName.Text);
            mutationBuilder.AddProperty("street", txtAccountStreet.Text);
            mutationBuilder.AddProperty("postalcode", Convert.ToInt32(txtAccountPostalCode.Text));
            mutationBuilder.AddProperty("city", txtAccountCity.Text);

            mutationBuilder.AddReturnField("id");
            mutationBuilder.AddReturnField("name");
            mutationBuilder.AddReturnField("street");
            mutationBuilder.AddReturnField("postalcode");
            mutationBuilder.AddReturnField("city");

            string query = mutationBuilder.Build(MutationType.Update);

            var response = await SendQueryAsync<UpdateAccountData>(_endPoint, "account", "update", query);
            await GetAndFillData();
            MessageBox.Show("The update was successfully");
        }

        private async void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var mutationBuilder = new MutationBuilder();
            mutationBuilder.AddOperationName("deleteAccount");
            mutationBuilder.AddObjectName("account");
            mutationBuilder.AddId(Convert.ToInt32(txtAccountId.Text));

            mutationBuilder.AddReturnField("id");
            mutationBuilder.AddReturnField("name");
            mutationBuilder.AddReturnField("street");
            mutationBuilder.AddReturnField("postalcode");
            mutationBuilder.AddReturnField("city");

            string query = mutationBuilder.Build(MutationType.Delete);

            var response = await SendQueryAsync<DeleteAccountData>(_endPoint, "account", "delete", query);
            await GetAndFillData();
        }

        private async void btnCreateContact_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textContactId.Text))
                textContactId.Text = "0";

            var mutationBuilder = new MutationBuilder();
            mutationBuilder.AddOperationName("createContact");
            mutationBuilder.AddObjectName("contact");

            mutationBuilder.AddProperty("accountid", Convert.ToInt32(txtAccountId.Text));
            mutationBuilder.AddProperty("firstname", txtFirstname.Text);
            mutationBuilder.AddProperty("lastname", txtLastname.Text);

            mutationBuilder.AddReturnField("id");
            mutationBuilder.AddReturnField("accountid");
            mutationBuilder.AddReturnField("firstname");
            mutationBuilder.AddReturnField("lastname");

            string query = mutationBuilder.Build(MutationType.Create);

            var response = await SendQueryAsync<CreateContactData>(_endPoint, "contact", "create", query);
            await GetAndFillData();
            MessageBox.Show("Your AccountId is : " + response.Data.CreateContact.Contact.Id + " ");
        }

        private async void btnUpdateContact_Click(object sender, EventArgs e)
        {
            var mutationBuilder = new MutationBuilder();
            mutationBuilder.AddOperationName("updateContact");
            mutationBuilder.AddObjectName("contact");
            mutationBuilder.AddId(Convert.ToInt32(textContactId.Text));

            mutationBuilder.AddProperty("accountid", Convert.ToInt32(txtAccountId.Text));
            mutationBuilder.AddProperty("firstname", txtFirstname.Text);
            mutationBuilder.AddProperty("lastname", txtLastname.Text);

            mutationBuilder.AddReturnField("id");
            mutationBuilder.AddReturnField("accountid");
            mutationBuilder.AddReturnField("firstname");
            mutationBuilder.AddReturnField("lastname");

            string query = mutationBuilder.Build(MutationType.Update);

            var response = await SendQueryAsync<UpdateContactData>(_endPoint, "contact", "update", query);
            await GetAndFillData();
            MessageBox.Show("The update was successfully");
        }

        private async void btnDeleteContact_Click(object sender, EventArgs e)
        {
            var mutationBuilder = new MutationBuilder();
            mutationBuilder.AddOperationName("deleteContact");
            mutationBuilder.AddObjectName("contact");
            mutationBuilder.AddId(Convert.ToInt32(textContactId.Text));

            mutationBuilder.AddReturnField("id");
            mutationBuilder.AddReturnField("accountid");
            mutationBuilder.AddReturnField("firstname");
            mutationBuilder.AddReturnField("lastname");

            string query = mutationBuilder.Build(MutationType.Delete);

            var response = await SendQueryAsync<DeleteContactData>(_endPoint, "contact", "delete", query);
            await GetAndFillData();
            MessageBox.Show("The Account was deleted");
        }

        public async Task<GraphQLResponse<T>> SendQueryAsync<T>(string endPoint,
            string controllerName, string actionName, string query)
        {
            var httpClient = new HttpClient();
            var request = new GraphQLRequest { Query = query, };
            string url = string.Concat(endPoint, "/", controllerName, "/", actionName);
            var options = new GraphQLHttpClientOptions { EndPoint = new Uri(url) };
            var client = new GraphQLHttpClient(options, new NewtonsoftJsonSerializer(), httpClient);
            var response = await client.SendQueryAsync<T>(request).ConfigureAwait(false);
            return response;
        }

        private async Task GetAndFillData()
        {
            //get Accounts
            var accountQueryBuilder = new QueryBuilder();
            accountQueryBuilder.AddOperationName("accounts");
            accountQueryBuilder.AddReturnField("id");
            accountQueryBuilder.AddReturnField("name");
            accountQueryBuilder.AddReturnField("street");
            accountQueryBuilder.AddReturnField("postalcode");
            accountQueryBuilder.AddReturnField("city");
            string accountQuery = accountQueryBuilder.Build();

            var accountResponse = await SendQueryAsync<AccountData>(_endPoint, "account", "get-all", accountQuery);
            AccountList = accountResponse.Data;


            //get Contacts
            var contactQueryBuilder = new QueryBuilder();
            contactQueryBuilder.AddOperationName("contacts");
            contactQueryBuilder.AddReturnField("id");
            contactQueryBuilder.AddReturnField("accountid");
            contactQueryBuilder.AddReturnField("firstname");
            contactQueryBuilder.AddReturnField("lastname");
            string contactQuery = contactQueryBuilder.Build();

            var contactResponse = await SendQueryAsync<ContactData>(_endPoint, "contact", "get-all", contactQuery);
            ContactList = contactResponse.Data;

            cmbAccount.DataSource = AccountList.Accounts.Nodes;
            cmbAccount.DisplayMember = "Id";
            cmbAccount.ValueMember = "Id";
        }

        private void FillLstContactOfAccount(int? accountId)
        {
            IEnumerable<Contact>? contacts = ContactList.Contacts.Nodes.Where(x => x.AccountId == accountId);
            if (contacts.Count() != 0)
            {
                foreach (var contact in contacts)
                {
                    lstContactOfAccount.Items.Add(string.Concat(contact.Id, ": ", contact.Firstname, "-", contact.Lastname));
                    lstContactOfAccount.ValueMember = "Id";
                    lstContactOfAccount.DisplayMember = "Firstname";
                }
            }
        }
    }
}