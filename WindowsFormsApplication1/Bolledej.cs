using System;

namespace WindowsFormsApplication1
{
	internal class Bolledej
	{
		private float k;

		private string p;

		private double p_2;

		private string p_3;

		public Bolledej(float k, string p)
		{
			this.k = k;
			this.p = p;
		}

		public Bolledej(double p_2, string p_3)
		{
			this.p_2 = p_2;
			this.p_3 = p_3;
		}

		public Børnetid tumbeDej()
		{
			k = 400 + Tegneserie.Hugo;
			Tegneserie.Hugo = (int)Math.Pow(k, 2.0);
			return new Børnetid(new Afmagt(3.0, 400f));
		}

		internal void bolleDej(double p)
		{
			throw new NotImplementedException();
		}

		internal void numerolog(int p, string p_2, string p_3)
		{
			throw new NotImplementedException();
		}
	}
}
