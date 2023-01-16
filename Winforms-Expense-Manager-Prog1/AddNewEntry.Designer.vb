<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewEntry
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.CancelButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AmountNumericUpDown = New System.Windows.Forms.NumericUpDown()
        Me.CategoryComboBox = New System.Windows.Forms.ComboBox()
        Me.DescTextBox = New System.Windows.Forms.TextBox()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AmountNumericUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OKButton, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.CancelButton, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(132, 319)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(219, 46)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OKButton
        '
        Me.OKButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OKButton.Location = New System.Drawing.Point(5, 4)
        Me.OKButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(99, 38)
        Me.OKButton.TabIndex = 0
        Me.OKButton.Text = "OK"
        '
        'CancelButton
        '
        Me.CancelButton.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CancelButton.Location = New System.Drawing.Point(114, 4)
        Me.CancelButton.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(99, 38)
        Me.CancelButton.TabIndex = 1
        Me.CancelButton.Text = "Poništi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 59)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Iznos"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 113)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 21)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Kategorija"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Opis"
        '
        'AmountNumericUpDown
        '
        Me.AmountNumericUpDown.DecimalPlaces = 2
        Me.AmountNumericUpDown.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.AmountNumericUpDown.Location = New System.Drawing.Point(153, 57)
        Me.AmountNumericUpDown.Margin = New System.Windows.Forms.Padding(4)
        Me.AmountNumericUpDown.Maximum = New Decimal(New Integer() {1000000, 0, 0, 0})
        Me.AmountNumericUpDown.Minimum = New Decimal(New Integer() {1000000, 0, 0, -2147483648})
        Me.AmountNumericUpDown.Name = "AmountNumericUpDown"
        Me.AmountNumericUpDown.Size = New System.Drawing.Size(179, 29)
        Me.AmountNumericUpDown.TabIndex = 4
        Me.AmountNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CategoryComboBox
        '
        Me.CategoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CategoryComboBox.FormattingEnabled = True
        Me.CategoryComboBox.Items.AddRange(New Object() {"Plaća", "Ostali prihodi", "Režije", "Hrana", "Transport", "Shopping"})
        Me.CategoryComboBox.Location = New System.Drawing.Point(153, 112)
        Me.CategoryComboBox.Name = "CategoryComboBox"
        Me.CategoryComboBox.Size = New System.Drawing.Size(179, 29)
        Me.CategoryComboBox.TabIndex = 5
        '
        'DescTextBox
        '
        Me.DescTextBox.Location = New System.Drawing.Point(153, 222)
        Me.DescTextBox.Multiline = True
        Me.DescTextBox.Name = "DescTextBox"
        Me.DescTextBox.Size = New System.Drawing.Size(179, 75)
        Me.DescTextBox.TabIndex = 6
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Location = New System.Drawing.Point(153, 167)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(179, 29)
        Me.DateTimePicker.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 173)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 21)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Datum"
        '
        'AddNewEntry
        '
        Me.AcceptButton = Me.OKButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.CancelButton
        Me.ClientSize = New System.Drawing.Size(369, 385)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.DescTextBox)
        Me.Controls.Add(Me.CategoryComboBox)
        Me.Controls.Add(Me.AmountNumericUpDown)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AddNewEntry"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Novi zapis"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AmountNumericUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OKButton As System.Windows.Forms.Button
    Friend WithEvents CancelButton As System.Windows.Forms.Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CategoryComboBox As ComboBox
    Friend WithEvents DescTextBox As TextBox
    Friend WithEvents DateTimePicker As DateTimePicker
    Friend WithEvents Label4 As Label
    Private WithEvents AmountNumericUpDown As NumericUpDown
End Class
