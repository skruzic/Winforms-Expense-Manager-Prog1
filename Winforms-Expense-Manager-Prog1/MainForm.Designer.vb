<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AddNewButton = New System.Windows.Forms.Button()
        Me.ListView = New System.Windows.Forms.ListView()
        Me.TitleColumnHeader = New System.Windows.Forms.ColumnHeader()
        Me.AmountColumnHeader = New System.Windows.Forms.ColumnHeader()
        Me.DateColumnHeader = New System.Windows.Forms.ColumnHeader()
        Me.CategoryColumnHeader = New System.Windows.Forms.ColumnHeader()
        Me.DescColumnHeader = New System.Windows.Forms.ColumnHeader()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TotalLabel = New System.Windows.Forms.Label()
        Me.ExpenseLabel = New System.Windows.Forms.Label()
        Me.IncomeLabel = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ExpensesRadioButton = New System.Windows.Forms.RadioButton()
        Me.IncomesRadioButton = New System.Windows.Forms.RadioButton()
        Me.AllRadioButton = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.FilteredTotalLabel = New System.Windows.Forms.Label()
        Me.FilteredExpenseLabel = New System.Windows.Forms.Label()
        Me.FilteredIncomeLabel = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'AddNewButton
        '
        Me.AddNewButton.Location = New System.Drawing.Point(819, 458)
        Me.AddNewButton.Margin = New System.Windows.Forms.Padding(4)
        Me.AddNewButton.Name = "AddNewButton"
        Me.AddNewButton.Size = New System.Drawing.Size(96, 32)
        Me.AddNewButton.TabIndex = 0
        Me.AddNewButton.Text = "Novi zapis"
        Me.AddNewButton.UseVisualStyleBackColor = True
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.TitleColumnHeader, Me.AmountColumnHeader, Me.DateColumnHeader, Me.CategoryColumnHeader, Me.DescColumnHeader})
        Me.ListView.FullRowSelect = True
        Me.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView.Location = New System.Drawing.Point(12, 12)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(908, 415)
        Me.ListView.TabIndex = 1
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'TitleColumnHeader
        '
        Me.TitleColumnHeader.Text = "Vrsta"
        Me.TitleColumnHeader.Width = 100
        '
        'AmountColumnHeader
        '
        Me.AmountColumnHeader.Text = "Iznos"
        Me.AmountColumnHeader.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.AmountColumnHeader.Width = 100
        '
        'DateColumnHeader
        '
        Me.DateColumnHeader.Text = "Datum"
        Me.DateColumnHeader.Width = 150
        '
        'CategoryColumnHeader
        '
        Me.CategoryColumnHeader.Text = "Kategorija"
        Me.CategoryColumnHeader.Width = 150
        '
        'DescColumnHeader
        '
        Me.DescColumnHeader.Text = "Opis"
        Me.DescColumnHeader.Width = 400
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(819, 519)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(96, 32)
        Me.DeleteButton.TabIndex = 2
        Me.DeleteButton.Text = "Izbriši"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TotalLabel)
        Me.GroupBox1.Controls.Add(Me.ExpenseLabel)
        Me.GroupBox1.Controls.Add(Me.IncomeLabel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 433)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sumarni pregled"
        '
        'TotalLabel
        '
        Me.TotalLabel.AutoSize = True
        Me.TotalLabel.Location = New System.Drawing.Point(6, 97)
        Me.TotalLabel.Name = "TotalLabel"
        Me.TotalLabel.Size = New System.Drawing.Size(68, 21)
        Me.TotalLabel.TabIndex = 2
        Me.TotalLabel.Text = "Ukupno:"
        '
        'ExpenseLabel
        '
        Me.ExpenseLabel.AutoSize = True
        Me.ExpenseLabel.Location = New System.Drawing.Point(6, 61)
        Me.ExpenseLabel.Name = "ExpenseLabel"
        Me.ExpenseLabel.Size = New System.Drawing.Size(71, 21)
        Me.ExpenseLabel.TabIndex = 1
        Me.ExpenseLabel.Text = "Troškovi:"
        '
        'IncomeLabel
        '
        Me.IncomeLabel.AutoSize = True
        Me.IncomeLabel.Location = New System.Drawing.Point(6, 25)
        Me.IncomeLabel.Name = "IncomeLabel"
        Me.IncomeLabel.Size = New System.Drawing.Size(63, 21)
        Me.IncomeLabel.TabIndex = 0
        Me.IncomeLabel.Text = "Prihodi:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ExpensesRadioButton)
        Me.GroupBox2.Controls.Add(Me.IncomesRadioButton)
        Me.GroupBox2.Controls.Add(Me.AllRadioButton)
        Me.GroupBox2.Location = New System.Drawing.Point(424, 433)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filter po vrsti"
        '
        'ExpensesRadioButton
        '
        Me.ExpensesRadioButton.AutoSize = True
        Me.ExpensesRadioButton.Location = New System.Drawing.Point(6, 95)
        Me.ExpensesRadioButton.Name = "ExpensesRadioButton"
        Me.ExpensesRadioButton.Size = New System.Drawing.Size(86, 25)
        Me.ExpensesRadioButton.TabIndex = 2
        Me.ExpensesRadioButton.Text = "Troškovi"
        Me.ExpensesRadioButton.UseVisualStyleBackColor = True
        '
        'IncomesRadioButton
        '
        Me.IncomesRadioButton.AutoSize = True
        Me.IncomesRadioButton.Location = New System.Drawing.Point(6, 59)
        Me.IncomesRadioButton.Name = "IncomesRadioButton"
        Me.IncomesRadioButton.Size = New System.Drawing.Size(78, 25)
        Me.IncomesRadioButton.TabIndex = 1
        Me.IncomesRadioButton.Text = "Prihodi"
        Me.IncomesRadioButton.UseVisualStyleBackColor = True
        '
        'AllRadioButton
        '
        Me.AllRadioButton.AutoSize = True
        Me.AllRadioButton.Checked = True
        Me.AllRadioButton.Location = New System.Drawing.Point(6, 23)
        Me.AllRadioButton.Name = "AllRadioButton"
        Me.AllRadioButton.Size = New System.Drawing.Size(53, 25)
        Me.AllRadioButton.TabIndex = 0
        Me.AllRadioButton.TabStop = True
        Me.AllRadioButton.Text = "Sve"
        Me.AllRadioButton.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.FilteredTotalLabel)
        Me.GroupBox3.Controls.Add(Me.FilteredExpenseLabel)
        Me.GroupBox3.Controls.Add(Me.FilteredIncomeLabel)
        Me.GroupBox3.Location = New System.Drawing.Point(218, 433)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 129)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sumarni pregled filtera"
        '
        'FilteredTotalLabel
        '
        Me.FilteredTotalLabel.AutoSize = True
        Me.FilteredTotalLabel.Location = New System.Drawing.Point(6, 97)
        Me.FilteredTotalLabel.Name = "FilteredTotalLabel"
        Me.FilteredTotalLabel.Size = New System.Drawing.Size(68, 21)
        Me.FilteredTotalLabel.TabIndex = 2
        Me.FilteredTotalLabel.Text = "Ukupno:"
        '
        'FilteredExpenseLabel
        '
        Me.FilteredExpenseLabel.AutoSize = True
        Me.FilteredExpenseLabel.Location = New System.Drawing.Point(6, 61)
        Me.FilteredExpenseLabel.Name = "FilteredExpenseLabel"
        Me.FilteredExpenseLabel.Size = New System.Drawing.Size(71, 21)
        Me.FilteredExpenseLabel.TabIndex = 1
        Me.FilteredExpenseLabel.Text = "Troškovi:"
        '
        'FilteredIncomeLabel
        '
        Me.FilteredIncomeLabel.AutoSize = True
        Me.FilteredIncomeLabel.Location = New System.Drawing.Point(6, 25)
        Me.FilteredIncomeLabel.Name = "FilteredIncomeLabel"
        Me.FilteredIncomeLabel.Size = New System.Drawing.Size(63, 21)
        Me.FilteredIncomeLabel.TabIndex = 0
        Me.FilteredIncomeLabel.Text = "Prihodi:"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 571)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.ListView)
        Me.Controls.Add(Me.AddNewButton)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Upravitelj troškova"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AddNewButton As Button
    Friend WithEvents ListView As ListView
    Friend WithEvents TitleColumnHeader As ColumnHeader
    Friend WithEvents AmountColumnHeader As ColumnHeader
    Friend WithEvents DateColumnHeader As ColumnHeader
    Friend WithEvents CategoryColumnHeader As ColumnHeader
    Friend WithEvents DescColumnHeader As ColumnHeader
    Friend WithEvents DeleteButton As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ExpenseLabel As Label
    Friend WithEvents IncomeLabel As Label
    Friend WithEvents TotalLabel As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ExpensesRadioButton As RadioButton
    Friend WithEvents IncomesRadioButton As RadioButton
    Friend WithEvents AllRadioButton As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents FilteredTotalLabel As Label
    Friend WithEvents FilteredExpenseLabel As Label
    Friend WithEvents FilteredIncomeLabel As Label
End Class
