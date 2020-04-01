using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simuladorbancario.Mundo
{
    public class CuentaCorriente
    {
		// -----------------------------------------------------------------
		// Atributos
		// -----------------------------------------------------------------

		/// <summary>
		/// Saldo actual de la cuenta corriente
		/// </summary>
		private double saldo;

		// -----------------------------------------------------------------
		// Métodos
		// -----------------------------------------------------------------

		/// <summary>
		/// Inicializa la cuenta corriente. <br>
		/// <b>post: </b> Se inicializó el saldo en 0.<br>
		/// </summary>
		public CuentaCorriente()
		{
			saldo = 0;
		}

		/// <summary>
		/// Retorna el saldo de la cuenta del cliente. <br> </summary>
		/// <returns> Saldo de la cuenta corriente. </returns>
		public virtual double darSaldo()
		{
			return saldo;
		}

		/// <summary>
		/// Consigna un monto de dinero en la cuenta del cliente. <br>
		/// <b>post: </b>El saldo se incrementó en el monto de dinero dado. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a consignar en la cuenta. pMonto>0. </param>
		public virtual void consignarMonto(double pMonto)
		{
			saldo = saldo + pMonto;
		}

		/// <summary>
		/// Retira un monto de dinero de la cuenta del cliente. <br>
		/// <b>post: </b>El saldo se redujo en el monto de dinero dado. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a retirar en la cuenta. pMonto>0. </param>
		public virtual void retirarMonto(double pMonto)
		{
			saldo = saldo - pMonto;
		}

	}
}
