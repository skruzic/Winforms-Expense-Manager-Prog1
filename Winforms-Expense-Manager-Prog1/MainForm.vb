Public Class MainForm
    Private ReadOnly _manager As ExpenseManager = New ExpenseManager()
    Private _income As Decimal
    Private _expense As Decimal
    Private _filteredIncome As Decimal
    Private _filteredExpense As Decimal

#Region "Filters"
    Private Function TypeFilter(e As Entry) As Boolean
        If AllRadioButton.Checked Then
            Return True
        End If
        If ExpensesRadioButton.Checked Then
            Return e.IsExpense()
        End If
        If IncomesRadioButton.Checked Then
            Return e.IsIncome()
        End If

        Return False
    End Function
#End Region

#Region "Helper Methods"
    Private Function ApplyFilters() As List(Of Entry)
        Dim output As New List(Of Entry)
        For Each e In _manager.Entries
            Dim pass As Boolean = True
            pass = pass AndAlso TypeFilter(e)
            If pass Then
                output.Add(e)
            End If
        Next

        CalculateFilteredTotal(output)
        UpdateFilteredSummary()
        Return output

    End Function

    Private Sub PopulateListView()
        Dim entries As List(Of Entry) = ApplyFilters()

        entries.Sort(Function(e1, e2)
                         Return e1.CreatedAt.CompareTo(e2.CreatedAt)
                     End Function)

        ListView.Items.Clear()

        For Each e As Entry In entries
            Dim item = New ListViewItem(If(e.Amount > 0, "Prihod", "Trošak"))
            item.SubItems.Add($"{e.Amount.ToString("C")}")
            item.SubItems.Add(e.CreatedAt.ToShortDateString())
            item.SubItems.Add(e.Category)
            item.SubItems.Add(e.Description)
            item.Tag = e.Id
            ListView.Items.Add(item)
        Next
    End Sub

    Private Sub CalculateTotal(entries As List(Of Entry))
        Dim income As Decimal, expense As Decimal

        For Each e As Entry In entries
            If e.IsIncome() Then
                income += e.Amount
            End If
            If e.IsExpense() Then
                expense += e.Amount
            End If
        Next

        _income = income
        _expense = expense
    End Sub

    Private Sub CalculateFilteredTotal(entries As List(Of Entry))
        Dim income As Decimal, expense As Decimal

        For Each e As Entry In entries
            If e.IsIncome() Then
                income += e.Amount
            End If
            If e.IsExpense() Then
                expense += e.Amount
            End If
        Next

        _filteredIncome = income
        _filteredExpense = expense
    End Sub

    Private Sub UpdateSummary()
        IncomeLabel.Text = $"Prihodi: {_income.ToString("C")}"
        ExpenseLabel.Text = $"Troškovi: {_expense.ToString("C")}"
        TotalLabel.Text = $"Ukupno: {(_income + _expense).ToString("C")}"
    End Sub

    Private Sub UpdateFilteredSummary()
        FilteredIncomeLabel.Text = $"Prihodi: {_filteredIncome.ToString("C")}"
        FilteredExpenseLabel.Text = $"Troškovi: {_filteredExpense.ToString("C")}"
        FilteredTotalLabel.Text = $"Ukupno: {(_filteredIncome + _filteredExpense).ToString("C")}"
    End Sub

    Private Sub UpdateListViewAndSummary()
        PopulateListView()
        CalculateTotal(_manager.Entries)
        UpdateSummary()
    End Sub
#End Region

#Region "Events"

    Private Sub AddNewButton_Click(sender As Object, e As EventArgs) Handles AddNewButton.Click
        Dim addNewEntryForm = New AddNewEntry(_manager)
        addNewEntryForm.ShowDialog()
        UpdateListViewAndSummary()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim result = MessageBox.Show(
            "Jeste li sigurni da želite izbrisati označeni zapis?",
            "Upozorenje",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning)

        If result = DialogResult.No Then
            Exit Sub
        End If

        _manager.RemoveEntry(CType(ListView.SelectedItems(0).Tag, Guid))
        UpdateListViewAndSummary()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AllRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AllRadioButton.CheckedChanged
        PopulateListView()
    End Sub

    Private Sub IncomesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles IncomesRadioButton.CheckedChanged
        PopulateListView()
    End Sub

    Private Sub ExpensesRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles ExpensesRadioButton.CheckedChanged
        PopulateListView()
    End Sub
#End Region

End Class
