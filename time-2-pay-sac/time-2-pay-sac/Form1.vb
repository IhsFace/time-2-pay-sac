Imports System.IO

Public Class Form1
    Dim blnItemsValid As Boolean = True

    Sub Display()
        Dim strEmployeeName() As String
        Dim strDepartment() As String
        Dim strHoursWorked() As String
        Dim strHourlyPayRate() As String
        Dim Time2PayDataFile As StreamReader = File.OpenText("Time2PayData.txt")
        Dim intItemCounter As Integer

        lstDisplay.Items.Clear()

        Do While Time2PayDataFile.Peek <> -1
            Time2PayDataFile.ReadLine()
            Time2PayDataFile.ReadLine()
            Time2PayDataFile.ReadLine()
            Time2PayDataFile.ReadLine()
            intItemCounter = intItemCounter + 1
        Loop

        Time2PayDataFile.Close()

        ReDim strEmployeeName(intItemCounter - 1)
        ReDim strDepartment(intItemCounter - 1)
        ReDim strHoursWorked(intItemCounter - 1)
        ReDim strHourlyPayRate(intItemCounter - 1)
        Dim Time2PayDataFile2 As StreamReader = File.OpenText("Time2PayData.txt")

        For i = 0 To intItemCounter - 1
            strEmployeeName(i) = Time2PayDataFile2.ReadLine()
            strDepartment(i) = Time2PayDataFile2.ReadLine()
            strHoursWorked(i) = Time2PayDataFile2.ReadLine()
            strHourlyPayRate(i) = Time2PayDataFile2.ReadLine()
            lstDisplay.Items.Add("Employee Name: " & strEmployeeName(i))
            lstDisplay.Items.Add("Department: " & strDepartment(i))
            lstDisplay.Items.Add("Hours Worked: " & strHoursWorked(i))
            lstDisplay.Items.Add("Hourly Pay Rate: " & FormatCurrency(strHourlyPayRate(i)))
        Next

        Time2PayDataFile2.Close()
    End Sub

    Sub DoValidation()
        If String.IsNullOrEmpty(txtEmployeeName.Text) Then
            MessageBox.Show("Please enter an employee name.")
            blnItemsValid = False
            txtEmployeeName.Focus()
            Return
        ElseIf IsNumeric(txtEmployeeName.Text) = True Then
            MessageBox.Show("The employee name should not include numbers.")
            blnItemsValid = False
            txtEmployeeName.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtDepartment.Text) Then
            MessageBox.Show("Please enter a department name.")
            blnItemsValid = False
            txtDepartment.Focus()
            Return
        ElseIf IsNumeric(txtDepartment.Text) = True Then
            MessageBox.Show("The department name should not include numbers.")
            blnItemsValid = False
            txtDepartment.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtHoursWorked.Text) Then
            MessageBox.Show("Please enter the amount of hours worked.")
            blnItemsValid = False
            txtHoursWorked.Focus()
            Return
        ElseIf IsNumeric(txtHoursWorked.Text) = False Then
            MessageBox.Show("The amount of hours worked should only include numbers.")
            blnItemsValid = False
            txtHoursWorked.Focus()
            Return
        ElseIf Val(txtHoursWorked.Text) < 1 Then
            MessageBox.Show("The amount of hours worked should not be less than 1 hour.")
            blnItemsValid = False
            txtHoursWorked.Focus()
            Return
        ElseIf Val(txtHoursWorked.Text) > 60 Then
            MessageBox.Show("The amount of hours worked should not be greater than 60 hours.")
            blnItemsValid = False
            txtHoursWorked.Focus()
            Return
        ElseIf String.IsNullOrEmpty(txtHourlyPayRate.Text) Then
            MessageBox.Show("Please enter the hourly pay rate.")
            blnItemsValid = False
            txtHourlyPayRate.Focus()
            Return
        ElseIf IsNumeric(txtHourlyPayRate.Text) = False Then
            MessageBox.Show("The hourly pay rate should only include numbers.")
            blnItemsValid = False
            txtHourlyPayRate.Focus()
            Return
        ElseIf Val(txtHourlyPayRate.Text) < 20 Then
            MessageBox.Show("The hourly pay rate should not be less than $20.00.")
            blnItemsValid = False
            txtHourlyPayRate.Focus()
            Return
        ElseIf Val(txtHourlyPayRate.Text) > 100 Then
            MessageBox.Show("The hourly pay rate should not be greater than $100.00.")
            blnItemsValid = False
            txtHourlyPayRate.Focus()
            Return
        Else
            blnItemsValid = True
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        DoValidation()

        If blnItemsValid Then
            Dim strEmployeeName As String
            Dim strDepartment As String
            Dim dblHoursWorked As Double
            Dim dblHourlyPayRate As Double
            Dim Time2PayDataFile As StreamWriter = File.AppendText("Time2PayData.txt")

            strEmployeeName = txtEmployeeName.Text
            strDepartment = txtDepartment.Text
            dblHoursWorked = txtHoursWorked.Text
            dblHourlyPayRate = txtHourlyPayRate.Text
            Time2PayDataFile.WriteLine(strEmployeeName)
            Time2PayDataFile.WriteLine(strDepartment)
            Time2PayDataFile.WriteLine(dblHoursWorked)
            Time2PayDataFile.WriteLine(dblHourlyPayRate)

            MessageBox.Show("Employee details have been successfully added to the textfile.")
            Time2PayDataFile.Close()
            Display()
        End If
    End Sub

    Private Sub btnDisplayAll_Click(sender As Object, e As EventArgs) Handles btnDisplayAll.Click
        Display()
    End Sub

    Private Sub btnPayReport_Click(sender As Object, e As EventArgs) Handles btnPayReport.Click
        Dim strEmployeeName As String
        Dim strDepartment As String
        Dim strHoursWorked As Double
        Dim strHourlyPayRate As Double
        Dim dblTotalAmountDue As Double
        Dim dblTotalOverallPay As Double
        Dim dblTotalFinancePay As Double
        Dim dblTotalSalesPay As Double
        Dim dblTotalTechnologyPay As Double
        Dim dblTotalLegalPay As Double
        Dim dblTotalMarketingPay As Double
        Dim dblHighestPay As Double
        Dim strEmployeeHighestPay As String
        Dim Time2PayDataFile As StreamReader = File.OpenText("Time2PayData.txt")

        lstDisplay.Items.Clear()

        Do While Time2PayDataFile.Peek <> -1
            strEmployeeName = Time2PayDataFile.ReadLine()
            strDepartment = Time2PayDataFile.ReadLine()
            strHoursWorked = Time2PayDataFile.ReadLine()
            strHourlyPayRate = Time2PayDataFile.ReadLine()

            dblTotalAmountDue = Val(strHoursWorked) * Val(strHourlyPayRate)
            dblTotalOverallPay = dblTotalOverallPay + dblTotalAmountDue

            Select Case strDepartment
                Case "Finance"
                    dblTotalFinancePay = dblTotalFinancePay + dblTotalAmountDue
                Case "Sales"
                    dblTotalSalesPay = dblTotalSalesPay + dblTotalAmountDue
                Case "Technology"
                    dblTotalTechnologyPay = dblTotalTechnologyPay + dblTotalAmountDue
                Case "Legal"
                    dblTotalLegalPay = dblTotalLegalPay + dblTotalAmountDue
                Case "Marketing"
                    dblTotalMarketingPay = dblTotalMarketingPay + dblTotalAmountDue
            End Select

            If dblHighestPay < dblTotalAmountDue Then
                dblHighestPay = dblTotalAmountDue
                strEmployeeHighestPay = strEmployeeName
            End If

            lstDisplay.Items.Add("Employee Name: " & strEmployeeName & ", Pay Amount: " & FormatCurrency(dblTotalAmountDue))
        Loop

        lstDisplay.Items.Add("Overall Total Pay: " & FormatCurrency(dblTotalOverallPay))
        lstDisplay.Items.Add("Finance Department Total Pay: " & FormatCurrency(dblTotalFinancePay))
        lstDisplay.Items.Add("Sales Department Total Pay: " & FormatCurrency(dblTotalSalesPay))
        lstDisplay.Items.Add("Technology Department Total Pay: " & FormatCurrency(dblTotalTechnologyPay))
        lstDisplay.Items.Add("Legal Department Total Pay: " & FormatCurrency(dblTotalLegalPay))
        lstDisplay.Items.Add("Marketing Department Total Pay: " & FormatCurrency(dblTotalMarketingPay))
        lstDisplay.Items.Add("Employee with Highest Pay Name: " & strEmployeeHighestPay & ", Pay Amount: " & FormatCurrency(dblHighestPay))
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If String.IsNullOrEmpty(txtEmployeeName.Text) Then
            MessageBox.Show("Please enter an employee name.")
            blnItemsValid = False
            txtEmployeeName.Focus()
            Return
        ElseIf IsNumeric(txtEmployeeName.Text) = True Then
            MessageBox.Show("The employee name should not include numbers.")
            blnItemsValid = False
            txtEmployeeName.Focus()
            Return
        End If

        lstDisplay.Items.Clear()

        Dim strEmployeeName As String
        Dim strDepartment As String
        Dim strHoursWorked As String
        Dim strHourlyPayRate As String
        Dim strEmployeeDisplay As String = txtEmployeeName.Text
        Dim Time2PayDataFile As StreamReader = File.OpenText("Time2PayData.txt")

        Do While Time2PayDataFile.Peek <> -1
            strEmployeeName = Time2PayDataFile.ReadLine()
            strDepartment = Time2PayDataFile.ReadLine()
            strHoursWorked = Time2PayDataFile.ReadLine()
            strHourlyPayRate = Time2PayDataFile.ReadLine()

            If strEmployeeName.Contains(strEmployeeDisplay) = True Then
                lstDisplay.Items.Add("Employee Name: " & strEmployeeName)
                lstDisplay.Items.Add("Department: " & strDepartment)
                lstDisplay.Items.Add("Hours Worked: " & strHoursWorked)
                lstDisplay.Items.Add("Hourly Pay Rate: " & FormatCurrency(strHourlyPayRate))
                Return
            End If
        Loop

        If lstDisplay.Items.Count < 1 Then
            MessageBox.Show("We do not employ this person.")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstDisplay.Items.Clear()
        txtEmployeeName.Clear()
        txtDepartment.Clear()
        txtHoursWorked.Clear()
        txtHourlyPayRate.Clear()
    End Sub
End Class
