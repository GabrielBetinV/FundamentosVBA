Public Class OperadoresComparacion

 

    Sub Main()



        ' OPERADORES DE COMPARACION


        ' = IGUAL QUE
        ' <> DISTINTO QUE
        ' < MENOR QUE
        ' > MAYOR QUE
        ' =< , <= MENOR O IGUAL QUE
        ' => , >= MAYOR O IGUAL QUE

        ' Operador Is


        Dim myObject As New Object
        Dim otherObject As New Object
        Dim yourObject, thisObject, thatObject As Object
        Dim myCheck As Boolean
        yourObject = myObject
        thisObject = myObject
        thatObject = otherObject
        ' The following statement sets myCheck to True.
        myCheck = yourObject Is thisObject
        ' The following statement sets myCheck to False.
        myCheck = thatObject Is thisObject
        ' The following statement sets myCheck to False.
        myCheck = myObject Is thatObject
        thatObject = myObject
        ' The following statement sets myCheck to True.
        myCheck = thisObject Is thatObject
        
        
        ' Operador  Isnot

        Dim o1, o2 As New Object
        If Not o1 Is o2 Then MsgBox("o1 and o2 do not refer to the same instance.")
        If o1 IsNot o2 Then MsgBox("o1 and o2 do not refer to the same instance.")

       ' Operador Like

       Dim testCheck As Boolean
       ' The following statement returns True (does "F" satisfy "F"?)
       testCheck = "F" Like "F"
       ' The following statement returns False for Option Compare Binary
       '    and True for Option Compare Text (does "F" satisfy "f"?)
       testCheck = "F" Like "f"
       ' The following statement returns False (does "F" satisfy "FFF"?)
       testCheck = "F" Like "FFF"
       ' The following statement returns True (does "aBBBa" have an "a" at the
       '    beginning, an "a" at the end, and any number of characters in 
       '    between?)
       testCheck = "aBBBa" Like "a*a"
       ' The following statement returns True (does "F" occur in the set of
       '    characters from "A" through "Z"?)
       testCheck = "F" Like "[A-Z]"
       ' The following statement returns False (does "F" NOT occur in the 
       '    set of characters from "A" through "Z"?)
       testCheck = "F" Like "[!A-Z]"
       ' The following statement returns True (does "a2a" begin and end with
       '    an "a" and have any single-digit number in between?)
       testCheck = "a2a" Like "a#a"
       ' The following statement returns True (does "aM5b" begin with an "a",
       '    followed by any character from the set "L" through "P", followed
       '    by any single-digit number, and end with any character NOT in
       '    the character set "c" through "e"?)
       testCheck = "aM5b" Like "a[L-P]#[!c-e]"
       ' The following statement returns True (does "BAT123khg" begin with a
       '    "B", followed by any single character, followed by a "T", and end
       '    with zero or more characters of any type?)
       testCheck = "BAT123khg" Like "B?T*"
       ' The following statement returns False (does "CAT123khg"?) begin with
       '    a "B", followed by any single character, followed by a "T", and
       '    end with zero or more characters of any type?)
       testCheck = "CAT123khg" Like "B?T*"


                
    
        

    End Sub



End Class



