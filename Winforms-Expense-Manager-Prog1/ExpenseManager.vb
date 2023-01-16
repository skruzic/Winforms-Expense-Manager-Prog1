Public Class ExpenseManager
    Private _entries As New List(Of Entry)()

    Public ReadOnly Property Entries() As List(Of Entry)
        Get
            Return New List(Of Entry)(_entries)
        End Get
    End Property

    Public Sub AddEntry(e As Entry)
        _entries.Add(e)
    End Sub

    Public Function TryFindEntry(id As Guid, ByRef e As Entry) As Boolean
        e = Nothing
        For Each entry In _entries
            If entry.Id = id Then
                e = entry
                Return True
            End If
        Next

        Return False
    End Function

    Public Function RemoveEntry(id As Guid) As Boolean
        Dim e As Entry = Nothing
        TryFindEntry(id, e)
        Return _entries.Remove(e)
    End Function
End Class
