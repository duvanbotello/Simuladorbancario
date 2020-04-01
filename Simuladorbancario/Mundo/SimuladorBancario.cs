using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simuladorbancario.Mundo
{
    public class SimuladorBancario
    {
		// -----------------------------------------------------------------
		// Atributos
		// -----------------------------------------------------------------

		/// <summary>
		/// Cédula del cliente.
		/// </summary>
		private string cedula;

		/// <summary>
		/// Nombre del cliente.
		/// </summary>
		private string nombre;

		/// <summary>
		/// Mes actual.
		/// </summary>
		private int mesActual;

		/// <summary>
		/// Cuenta corriente del cliente.
		/// </summary>
		private CuentaCorriente corriente;

		/// <summary>
		/// Cuenta de ahorros del cliente.
		/// </summary>
		private CuentaAhorros ahorros;

		/// <summary>
		/// CDT del cliente.
		/// </summary>
		private CDT inversion;

		// -----------------------------------------------------------------
		// Métodos
		// -----------------------------------------------------------------

		/// <summary>
		/// Inicializa el simulador con la información del cliente. <br>
		/// <b>post: </b> El mes fue inicializado en 1, y las tres cuentas (CDT, corriente y de ahorros) fueron inicializadas como vacías. <br> </summary>
		/// <param name="pCedula"> Cédula del nuevo cliente. pCedula!=null && pCedula!="". </param>
		/// <param name="pNombre"> Nombre del nuevo cliente. pNombre!=null && pNombre!="". </param>
		public SimuladorBancario(string pCedula, string pNombre)
		{
			// Inicializa los atributos personales del cliente
			nombre = pNombre;
			cedula = pCedula;
			// Inicializa el mes en el 1
			mesActual = 1;
			// Inicializa las tres cuentas en vacío
			corriente = new CuentaCorriente();
			ahorros = new CuentaAhorros();
			inversion = new CDT();
		}

		/// <summary>
		/// Retorna el nombre del cliente<br> </summary>
		/// <returns> Nombre del cliente. </returns>
		public virtual string darNombre()
		{
			return nombre;
		}

		/// <summary>
		/// Retorna la cédula del cliente<br> </summary>
		/// <returns> Cédula del cliente. </returns>
		public virtual string darCedula()
		{
			return cedula;
		}

		/// <summary>
		/// Retorna la cuenta corriente del cliente. </summary>
		/// <returns> Cuenta corriente del cliente. </returns>
		public virtual CuentaCorriente darCuentaCorriente()
		{
			return corriente;
		}

		/// <summary>
		/// Retorna la cuenta de ahorros del cliente. </summary>
		/// <returns> Cuenta de Ahorros del cliente. </returns>
		public virtual CuentaAhorros darCuentaAhorros()
		{
			return ahorros;
		}

		/// <summary>
		/// Retorna el CDT del cliente. </summary>
		/// <returns> CDT del cliente. </returns>
		public virtual CDT darCDT()
		{
			return inversion;
		}

		/// <summary>
		/// Retorna el mes en el que se encuentra la simulación. </summary>
		/// <returns> Mes actual. </returns>
		public virtual int darMesActual()
		{
			return mesActual;
		}

		/// <summary>
		/// Calcula el saldo total de las cuentas del cliente. <br> </summary>
		/// <returns> Saldo total de la cuentas del cliente. </returns>
		public virtual double calcularSaldoTotal()
		{
			return corriente.darSaldo() + ahorros.darSaldo() + inversion.calcularValorPresente(mesActual);
		}

		/// <summary>
		/// Invierte un monto de dinero en un CDT. <br>
		/// <b>post: </b> Invirtió un monto de dinero en un CDT. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a invertir en un CDT. pMonto > 0. </param>
		/// <param name="pInteresMensual"> Interés del CDT elegido por el cliente. pInteresMensual > 0. </param>
		public virtual void invertirCDT(double pMonto, double pInteresMensual)
		{
			inversion.invertir(pMonto, pInteresMensual, mesActual);
		}

		/// <summary>
		/// Consigna un monto de dinero en la cuenta corriente. <br>
		/// <b>post: </b> Consignó un monto de dinero en la cuenta corriente. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a consignar en la cuenta. pMonto > 0. </param>
		public virtual void consignarCuentaCorriente(double pMonto)
		{
			corriente.consignarMonto(pMonto);
		}

		/// <summary>
		/// Consigna un monto de dinero en la cuenta de ahorros. <br>
		/// * <b>post: </b> Consignó un monto de dinero en la cuenta de ahorros. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a consignar en la cuenta. pMonto > 0. </param>
		public virtual void consignarCuentaAhorros(double pMonto)
		{
			ahorros.consignarMonto(pMonto);
		}

		/// <summary>
		/// Retira un monto de dinero de la cuenta corriente.<br>
		/// <b>post: </b> Se redujo el saldo de la cuenta en el monto especificado. <br> </summary>
		/// <param name="pMonto"> Monto de dinero a retirar de la cuenta. pMonto > 0. </param>
		public virtual void retirarCuentaCorriente(double pMonto)
		{
			corriente.retirarMonto(pMonto);
		}

		/// <summary>
		/// Retira un monto de dinero de la cuenta de ahorros. <br>
		/// <b>post: </b> Se redujo el saldo de la cuenta en el monto especificado.<br> </summary>
		/// <param name="pMonto"> Monto de dinero a retirar de la cuenta. pMonto > 0. </param>
		public virtual void retirarCuentaAhorros(double pMonto)
		{
			ahorros.retirarMonto(pMonto);
		}

		/// <summary>
		/// Avanza en un mes la simulación. <br>
		/// <b>post: </b> Se avanzó el mes de la simulación en 1. Se actualizó el saldo de la cuenta de ahorros.<br>
		/// </summary>
		public virtual void avanzarMesSimulacion()
		{
			mesActual += 1;
			ahorros.actualizarSaldoPorPasoMes();
		}

		/// <summary>
		/// Cierra el CDT, pasando el saldo a la cuenta corriente. <br>
		/// <b>pre: </b> La cuenta corriente y el CDT han sido inicializados. <br>
		/// <b>post: </b> El CDT quedó cerrado y con valores en 0, y la cuenta corriente aumentó su saldo en el valor del cierre del CDT.
		/// </summary>
		public virtual void cerrarCDT()
		{
			double valorCierreCDT = inversion.cerrar(mesActual);
			corriente.consignarMonto(valorCierreCDT);
		}

		/// <summary>
		/// Retorna el resultado de la extensión 1. </summary>
		/// <returns> Respuesta 1. </returns>
		public virtual string metodo1()
		{
			return "Respuesta 1";
		}

		/// <summary>
		/// Retorna el resultado de la extensión 2. </summary>
		/// <returns> Respuesta 2. </returns>
		public virtual string metodo2()
		{
			return "Respuesta 2";
		}

	}
}
