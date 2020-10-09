// Personas (c) 2020 Baltasar MIT License <jbgarcia@uvigo.es>


namespace Personas.Core {
    using System;
    using System.Text;
    using System.Xml.Linq;
    
    public class Persona {
        /// <summary>
        /// Crea una nueva <see cref="Persona"/>.
        /// </summary>
        /// <param name="dni">El nuevo dni, como entero.</param>
        /// <param name="nombre">El nuevo nombre, como texto.</param>
        /// <param name="edad">La edad, como entero.</param>
        /// <param name="email">El e.mail, como texto.</param>
        public Persona(int dni, string nombre, int edad, string email)
        {
            this.Dni = dni;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Email = email;
        }

        /// <summary>
        /// Devuelve el DNI como entero.
        /// </summary>
        /// <seealso cref="Persona.toString"/>
        public int Dni {
            get;
        }

        public string Nombre {
            get {
                return this.nombre;
            }
            set {
                this.nombre = value[ 0 ].ToString().ToUpper()
                              + value.Substring( 1 ).ToLower();
            }
        }
        
        public int Edad {
            get;
            set;
        }

        public string Email {
            get;
            set;
        }

        public override string ToString()
        {
            /*
            var toret = new StringBuilder();

            toret.Append( this.Dni );
            toret.Append( ": " );
            toret.Append( this.Nombre );
            toret.Append( ", " );
            toret.Append( this.Email );

            return toret.ToString();*/
            return String.Format( "{0}: {1} ({2}), {3}",
                                    this.Dni,
                                    this.Nombre,
                                    this.Edad,
                                    this.Email );
        }

        /// <summary>
        /// Devuelve un nodo toda la info de la persona.
        /// </summary>
        /// <returns>un XElement con otros subnodos dentro.</returns>
        public XElement SaveToXml()
        {
            var raizPersona = new XElement( "persona" );
            
            raizPersona.Add(
                new XElement( "nombre", this.Nombre ),
                new XElement( "dni", this.Dni ),
                new XElement( "edad", this.Edad.ToString() ),
                new XElement( "email", this.Email )
            );

            return raizPersona;
        }

        string nombre;
    }
}