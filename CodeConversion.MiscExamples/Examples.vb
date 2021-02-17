Public Class Examples
    
#Region "Example region one"
        Private Sub ForEachTest()
            Dim items As List(Of String)

            For Each item In items
                DoSomething()
            Next

            For Each item In items
                'Technically legal but horrifying code post conversion
                DoSomething()
            Next

            For Each item In items
                Dim current As String = item
                DoSomething()
            Next

        End Sub
#End Region

#Region "Example region two"
        Private Sub DoSomething()
            'Some code
        End Sub
#End Region

End Class
