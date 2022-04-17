Public Class Bucles

 

    Sub Main()
        
        ' FOR



        For i As Integer = 0 To 10  Step 1

            Console.WriteLine(i)
            
        Next i


       ' For sobre un arreglo 

       For Each var In collection
       
        Console.WriteLine(var)

       Next var 

       
     ' DO

       Dim valor As Integer = 0

       Do 

            Console.WriteLine(valor)
            valor += 1

            If (valor = 100) Then
                
                Exit Do

            End If
       
       Loop       


       ' Do mientras

       Dim valor As Integer = 0

       Do While valor < 1000
       
        Console.WriteLine(valor)
        valor += 1

       Loop
       

        ' Do hasta

        Dim valor As Integer = 0

        Do Until valor = 1000
        
         Console.WriteLine(valor)
         valor += 1
 
        Loop
        


        ' La condicion se puede colocar en el Do o el Loop

        ' Si se coloca en el Loop, VBA leera el codigo y luego analiza la condicion


    End Sub



End Class



