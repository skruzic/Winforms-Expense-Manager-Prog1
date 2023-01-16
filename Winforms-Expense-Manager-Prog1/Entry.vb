Public Class Entry
    Public Property Id As Guid
    Public Property Amount As Decimal
    Public Property Category As String
    Public Property CreatedAt As Date
    Public Property Description As String

    Public Sub New(amount As Decimal, desc As String, category As String, createdAt As Date)
        Me.Id = Guid.NewGuid() ' Generira jedinstveni identifikator koji nam treba za trazenje kod brisanja
        Me.Amount = amount
        Me.Description = desc
        Me.Category = category
        Me.CreatedAt = createdAt
    End Sub

    Public Function IsExpense() As Boolean
        Return Amount < 0
    End Function

    Public Function IsIncome() As Boolean
        Return Amount > 0
    End Function
End Class
