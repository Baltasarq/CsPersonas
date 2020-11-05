// Personas (c) 2020 Baltasar MIT License <jbgarcia@uvigo.es>


namespace Personas.Core {
    public class CantidadMoneda {
        /// <summary>
        /// Crea una nueva cantidad monetaria, en céntimos.
        /// </summary>
        /// <param name="centimos">El valor en céntimos, 1€ = 100</param>
        public CantidadMoneda(int centimos)
        {
            this.ValorCentimos = centimos;
        }

        /// <summary>
        /// Crea una nueva cantidad monetaria,
        /// especificando en euros y céntimos de euro.
        /// 1,50 -> CantidadMoneda(1, 50)
        /// </summary>
        /// <param name="parteEuros"></param>
        /// <param name="parteCentimos"></param>
        public CantidadMoneda(int parteEuros, int parteCentimos)
            : this(parteEuros * 100 + parteCentimos)
        {
        }

        /// <summary>
        /// Nos devuelve la parte correspondiente a los euros
        /// (sin céntimos) => 1,50 devuelve 1.
        /// Si se asigna, se guardan solo cantidades sin céntimos.
        /// </summary>
        public int ValorParteEuros {
            get {
                return this.ValorCentimos / 100;
            }
            set {
                this.ValorCentimos = value * 100;
            }
        }

        /// <summary>
        /// Nos devuelve la parte correspondiente a los céntimos
        /// (sin euros) => 1,50 devuelve 50.
        /// Si se asigna, se asigna completamente 150 -> 1,50€
        /// </summary>
        public int ValorParteCentimos {
            get { return this.ValorCentimos % 100; }
        }
        
        /// <summary>
        /// Devuelve la cantidad guardada en céntimos.
        /// 1,50€ -> 150.
        /// </summary>
        public int ValorCentimos {
            get;
            set;
        }

        public override string ToString()
        {
            return $"{this.ValorParteEuros},{this.ValorParteCentimos:D2}€";
        }
    }
}