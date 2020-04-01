using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simuladorbancario.Mundo
{
    public class CDT
    {
		// -----------------------------------------------------------------
		// Atributos
		// -----------------------------------------------------------------

		/// <summary>
		/// Valor inicial del CDT.
		/// </summary>
		private double valorInvertido;

		/// <summary>
		/// Interés mensual que del CDT
		/// </summary>
		private double interesMensual;

		/// <summary>
		/// Mes de apertura del CDT.
		/// </summary>
		private int mesApertura;

		// -----------------------------------------------------------------
		// Métodos
		// -----------------------------------------------------------------

		/// <summary>
		/// Inicializa el CDT. <br>
		/// <b>post: </b> El valor invertido, el interés mensual y la fecha se inicializaron en 0.<br>
		/// </summary>
		public CDT()
		{
			valorInvertido = 0;
			interesMensual = 0;
			mesApertura = 0;
		}

		/// <summary>
		/// Retorna el interés que paga el banco mensualmente por este CDT. <br> </summary>
		/// <returns> Interés mensual del CDT. </returns>
		public virtual double darInteresMensual()
		{
			return interesMensual;
		}

		/// <summary>
		/// Inicia una inversión en un CDT .<br>
		/// <b>post: </b>Se cambian los valores del CDT, con los valores recibidos. <br> </summary>
		/// <param name="pMontoInvertido"> Monto de dinero que se va a invertir en el CDT. pMontoInvertido>0. </param>
		/// <param name="pInteresMensual"> Interés mensual que va a ganar el CDT. pInteresMensual>0. </param>
		/// <param name="pMes"> Mes de apertura del CDT. pMes>0. </param>
		public virtual void invertir(double pMontoInvertido, double pInteresMensual, int pMes)
		{
			valorInvertido = pMontoInvertido;
			interesMensual = pInteresMensual;
			mesApertura = pMes;
		}

		/// <summary>
		/// Calcula el valor presente de la inversión teniendo en cuenta el interés de la cuenta. <br> </summary>
		/// <param name="pMesActual"> Mes actual del simulador. pMesActual>0. </param>
		/// <returns> Valor presente del dinero invertido en CDT. </returns>
		public virtual double calcularValorPresente(int pMesActual)
		{
			int mesesTranscurridos = pMesActual - mesApertura;
			return (double)(valorInvertido + (mesesTranscurridos * interesMensual * valorInvertido));
		}

		/// <summary>
		/// Cierra el CDT y retorna el valor invertido más los intereses. <br>
		/// <b>post: </b>Se retornó el rendimiento del CDT, y se reinició sus atributos a 0. <br> </summary>
		/// <param name="pMesActual"> Mes de cierre para calcular el rendimiento del CDT. </param>
		/// <returns> Valor de cierre del CDT. </returns>
		public virtual double cerrar(int pMesActual)
		{
			double valorCierre = calcularValorPresente(pMesActual);
			valorInvertido = 0;
			interesMensual = 0;
			mesApertura = 0;
			return valorCierre;
		}
	}
}
