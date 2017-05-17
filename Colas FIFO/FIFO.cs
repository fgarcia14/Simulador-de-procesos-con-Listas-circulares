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
				inicio.siguiente = inicio;
			}
			else
			{
				Proceso temp = inicio;
				do
				{
					temp = temp.siguiente;

				} while (temp.siguiente!=inicio);
				proceso.siguiente = inicio;
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
			if (inicio.siguiente==inicio)
			{
				inicio = null;
			}
			else
			{
				while (temp.siguiente!=inicio)
				{
					temp = temp.siguiente;
				}
				temp.siguiente = inicio.siguiente;
				inicio = temp.siguiente;
			}
			return temp;
		}

		public int pendientes() {
			Proceso temp = inicio;
			int cont = 0;
			do
			{
				cont++;
				temp = temp.siguiente;
			} while (temp!=inicio);
			return cont;
		}

		public int sumaPendientes() {
			Proceso temp = inicio;
			int cont = 0;
			do
			{
				cont += temp.ciclos;
				temp = temp.siguiente;
			} while (temp!=inicio);
			return cont;
		}

		public void reset()
		{
			inicio = null;
		}
	}
}