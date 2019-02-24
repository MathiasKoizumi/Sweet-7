using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Mood
	{
		private Color currentMood;

		public Color getMood()
		{
			return currentMood;
		}

		public Color returnMood()
		{
			return currentMood;
		}

		public Juklas affectMood(int damn, Juklas food)
		{
			Børnetid børnetid = new Bolledej(400f, "Tonga Wonga").tumbeDej();
			Børnetid item = børnetid.jongaWonga(400, "Tis mig i øret");
			Børnetid item2 = new Lingo(400, børnetid, 4000).jonnasBørnehans(400);
			List<Børnetid> list = new List<Børnetid>();
			list.Add(børnetid);
			list.Add(item);
			list.Add(item2);
			currentMood = Color.FromArgb(20, 240, 240, 240);
			return food;
		}

		internal Mood roundUp()
		{
			currentMood = Color.FromArgb(currentMood.ToArgb() + 200);
			return new Mood();
		}

		internal Mood affectMood(int p)
		{
			throw new NotImplementedException();
		}
	}
}
