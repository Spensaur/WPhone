Partial Public Class MainPage
    Inherits PhoneApplicationPage

    ' Constructor
    Public Sub New()
        InitializeComponent()

        ' Set the data context of the listbox control to the sample data
        DataContext = App.ViewModel
    End Sub

    ' Handle selection changed on ListBox
    Private Sub MainListBox_SelectionChanged(ByVal sender As Object, ByVal e As SelectionChangedEventArgs)
        ' If selected index is -1 (no selection) do nothing
        If MainListBox.SelectedIndex = -1 Then
            Return
        End If

        ' Navigate to the new page
        NavigationService.Navigate(New Uri("/DetailsPage.xaml?selectedItem=" & MainListBox.SelectedIndex, UriKind.Relative))

        ' Reset selected index to -1 (no selection)
        MainListBox.SelectedIndex = -1
    End Sub

    ' Load data for the ViewModel Items
    Private Sub MainPage_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs) Handles Me.Loaded
        If Not App.ViewModel.IsDataLoaded Then
            App.ViewModel.LoadData()
        End If
    End Sub
End Class
