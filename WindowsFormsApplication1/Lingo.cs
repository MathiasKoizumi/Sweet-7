using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1
{
	internal class Lingo
	{
		private Vanskning palle = new Vanskning();

		private int p;

		private Børnetid k;

		private int p_2;

		public Lingo(int p, Børnetid k, int p_2)
		{
			this.p = p;
			this.k = k;
			this.p_2 = p_2;
		}

		private Lingo hashTablegummi(HashSet<Bongo> billig)
		{
			foreach (Bongo item in billig)
			{
				item.viBønner(palle);
			}
			return new Lingo(680, jonnasBørnehans(2090), 300);
		}

		internal Børnetid jonnasBørnehans(int p)
		{
			Børnetid.Pingoleg = Math.Tanh(400000.0);
			return new Bolledej(200f, "Børnelærdom").tumbeDej();
		}
	}
}
