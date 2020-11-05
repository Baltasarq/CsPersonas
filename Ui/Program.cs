// Personas (c) 2020 Baltasar MIT License <jbgarcia@uvigo.es>


namespace Personas.Ui {
    using System;
    using System.Xml;
    using System.Linq;
    using System.Xml.Linq;
    using System.Collections.Generic;
    
    using Core;
    
    
    internal class Program {
        static void SavePersonas(string nf, IEnumerable<Persona> personas)
        {
            var raiz = new XElement( "personas" );
    
            foreach(Persona persona in personas) {
                raiz.Add( persona.SaveToXml() );
            }

            raiz.Save( nf );
        }

        static IEnumerable<Persona> RecuperaPersonas(string nf)
        {
            var docXml = XElement.Load( nf );
            
            IEnumerable<Persona> toret =
                from personaXml in docXml.Elements( "persona" )
                    select new Persona(
                        (int) personaXml.Element( "dni" ),
                        (string) personaXml.Element( "nombre" ),
                        (int) personaXml.Element( "edad" ),
                        (string) personaXml.Element( "email" ) );
            
            return toret;
        }
        
        // Java: CamelCase: métodos (main), variables | PascalCase: clases (Persona)
        // C#: CamelCase variables | PascalCase: clases, métodos
        public static void Main(string[] args)
        {
            var p1 = new Persona( 1, "Baltasar", 18, "jbgarcia@uvigo.es" );
            var p2 = new Persona( 2, "Lourdes", 18, "lborrajo@uvigo.es" );
            var p3 = new Persona( 3, "Fran", 18, "franjrm@uvigo.es" );
            var p4 = new Persona( 4, "Perico", 20, "perico@palotes.com"  );

            /*if ( p1 is Empleado pp1 )
            {
                Console.WriteLine(pp1.Empresa);
            }

            var pp2 = p1 as Empleado;

            if (pp2 != null)
            {
                Console.WriteLine(pp2.Edad);
            }

            switch (p1.GetType().ToString())
            {
                case "Personas.Core.Persona":
                    break;
                case "Personas.Core.Empleado":
                    break;
            }*/

            Console.WriteLine( "Persona: " + p1.ToString() );

            SavePersonas( "personas.xml", new[] {p1, p2, p3, p4} );

            Console.WriteLine( "Personas recuperadas:" );
            foreach (Persona persona in RecuperaPersonas( "personas.xml" )) {
                Console.WriteLine( persona );
            }

            var e1 = new Empleado(
                p1.Dni,
                p1.Nombre,
                p1.Edad,
                p1.Email,
                "UVigo",
                new CantidadMoneda( 200000, 0 ) );
            
            Console.WriteLine( e1 );
        }
    }
}
