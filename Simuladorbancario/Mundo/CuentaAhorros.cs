using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simuladorbancario.Mundo
{
    public class CuentaAhorros
    {
		// -----------------------------------------------------------------
		// Atributos
		// -----------------------------------------------------------------

		/// <summary>
		/// Saldo actual de la cuenta de ahorro.
		/// </summary>
		private double saldo;

		/// <summary>
		/// Interés mensual que paga la cuenta de ahorro.
		/// </summary>
		private double interesMensual;

		// -----------------------------------------------------------------
		// Métodos
		// -----------------------------------------------------------------

		/// <summary>
		/// Inicializa la cuenta de ahorro con el interés mensual que paga el banco.<br>
		/// <b>post: </b> Se inicializó el saldo en 0 y el interés mensual en 0.006.<br>
		/// </summary>
		public CuentaAhorros()
		{
			saldo = 0;
			interesMensual = 0.006;
		}

		/// <summary>
		/// Retorna el saldo del cliente. <br> </summary>
		/// <returns> Saldo de la cuenta de ahorros. </returns>
		public virtual double darSaldo()
		{
			return saldo;
		}

		/// <summary>
		/// Retorna el interés mensual. <br> </summary>
		/// <returns> Interés mensual de la cuenta de ahorros. </returns>
		public virtual double darInteresMensual()
		{
			return interesMensual;
		}

		/// <summary>
		/// Consigna un monto de dinero en la cuenta del cliente. <br>
		/// <b>post: </b>El saldo se incrementó en monto de dinero ingresado. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a consignar en la cuenta. pMonto>0. </param>
		public virtual void consignarMonto(double pMonto)
		{
			saldo = saldo + pMonto;
		}

		/// <summary>
		/// Retira un monto de dinero de la cuenta de ahorros. <br>
		/// <b>post: </b>El saldo se redujo en el valor dado. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a retirar de la cuenta de ahorros. pMonto>0. </param>
		public virtual void retirarMonto(double pMonto)
		{
			saldo = saldo - pMonto;
		}

		/// <summary>
		/// Actualiza el saldo de la cuneta de ahorros sumándole los intereses (ha pasado un mes). <br>
		/// <b>post: </b>El saldo actual se actualizó aumentádole el porcentaje de interés mensual respectivo<br>
		/// </summary>
		public virtual void actualizarSaldoPorPasoMes()
		{
			saldo = saldo + (saldo * interesMensual);
		}
	}
}
