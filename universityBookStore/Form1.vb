'Project Name: Tax Calculator
'Poject Owner : Cals
'Project Date: 2nd August 2023
'Last Update: 2nd August 2023 11:00 am

Public Class Form1

    'Declare module-level variables and constants
    Private TotalQuantityInteger As Integer
    Private TotalSalesDecimal As Decimal


    Private Sub ButtonCompute_Click(sender As Object, e As EventArgs) Handles ComputeButton.Click
        Try
            'Input
            'Declare constants
            '7.25 percent sales tax rate
            Const SALES_TAX_RATE_SINGLE As Single = 0.0725

            'Declare variables
            Dim PriceDecimal As Decimal
            Dim QuantityInteger As Decimal
            Dim SubTotalDecimal As Decimal
            Dim SalesTaxDecimal As Decimal
            Dim TotalDueDecimal As Decimal

            'Declare variables and convert values from textbox controls to memory
            PriceDecimal = Decimal.Parse(PriceTextBox.Text, Globalization.NumberStyles.Currency)
            QuantityInteger = Integer.Parse(QuantityTextBox.Text,
                                            Globalization.NumberStyles.Number)





            'Process - Compute values
            'Subtotal = price times the quantity of books
            SubTotalDecimal = PriceDecimal * QuantityInteger

            'Sales tax = sales tax rate times the subtotal minus discount amount 
            SalesTaxDecimal = Decimal.Round(Convert.ToDecimal(SubTotalDecimal *
                                                              SALES_TAX_RATE_SINGLE), 2)


            'Total due is the subtotal minus discount amount plus sales tax
            TotalDueDecimal = SubTotalDecimal + SalesTaxDecimal

            'Output - display output formatted as currency
            SubtotalTextBox.Text = SubTotalDecimal.ToString("C")
            SalesTextBox.Text = SalesTaxDecimal.ToString("N")
            TotalDueTextBox.Text = TotalDueDecimal.ToString("C")

            'Enable/Disable buttons
            ComputeButton.Enabled = False
            ResetButton.Enabled = True

            'Accumulate total sales and total books sold.
            TotalQuantityInteger += QuantityInteger
            TotalSalesDecimal += TotalDueDecimal


            'ComputeButton.Enabled = False
            'ResetButton.Enabled= True

        Catch ex As Exception
            MessageBox.Show("You typed a wrong data type into either Price or Quantity",
                            "Price/Quantity Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            PriceTextBox.Focus()


        End Try

    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        'Clear all TextBox controls


        BookTitleTextBox.Clear()
        ISBNTextBox.Clear()
        PriceTextBox.Clear()
        QuantityTextBox.Clear()
        SubtotalTextBox.Clear()
        SalesTextBox.Clear()
        TotalDueTextBox.Clear()


        'Enable/disable buttons
        ComputeButton.Enabled = True
        ResetButton.Enabled = False

        'Set focus to the BookTitleTextBox
        BookTitleTextBox.Focus()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'Close the App
        Me.Close()
    End Sub

    Private Sub TotalButton_Click(sender As Object, e As EventArgs) Handles TotalButton.Click
        Try
            'Display the total sales, total books sold, 
            'and average book value in a message box.

            Dim AverageSaleDecimal As Decimal = TotalSalesDecimal / TotalQuantityInteger

            Dim MessageString As String = "Book title: " & BookTitleTextBox.Text _
            & ControlChars.NewLine _
                & "ISBN: " & ISBNTextBox.Text & "TotalSales: " _
                & TotalSalesDecimal.ToString("C") & ControlChars.NewLine _
                & "Total Books Sold: " _
                & TotalQuantityInteger.ToString("N0") & ControlChars.NewLine _
                & "Average Book Value: " & AverageSaleDecimal.ToString("C")

            MessageBox.Show(MessageString, "Totals and Averages",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

        Catch exArithmeticException As ArithmeticException
            MessageBox.Show("No books have been sold yet",
                            "Zero Sales Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Unexpected Error-inform the system administrator",
                            "Unknown Error in Totals Button",
                            MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
End Class
