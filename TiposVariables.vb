Public Class Variables

 

    Sub Main()
        Dim a As Integer = 0 'Numero entero
        Dim b As String = &quot;&quot; 'Cadena
        Dim c As Char = "2" 'Caracter

        MsgBox("The formatted date is " & Format(#5/31/1993#, "dddd, d MMM yyyy"))
        Dim dateInMay As New System.DateTime(1993, 5, 31, 12, 14, 0)

        Dim fechaCreacion As Date = Date.Now ' La fecha actual

        Dim d1  As Decimal = 2.375D
        Dim dub As Double = 4.0R
        Dim longValue1 As Long = 4294967296
        Dim ulongValue1 As ULong = 7934076125

        ' Para objetos

        Dim objDb As Object
        Dim myCollection As New Collection()
        ' Suppose myCollection has now been populated.
        objDb = myCollection.Item(1)


        Dim shortValue1 As Short = 1034
        Dim ushortValue1 As UShort = 65034

        Dim uintValue1 As UInteger = 3000000000ui

        Dim byteValue1 As Byte = ' Byte
        Dim sbyteValue1 As SByte = -102


        Dim runningVB As Boolean = false 'Booleano

        Dim miVar As Variant = 'tipo de datos 
        'especial que puede contener cualquier clase de datos
        'excepto datos de cadena de longitud fija
        

        

    End Sub



End Class



