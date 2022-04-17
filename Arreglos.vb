Public Class Arreglos 

    Sub Main()

         ' Simples o unidimensionales

        Dim miArray(3) As String = {"Gabriel","Stefany","Angel", "Samuel"}        
        
        Console.WriteLine(miArray(0))

        Dim miArrayNuevo(3) As String 
        
         miArrayNuevo(0) = "Gabriel"
         miArrayNuevo(1) = "Stefany"
         miArrayNuevo(2)"Angel"
         miArrayNuevo(3) = "Samuel"
         
         
         ReDim Preserve miArrayNuevo(1) ' Con esta opcion modificamos la cantidad de datos del arreglo
         ' y con la palabra Preserve guarda los datos anteriors.


        ' Arreglos Multidimensionales


        Dim miArrayMulti(2,2) As String 
        
        miArrayMulti(0,0) = "Nombre"
        miArrayMulti(0,1) = "Apellido"
        miArrayMulti(0,2) = "Edad"

        miArrayMulti(1,0) = "Gabriel"
        miArrayMulti(1,1) = "Betin"
        miArrayMulti(1,2) = "31"


        miArrayMulti(2,0) = "Stefany"
        miArrayMulti(2,1) = "Coba"
        miArrayMulti(2,2) = "32"

       
    End Sub

End Class



