Public Class OperadoresLogicos

 

    Sub Main()



        ' OPERADORES DE COMPARACION


        ' And  Todas las condiciones son verdaderas
        ' Or   Algunas de las condiciones son verdaderas
        ' Not  Todas las condiciones son falsas
     


        ' AndAlso  Realiza una conjunción lógica de cortocircuito en dos expresiones.


        Dim a As Integer = 10
        Dim b As Integer = 8
        Dim c As Integer = 6
        Dim firstCheck, secondCheck, thirdCheck As Boolean
        firstCheck = a > b AndAlso b > c
        secondCheck = b > a AndAlso b > c
        thirdCheck = a > b AndAlso c > b
          
        
        'OrElse Realiza la disyunción lógica inclusiva de cortocircuito en dos expresiones.
        
        Dim a As Integer = 10
        Dim b As Integer = 8
        Dim c As Integer = 6
        Dim firstCheck, secondCheck, thirdCheck As Boolean
        firstCheck = a > b OrElse b > c
        secondCheck = b > a OrElse b > c
        thirdCheck = b > a OrElse c > b

    
        ' Xor Realiza una exclusión lógica en dos Booleanexpresiones o una exclusión bit a bit en dos expresiones numéricas.

        Dim a As Integer = 10
        Dim b As Integer = 8
        Dim c As Integer = 6
        Dim firstCheck, secondCheck, thirdCheck As Boolean
        firstCheck = a > b Xor b > c
        secondCheck = b > a Xor b > c
        thirdCheck = b > a Xor c > b


    End Sub



End Class



