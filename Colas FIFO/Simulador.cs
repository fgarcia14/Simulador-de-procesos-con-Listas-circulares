using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
	class Simulador
	{
		private String data;
		private static Random rand;
		FIFO fifo;

		private int procesosAtendidos, ciclosVacios;

		public Simulador()
		{
			data = "";
			rand = new Random();
			fifo = new FIFO();
			procesosAtendidos = 0;
			ciclosVacios = 0;
		}

		public String procesos()
		{
			procesosAtendidos = 0;
			ciclosVacios = 0;
			for (int i = 0; i < 200; i++)
			{
				if (rand.Next(1, 5) == 1)
				{
					Proceso p = new Proceso(rand.Next(4, 15));
					fifo.agregar(p);
				}
				if (fifo.ver() != null)
				{
					fifo.ver().ciclos--;
					if (fifo.ver().ciclos == 0)
					{
						fifo.sacar();
						procesosAtendidos++;
					}
					else
					{
						ciclosVacios++;
					}
				}
				fifo.avanzar();
			}
			data = "Procesos atendidos: " + procesosAtendidos + Environment.NewLine + "Ciclos vacios: " + ciclosVacios + Environment.NewLine + "Procesos pendientes: " + fifo.pendientes() + Environment.NewLine + "Sumatoria de pendientes: " + fifo.sumaPendientes();
			fifo.reset();
			return data;
		}
	}
}