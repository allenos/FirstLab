''' <summary>
''' Fuel Efficency Converter
''' frmFuelEfficiencyConvert.vb
''' Chris Lu, Zack Shealy, Oliver Allen
''' 29 Jan 2013
''' A program to convert MPG to KPL
''' </summary>
''' <remarks></remarks>
Public Class frmfuelefficiencyconverter
    ''' <summary>
    ''' When the user clicks this button the program will calculate the KPL based on the MPG that was entered
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnconvert_Click(sender As Object, e As EventArgs) Handles btnconvert.Click
        'create constants for our conversion values
        Const decKPM As Decimal = 1.61 ' kilometers per mile
        Const decGPL As Decimal = 0.264 ' gallons per liter

        'create variables to hold the MPG and KPL values
        Dim decMPG, decKPL As Decimal

        'get the MPG value that the user entered on the form
        Try
            decMPG = CDec(txtmpg.Text)
        Catch ex As Exception
            MessageBox.Show("The MPG value must be numeric. Please do not enter a non-numerical value")
            txtmpg.Clear()
            txtkpl.Clear()
            txtmpg.Focus()
            Return
        End Try

        'calculate the KPL based on the MPG value and the constant
        decKPL = decMPG * decKPM * decGPL

        'output the results back to the form
        txtkpl.Text = decKPL.ToString

        'This code was borrowed from Professor Benton's "The Programming Process" Video
    End Sub
End Class
