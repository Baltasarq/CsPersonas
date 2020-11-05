// Personas (c) 2020 Baltasar MIT License <jbgarcia@uvigo.es>


namespace Personas.Core {
    public class Empleado: Persona {
        public Empleado(int dni, string nombre, int edad,
            string email, string empresa, CantidadMoneda sueldo)
                : base(dni, nombre, edad, email)
        {
            this.Empresa = new Empresa( empresa );
            this.Sueldo = new CantidadMoneda( sueldo.ValorCentimos );
        }

        public Empresa Empresa {
            get;
            set;
        }

        public CantidadMoneda Sueldo {
            get;
        }

        public override string ToString()
        {
            string toret = base.ToString();

            toret += string.Format(
                " Empresa: {0}, Sueldo: {1:00}",
                this.Empresa,
                this.Sueldo );

            return toret;
        }
    }
}
