Public Class Variables

 

    Sub Main()
       
    Try

    ' El codigo que se va a ejecutar

    Catch ex As Exception

    ' Capturamos la exception para que el programa no se caiga

    Finally    

    ' Esta parte siempre se ejecutara

    End Try
        

    End Sub



'System	

        'ArgumentNullException La excepción que se produce cuando se pasa una referencia nula ( Nothingen Visual Basic) a un método que no la acepta como argumento válido.
        ' ArgumentOutOfRangeException  La excepción que se lanza cuando el valor de un argumento está fuera del rango permitido de valores definido por el método invocado.
        ' DivideByZeroException  La excepción que se lanza cuando hay un intento de dividir un valor entero o decimal por cero.
        ' IndexOutOfRangeException La excepción que se lanza cuando se intenta acceder a un elemento de una matriz o colección con un índice que está fuera de sus límites.
        ' NullReference-Exception  La excepción que se lanza cuando hay un intento de desreferenciar una referencia de objeto nulo.
        ' OverflowException  La excepción que se produce cuando una operación aritmética, de conversión o conversión en un contexto comprobado da como resultado un desbordamiento.
        ' StackOverflowException La excepción que se produce cuando la pila de ejecución se desborda porque contiene demasiadas llamadas a métodos anidados. Esta clase no puede heredarse.


'System.IO

    'DirectoryNotFoundException La excepción que se lanza cuando no se puede encontrar parte de un archivo o directorio.
    'EndOfStreamException La excepción que se lanza cuando se intenta leer más allá del final de una transmisión.
    'FileNotFoundException  La excepción que se produce cuando falla un intento de acceder a un archivo que no existe en el disco.
    ' PathTooLongException  La excepción que se lanza cuando una ruta o un nombre de archivo completo es más largo que la longitud máxima definida
    ' FileLoadException La excepción que se produce cuando se encuentra un ensamblado administrado pero no se puede cargar.
    ' DriveNotFoundException La excepción que se lanza al intentar acceder a una unidad o recurso compartido que no está disponible.

'System.Data	

      ' DuplicateNameException Representa la excepción que se produce cuando se encuentra un nombre de objeto de base de datos duplicado durante una operación de adición en un objeto relacionado con DataSet .
      ' InvalidConstraintException Representa la excepción que se produce cuando se intenta crear o acceder a una relación incorrectamente.
      ' InvalidExpressionException Representa la excepción que se genera cuando intenta agregar una columna de datos que contiene una expresión no válida a una colección de columnas de datos .
      ' MissingPrimaryKeyException  Representa la excepción que se produce cuando intenta acceder a una fila de una tabla que no tiene clave principal.
      ' NoNullAllowedException Representa la excepción que se produce cuando intenta insertar un valor nulo en una columna donde AllowDBNull está establecido en false.
      ' ReadOnlyException Representa la excepción que se produce cuando intenta cambiar el valor de una columna de solo lectura.


'System.Runtime.InteropServices

    ' InvalidComObjectException  La excepción lanzada cuando se usa un objeto COM no válido.
    ' InvalidOleVariantTypeException La excepción lanzada por el contador de referencias cuando encuentra un argumento de un tipo de variante que no puede calcularse en el código administrado.
    ' SEHException Representa errores de manejo estructurado de excepciones






        

End Class



