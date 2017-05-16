using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colas_FIFO
{
	class FIFO
	{
		private Proceso inicio;

		public FIFO()
		{
			inicio = null;
		}

		public void agregar(Proceso proceso)
		{
			if (inicio == null)
			{
				inicio = proceso;
			}
			else
			{
				Proceso temp = inicio;
				while (temp.siguiente!=null)
				{
					temp = temp.siguiente;
				}
				temp.siguiente = proceso;
			}
		}

		public Proceso ver()
		{
			return inicio;
		}

		public Proceso sacar()
		{
			Proceso temp=inicio;
			inicio = inicio.siguiente;
			return temp;
		}

		public int pendientes() {
			Proceso temp = inicio;
			int cont = 0;
			while (temp!=null)
			{
				cont++;
				temp = temp.siguiente;
			}
			return cont;
		}

		public int sumaPendientes() {
			Proceso temp = inicio;
			int cont = 0;
			while (temp!=null)
			{
				cont += temp.ciclos;
				temp = temp.siguiente;
			}
			return cont;
		}

		public void reset()
		{
			inicio = null;
		}
	}
}