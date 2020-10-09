# CsPersonas

Lenguaje de programación: C#
Entorno de programación: Visual Studio, Visual Studio Code, Rider, MonoDevelop.

Una pequeña jerarquía con herencia y salvaguarda y recuperación mediante XML.
En la carpeta **Docs** hay un esquema que puede abrirse con [NClass](https://github.com/gbaychev/NClass/releases/latest/).

## Construcción

Abrir la solución *Personas.xml* en un entorno de programación. Alternativamente, teniendo **Mono** o **.NETFramework** instalado, cambiar al directorio y construir con *msbuild*.

```
$ cd CsPersonas
$ msbuild
```

Para construir con **DotNetCore**, será necesario volver a indicar el framework de destino, que en el momento de escribir esto es *.NetFramerwork v4.8*.
