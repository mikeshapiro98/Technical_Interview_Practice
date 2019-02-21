' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)
        helloJoe.Content = "THIS is the coolest"


    End Sub

    Private Sub helloJoe_KeyDown(sender As Object, e As KeyRoutedEventArgs) Handles helloJoe.KeyDown
        helloJoe.Content = "Move Bitch"
    End Sub
End Class
