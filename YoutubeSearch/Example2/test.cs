using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecureStringTest
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(string[] args)
		{
      		Search("My test query string"); // Type something to search on YouTube.
      		Console.WriteLine("");
      		Console.WriteLine("Press any key to exit...");
      		Console.ReadLine();
		}
    
    	public async void Search(string text)
		{
			VideoSearch result = new VideoSearch();
			int index = 0;
			foreach (VideoInformation information in await result.SearchQueryTaskAsync(text, 1)) // Get one page of the specified searchs for an example.
			{
				string author = information.Author;
				string desc = information.Description;
				if (information.NoAuthor)
					author = "Unknown"); // Type whatever you want.

				if (information.NoDescription)
					desc = "Unknown or Empty"; // Type whatever you want.
				else
				{
					// FIX ME FIX ME
					// Change " characters to \" that comes from descriptions. Do NOT replace directly.
				}
				
				Console.WriteLine("Title: "+information.Title+"\nURL: "+information.Url+"\nDescription: "+desc+"\nDuration: "+information.Duration+"\nThumbnail: "+information.Thumbnail+"\nAuthor: "+author+"\nView Count: "+(information.ViewCount == "" || information.ViewCount == "0" ? "Unknown or none" : viewCountF(information.ViewCount)));
			}
		}

		public static string viewCountF(string viewCount)
		{
			int recount = viewCount.Split('.').Length - 1;
			switch (recount)
			{
				case 1:
					return viewCount + " thousand times.";
				case 2:
					return viewCount + " million times.";
				case 3:
					return viewCount + " billion times.";
				case 4:
					return viewCount + " trillion times.";
				case 5:
					return viewCount + " quadrillion times.";
				case 6:
					return viewCount + " quintillion times.";
				default:
					return viewCount + ".";
			}
		}
	}
}
