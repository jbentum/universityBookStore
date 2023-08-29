<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.TextBookSaleInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.TotalButton = New System.Windows.Forms.Button()
        Me.ComputeButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.QuantityTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDueTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.SubtotalTextBox = New System.Windows.Forms.TextBox()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.ISBNTextBox = New System.Windows.Forms.TextBox()
        Me.BookTitleTextBox = New System.Windows.Forms.TextBox()
        Me.TotalDueLabel = New System.Windows.Forms.Label()
        Me.SalesLabel = New System.Windows.Forms.Label()
        Me.SubtotalLabel = New System.Windows.Forms.Label()
        Me.QuantityLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ISBNLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBookSaleInfoGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBookSaleInfoGroupBox
        '
        Me.TextBookSaleInfoGroupBox.BackColor = System.Drawing.Color.Silver
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.ExitButton)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.TotalButton)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.ComputeButton)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.ResetButton)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.QuantityTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.TotalDueTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.SalesTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.SubtotalTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.PriceTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.ISBNTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.BookTitleTextBox)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.TotalDueLabel)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.SalesLabel)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.SubtotalLabel)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.QuantityLabel)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.PriceLabel)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.ISBNLabel)
        Me.TextBookSaleInfoGroupBox.Controls.Add(Me.Label1)
        Me.TextBookSaleInfoGroupBox.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TextBookSaleInfoGroupBox.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TextBookSaleInfoGroupBox.Location = New System.Drawing.Point(1, 2)
        Me.TextBookSaleInfoGroupBox.Name = "TextBookSaleInfoGroupBox"
        Me.TextBookSaleInfoGroupBox.Size = New System.Drawing.Size(698, 448)
        Me.TextBookSaleInfoGroupBox.TabIndex = 0
        Me.TextBookSaleInfoGroupBox.TabStop = False
        Me.TextBookSaleInfoGroupBox.Text = "Textbook Sale Information"
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.DarkOrange
        Me.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ExitButton.Location = New System.Drawing.Point(360, 269)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(82, 35)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'TotalButton
        '
        Me.TotalButton.BackColor = System.Drawing.Color.DarkOrange
        Me.TotalButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalButton.Location = New System.Drawing.Point(256, 269)
        Me.TotalButton.Name = "TotalButton"
        Me.TotalButton.Size = New System.Drawing.Size(82, 35)
        Me.TotalButton.TabIndex = 2
        Me.TotalButton.Text = "Totals"
        Me.TotalButton.UseVisualStyleBackColor = False
        '
        'ComputeButton
        '
        Me.ComputeButton.BackColor = System.Drawing.Color.DarkOrange
        Me.ComputeButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ComputeButton.Location = New System.Drawing.Point(64, 269)
        Me.ComputeButton.Name = "ComputeButton"
        Me.ComputeButton.Size = New System.Drawing.Size(82, 35)
        Me.ComputeButton.TabIndex = 2
        Me.ComputeButton.Text = "&Compute"
        Me.ComputeButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.Color.DarkOrange
        Me.ResetButton.Enabled = False
        Me.ResetButton.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ResetButton.Location = New System.Drawing.Point(168, 269)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(82, 35)
        Me.ResetButton.TabIndex = 2
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'QuantityTextBox
        '
        Me.QuantityTextBox.Location = New System.Drawing.Point(127, 124)
        Me.QuantityTextBox.Name = "QuantityTextBox"
        Me.QuantityTextBox.Size = New System.Drawing.Size(211, 27)
        Me.QuantityTextBox.TabIndex = 1
        Me.QuantityTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TotalDueTextBox
        '
        Me.TotalDueTextBox.Location = New System.Drawing.Point(127, 223)
        Me.TotalDueTextBox.Name = "TotalDueTextBox"
        Me.TotalDueTextBox.ReadOnly = True
        Me.TotalDueTextBox.Size = New System.Drawing.Size(211, 27)
        Me.TotalDueTextBox.TabIndex = 1
        Me.TotalDueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SalesTextBox
        '
        Me.SalesTextBox.Location = New System.Drawing.Point(127, 190)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.ReadOnly = True
        Me.SalesTextBox.Size = New System.Drawing.Size(211, 27)
        Me.SalesTextBox.TabIndex = 1
        Me.SalesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'SubtotalTextBox
        '
        Me.SubtotalTextBox.Location = New System.Drawing.Point(127, 157)
        Me.SubtotalTextBox.Name = "SubtotalTextBox"
        Me.SubtotalTextBox.ReadOnly = True
        Me.SubtotalTextBox.Size = New System.Drawing.Size(211, 27)
        Me.SubtotalTextBox.TabIndex = 1
        Me.SubtotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(127, 91)
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(211, 27)
        Me.PriceTextBox.TabIndex = 1
        Me.PriceTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'ISBNTextBox
        '
        Me.ISBNTextBox.Location = New System.Drawing.Point(127, 58)
        Me.ISBNTextBox.Name = "ISBNTextBox"
        Me.ISBNTextBox.Size = New System.Drawing.Size(257, 27)
        Me.ISBNTextBox.TabIndex = 1
        '
        'BookTitleTextBox
        '
        Me.BookTitleTextBox.Location = New System.Drawing.Point(127, 25)
        Me.BookTitleTextBox.Name = "BookTitleTextBox"
        Me.BookTitleTextBox.Size = New System.Drawing.Size(306, 27)
        Me.BookTitleTextBox.TabIndex = 1
        '
        'TotalDueLabel
        '
        Me.TotalDueLabel.AutoSize = True
        Me.TotalDueLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TotalDueLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TotalDueLabel.Location = New System.Drawing.Point(19, 222)
        Me.TotalDueLabel.Name = "TotalDueLabel"
        Me.TotalDueLabel.Size = New System.Drawing.Size(68, 17)
        Me.TotalDueLabel.TabIndex = 0
        Me.TotalDueLabel.Text = "Total Due"
        '
        'SalesLabel
        '
        Me.SalesLabel.AutoSize = True
        Me.SalesLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SalesLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SalesLabel.Location = New System.Drawing.Point(19, 191)
        Me.SalesLabel.Name = "SalesLabel"
        Me.SalesLabel.Size = New System.Drawing.Size(68, 17)
        Me.SalesLabel.TabIndex = 0
        Me.SalesLabel.Text = "Sales Tax "
        '
        'SubtotalLabel
        '
        Me.SubtotalLabel.AutoSize = True
        Me.SubtotalLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.SubtotalLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.SubtotalLabel.Location = New System.Drawing.Point(19, 160)
        Me.SubtotalLabel.Name = "SubtotalLabel"
        Me.SubtotalLabel.Size = New System.Drawing.Size(60, 17)
        Me.SubtotalLabel.TabIndex = 0
        Me.SubtotalLabel.Text = "Subtotal"
        '
        'QuantityLabel
        '
        Me.QuantityLabel.AutoSize = True
        Me.QuantityLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.QuantityLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.QuantityLabel.Location = New System.Drawing.Point(19, 129)
        Me.QuantityLabel.Name = "QuantityLabel"
        Me.QuantityLabel.Size = New System.Drawing.Size(62, 17)
        Me.QuantityLabel.TabIndex = 0
        Me.QuantityLabel.Text = "Quantity"
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PriceLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.PriceLabel.Location = New System.Drawing.Point(19, 98)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(38, 17)
        Me.PriceLabel.TabIndex = 0
        Me.PriceLabel.Text = "Price"
        '
        'ISBNLabel
        '
        Me.ISBNLabel.AutoSize = True
        Me.ISBNLabel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ISBNLabel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ISBNLabel.Location = New System.Drawing.Point(19, 67)
        Me.ISBNLabel.Name = "ISBNLabel"
        Me.ISBNLabel.Size = New System.Drawing.Size(104, 17)
        Me.ISBNLabel.TabIndex = 0
        Me.ISBNLabel.Text = "ISBN(Identifier)"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(19, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Book Title"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 450)
        Me.Controls.Add(Me.TextBookSaleInfoGroupBox)
        Me.Name = "Form1"
        Me.Text = "VB University - Book Store"
        Me.TextBookSaleInfoGroupBox.ResumeLayout(False)
        Me.TextBookSaleInfoGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBookSaleInfoGroupBox As GroupBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents TotalButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents QuantityTextBox As TextBox
    Friend WithEvents TotalDueTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents SubtotalTextBox As TextBox
    Friend WithEvents PriceTextBox As TextBox
    Friend WithEvents ISBNTextBox As TextBox
    Friend WithEvents BookTitleTextBox As TextBox
    Friend WithEvents TotalDueLabel As Label
    Friend WithEvents SalesLabel As Label
    Friend WithEvents SubtotalLabel As Label
    Friend WithEvents QuantityLabel As Label
    Friend WithEvents PriceLabel As Label
    Friend WithEvents ISBNLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComputeButton As Button
End Class
