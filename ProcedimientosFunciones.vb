Public Class ProcedimientosFunciones

 


    Sub Main()
       

        ' Utilizamos la funcion

        Dim valor1 As Integer = 10
        Dim valor2 As Integer = 5
        Dim valor3 As Integer = 5

        Dim resultado As Integer = Multiplicar(valor1,valor2)

        Console.WriteLine("El resultado es: {0}" , resultado) ' Asi podemos imprimir tambien


        ' Utilizamos la funcion con parametros opcional
             
        Dim resultado As Integer = Sumar(valor1,valor2) ' Se puede utilizar con los 2 parametros obligatorios
        ' porque tomara por defecto el valor opcional

        ' o con los 3 paramtros

        Dim resultado As Integer = Sumar(valor1,valor2,valor3)

        Console.WriteLine("El resultado es: {0}" , resultado) ' Asi podemos imprimir tambien


        ' Utilizamos la funcion con el ParamArray


        Dim resultado As Integer = SumarN(valor1,valor2)
        Dim resultado1 As Integer = SumarN(valor1,valor2,valor3)

        Console.WriteLine("El resultado es: {0}" , resultado)
        Console.WriteLine("El resultado es: {0}" , resultado1)




    End Sub



      ' Parametros ByVal, es por valor, las variables toman el valor que se asigne
      ' VBA por defecto entiende que lo que se pasa sin decir ByVal como un valor 
      

    Private  Function Multiplicar(ByVal n1 As Integer ,  ByVal n2 As Integer) As Integer


        Dim multiplica As Integer = n1 * n2

        Return multiplica
      
    End Function
      

         ' Parametros ByRef, es por referencia , cambia el valor  a toda la variable en general
         ' La que mandamos desde la utilizacion de la funcion como la que se recibe por parametro
      

    Private  Function Multiplicar(ByRef n1 As Integer ,  ByRef n2 As Integer)  As Integer


        Dim multiplica As Integer = n1 * n2

        Return multiplica
      
    End Function




        'Parametros opcionales   


        
        Private  Function Sumar(ByVal n1 As Integer ,  Byval n2 As Integer, Optional Byval n3 As Integer = 0)  As Integer


            Dim suma As Integer = n1 + n2 + n3
    
            Return suma
          
        End Function


            ' ParamArray , se usa cuando no sabemos el numero exacto de parametros que vamos a utilizar


            Private  Function SumarN(ParamArray  ByVal numeros As Integer )  As Integer


                Dim resultado As Integer = 0

                For i As Integer = 0 To numero.Count - 1
                    
                    resultado += numero(i)

                Next i
        

                Return resultado
              
            End Function




                'IMPORTANTE - SOBRE CARGA DE METODOS


                ' SE PUEDE CREAR EL MISMO METODO VARIAS VECES  SIEMPRE Y CUANDO LOS TIPOS DE DATOS
                ' SEAN DIFERENTES


End Class



