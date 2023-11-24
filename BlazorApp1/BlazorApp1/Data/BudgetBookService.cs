using BlazerApp1.Data;
using System.Security.Cryptography.X509Certificates;

namespace BlazorApp1.Data
{
	public class BudgetBookService
	{
		private static List<Entry> mockDB = new List<Entry>()
		{
			
		};
		public async Task<bool> AddEntry(Entry newEntry)
		{
			mockDB.Add(newEntry);
			return true;
		}
		public async Task<List<Entry>> GetAllEntries ()
		{
			return mockDB;
		}
	}
}
