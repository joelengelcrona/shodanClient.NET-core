using System.Threading.Tasks;

namespace Shodan
{
	interface IShodanClient
	{
		// Shodan Search Methods
        Task<object> searchHost(string ip);
		Task<object> count(string query, string facets);
		Task<object> search(string query, string facets);
		Task<object> listCrawledPorts();
        Task<object> listFacets();
        Task<object> listFilters();
        Task<object> showTokens(string query);

		// Shodan On-Demand Scanning
        Task<object> listProtocols();
        Task<object> scanNetwork();
        Task<object> scanPortOnWeb();
        Task<object> checkProgress(string id);

		// Shodan Network Alerts


	}
}
