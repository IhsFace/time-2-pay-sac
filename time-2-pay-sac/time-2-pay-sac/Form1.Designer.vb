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
        lblTitle = New Label()
        lblEmployeeName = New Label()
        lblDepartment = New Label()
        lblHoursWorked = New Label()
        lblHourlyPayRate = New Label()
        txtEmployeeName = New TextBox()
        txtDepartment = New TextBox()
        txtHoursWorked = New TextBox()
        txtHourlyPayRate = New TextBox()
        btnAdd = New Button()
        btnDisplayAll = New Button()
        btnPayReport = New Button()
        btnSearch = New Button()
        btnClear = New Button()
        lstDisplay = New ListBox()
        SuspendLayout()
        ' 
        ' lblTitle
        ' 
        lblTitle.AutoSize = True
        lblTitle.Font = New Font("Arial", 16.125F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTitle.Location = New Point(176, 27)
        lblTitle.Name = "lblTitle"
        lblTitle.Size = New Size(476, 51)
        lblTitle.TabIndex = 0
        lblTitle.Text = "PlantsRUs - Time2Pay"
        ' 
        ' lblEmployeeName
        ' 
        lblEmployeeName.AutoSize = True
        lblEmployeeName.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEmployeeName.Location = New Point(60, 131)
        lblEmployeeName.Name = "lblEmployeeName"
        lblEmployeeName.Size = New Size(246, 36)
        lblEmployeeName.TabIndex = 1
        lblEmployeeName.Text = "Employee Name"
        ' 
        ' lblDepartment
        ' 
        lblDepartment.AutoSize = True
        lblDepartment.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblDepartment.Location = New Point(60, 207)
        lblDepartment.Name = "lblDepartment"
        lblDepartment.Size = New Size(180, 36)
        lblDepartment.TabIndex = 2
        lblDepartment.Text = "Department"
        ' 
        ' lblHoursWorked
        ' 
        lblHoursWorked.AutoSize = True
        lblHoursWorked.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHoursWorked.Location = New Point(60, 300)
        lblHoursWorked.Name = "lblHoursWorked"
        lblHoursWorked.Size = New Size(376, 36)
        lblHoursWorked.TabIndex = 3
        lblHoursWorked.Text = "Hours Worked This Week"
        ' 
        ' lblHourlyPayRate
        ' 
        lblHourlyPayRate.AutoSize = True
        lblHourlyPayRate.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHourlyPayRate.Location = New Point(60, 375)
        lblHourlyPayRate.Name = "lblHourlyPayRate"
        lblHourlyPayRate.Size = New Size(243, 36)
        lblHourlyPayRate.TabIndex = 4
        lblHourlyPayRate.Text = "Hourly Pay Rate"
        ' 
        ' txtEmployeeName
        ' 
        txtEmployeeName.Location = New Point(319, 128)
        txtEmployeeName.Name = "txtEmployeeName"
        txtEmployeeName.Size = New Size(374, 39)
        txtEmployeeName.TabIndex = 5
        ' 
        ' txtDepartment
        ' 
        txtDepartment.Location = New Point(319, 204)
        txtDepartment.Name = "txtDepartment"
        txtDepartment.Size = New Size(374, 39)
        txtDepartment.TabIndex = 6
        ' 
        ' txtHoursWorked
        ' 
        txtHoursWorked.Location = New Point(445, 297)
        txtHoursWorked.Name = "txtHoursWorked"
        txtHoursWorked.Size = New Size(248, 39)
        txtHoursWorked.TabIndex = 7
        ' 
        ' txtHourlyPayRate
        ' 
        txtHourlyPayRate.Location = New Point(445, 375)
        txtHourlyPayRate.Name = "txtHourlyPayRate"
        txtHourlyPayRate.Size = New Size(248, 39)
        txtHourlyPayRate.TabIndex = 8
        ' 
        ' btnAdd
        ' 
        btnAdd.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnAdd.Location = New Point(60, 471)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(150, 75)
        btnAdd.TabIndex = 9
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnDisplayAll
        ' 
        btnDisplayAll.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnDisplayAll.Location = New Point(216, 471)
        btnDisplayAll.Name = "btnDisplayAll"
        btnDisplayAll.Size = New Size(150, 75)
        btnDisplayAll.TabIndex = 10
        btnDisplayAll.Text = "Display All"
        btnDisplayAll.UseVisualStyleBackColor = True
        ' 
        ' btnPayReport
        ' 
        btnPayReport.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnPayReport.Location = New Point(387, 471)
        btnPayReport.Name = "btnPayReport"
        btnPayReport.Size = New Size(150, 75)
        btnPayReport.TabIndex = 11
        btnPayReport.Text = "Pay Report"
        btnPayReport.UseVisualStyleBackColor = True
        ' 
        ' btnSearch
        ' 
        btnSearch.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(543, 471)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(150, 75)
        btnSearch.TabIndex = 12
        btnSearch.Text = "Search"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Font = New Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnClear.Location = New Point(319, 871)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(150, 46)
        btnClear.TabIndex = 13
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' lstDisplay
        ' 
        lstDisplay.BackColor = Color.Honeydew
        lstDisplay.Font = New Font("Arial", 8F)
        lstDisplay.FormattingEnabled = True
        lstDisplay.ItemHeight = 24
        lstDisplay.Location = New Point(12, 573)
        lstDisplay.Name = "lstDisplay"
        lstDisplay.Size = New Size(750, 268)
        lstDisplay.TabIndex = 14
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(13F, 32F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.PaleGreen
        ClientSize = New Size(774, 929)
        Controls.Add(lstDisplay)
        Controls.Add(btnClear)
        Controls.Add(btnSearch)
        Controls.Add(btnPayReport)
        Controls.Add(btnDisplayAll)
        Controls.Add(btnAdd)
        Controls.Add(txtHourlyPayRate)
        Controls.Add(txtHoursWorked)
        Controls.Add(txtDepartment)
        Controls.Add(txtEmployeeName)
        Controls.Add(lblHourlyPayRate)
        Controls.Add(lblHoursWorked)
        Controls.Add(lblDepartment)
        Controls.Add(lblEmployeeName)
        Controls.Add(lblTitle)
        Name = "Form1"
        Text = "Time2Pay"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblEmployeeName As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblHoursWorked As Label
    Friend WithEvents lblHourlyPayRate As Label
    Friend WithEvents txtEmployeeName As TextBox
    Friend WithEvents txtDepartment As TextBox
    Friend WithEvents txtHoursWorked As TextBox
    Friend WithEvents txtHourlyPayRate As TextBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDisplayAll As Button
    Friend WithEvents btnPayReport As Button
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lstDisplay As ListBox

End Class
