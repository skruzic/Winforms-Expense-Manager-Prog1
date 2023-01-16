Imports System.Windows.Forms

Public Class AddNewEntry
    Dim _manager As ExpenseManager

    Public Sub New(manager As ExpenseManager)
        _manager = manager
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Dim amount As Decimal = Decimal.Parse(AmountNumericUpDown.Value)
        Dim description As String = DescTextBox.Text
        Dim category As String = CategoryComboBox.SelectedItem
        Dim createdAt As DateTime = DateTimePicker.Value

        If amount = 0 Then
            MessageBox.Show("Iznos ne smije biti jednak nuli. Molim pokušajte ponovo!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim entry As Entry = New Entry(amount, description, category, createdAt)
        _manager.AddEntry(entry)

        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

End Class
