#nullable disable
using System;
namespace TestNlog.Model
{
	public class LogBase
	{
		public string Level { get; set; }
	
		public string Message { get; set; }

		public DateTime Date { get; set; }

		public LogBase()
		{
		
		}
	}
}

