Module Module1

    Sub Main()
        'Dim i, num As Integer
        'Console.Write("請輸入總人數:")
        'num = Val(Console.ReadLine())
        'Dim all(num - 1) As Integer
        'For i = 0 To all.GetUpperBound
        '    Console.Write("請輸入第{0}個數值:", (i + 1).ToString())
        '    all(i) = Val(Console.ReadLine())
        'Next
        'Console.WriteLine("最大數是{0}", getmax(all).ToString())
        'Console.WriteLine()
        'Console.WriteLine("最小數是{0}", getmin(all).ToString())
        'Console.ReadLine()
        Dim num, w As Integer

    End Sub
    Function getmax(ByVal ParamArray x() As Integer) As Integer
        Dim max As Integer
        max = x(0)
        For z As Integer = 1 To x.Length - 1
            If x(z) > max Then
                max = x(z)
            End If
            Return max
        Next
    End Function
    Function getmin(ByVal ParamArray x() As Integer) As Integer
        Dim min As Integer
        min = x(0)
        For z As Integer = 1 To x.Length - 1
            If x(z) < min Then
                min = x(z)
            End If
            Return min
        Next
    End Function
End Module
