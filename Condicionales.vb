Public Class Condicionalere

 

    Sub Main()


      Dim opcion As Integer = 1



     ' Simple
      If (opcion = 1 ) Then
     
        Console.WriteLine("opcion 1")

      End If
     
      

      ' Dos condiciones     

        
        If (opcion = 1 ) Then 
        
        Console.WriteLine("opcion 1")

        Else

            Console.WriteLine("opcion no existe")
        
        End If


    ' varias condiciones

    If (opcion = 1 ) Then

        Console.WriteLine("opcion 1")
    
    ElseIf (opcion = 2  Then

        Console.WriteLine("opcion 2")

    Else     
    
        Console.WriteLine("opcion no existe")

    End If




'---------------------------------------------------------------------

' Condicionales con CASE


Dim opcion As Integer = 1


Select Case opcion 

 Case 1
    Console.WriteLine("opcion 1")

 Case 2
    Console.WriteLine("opcion 2")

 Case 3
    Console.WriteLine("opcion 1")

  Case Else 
    Console.WriteLine("opcion no existe")

 End Select


        
'----------------------------------------------------------------------------------------------

' Condicionales con operador logicos


Dim opcion As Integer = 10



     ' Simple
      If (opcion < 11  And opcion > 5) Then
     
        Console.WriteLine("opcion 1")

      End If


        

    End Sub



End Class



