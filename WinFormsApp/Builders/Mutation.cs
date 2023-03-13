namespace WinFormsApp.Builders
{
    internal class Mutation
    {
        public int Id { get; set; }
        public string OperationName { get; set; }
        public string ObjectName { get; set; }
        public IList<string> ReturnFields { get; set; }
        public IDictionary<string, object> Properties { get; set; }
    }

    internal interface IMutationBuilder
    {
        void AddId(int id);
        void AddOperationName(string operationName);
        void AddObjectName(string objectName);
        void AddReturnField(string fieldName);
        void AddProperty(string key, object value);
        string Build(MutationType mutationType);
    }

    internal class MutationBuilder : IMutationBuilder
    {
        private readonly Mutation _mutation;

        public MutationBuilder()
        {
            _mutation = new Mutation
            {
                ReturnFields = new List<string>(),
                Properties = new Dictionary<string, object>(),
            };
        }

        public void AddId(int id)
        {
            _mutation.Id = id;
        }

        public void AddOperationName(string operationName)
        {
            _mutation.OperationName = operationName;
        }

        public void AddObjectName(string objectName)
        {
            _mutation.ObjectName = objectName;
        }

        public void AddReturnField(string fieldName)
        {
            _mutation.ReturnFields.Add(fieldName);
        }

        public void AddProperty(string key, object value)
        {
            _mutation.Properties.Add(key, value);
        }

        public string Build(MutationType mutationType)
        {
            var properties = new List<string>();
            foreach (var kvp in _mutation.Properties)
            {
                var value = kvp.Value;
                if (kvp.Value.GetType() == typeof(string))
                {
                    value = "\"" + value + "\"";
                }
                properties.Add(string.Concat(kvp.Key + ": " + value));
            }

            switch (mutationType)
            {
                case MutationType.Create:

                    return @"mutation{" + _mutation.OperationName +
                        "(input: {" + _mutation.ObjectName + ":{" + string.Join(", ", properties) + "  }}){" +
                        "" + _mutation.ObjectName + "{" + string.Join(", ", _mutation.ReturnFields) + "}}}";

                case MutationType.Update:

                    return @"mutation{" + _mutation.OperationName +
                            "(input:{id:" + _mutation.Id + ", patch:{" + string.Join(", ", properties) + "}}){" + _mutation.ObjectName + "{" + string.Join(", ", _mutation.ReturnFields) + "}}}";

                case MutationType.Delete:

                    return @"mutation{" + _mutation.OperationName + "(input:{id:" + _mutation.Id + "}){" + _mutation.ObjectName + "{" + string.Join(", ", _mutation.ReturnFields) + "}}}";
                default:
                    break;
            }

            return null;
        }
    }

    public enum MutationType
    {
        Create = 0,
        Update = 1,
        Delete = 2,
    }
}
