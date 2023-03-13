using GraphQL;

namespace WinFormsApp
{
    /// <summary>
    /// Send request to graphQL api
    /// </summary>
    internal interface IApplicationService
    {
        Task<GraphQLResponse<T>> SendQueryAsync<T>(string endPoint, string controllerName, string actionName, string query);
    }
}
