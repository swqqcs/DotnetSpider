﻿using DotnetSpider.Core;
using DotnetSpider.Core.Monitor;

namespace DotnetSpider.Sample
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IocContainer.Default.AddSingleton<IMonitor, NLogMonitor>();

			JdSkuSampleSpider spider = new JdSkuSampleSpider();
			spider.Run();
		}
	}
}
