Imports System.Linq
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports Microsoft.Office.Core
Imports excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data
Imports System.Xml

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub txtBoxNmbOfRows_TextChanged(sender As Object, e As EventArgs) Handles txtBoxNmbOfRows.TextChanged

    End Sub

    Private Sub txtBoxNmbOfRows_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBoxNmbOfRows.KeyPress
        If Not ((e.KeyChar >= "0" And e.KeyChar <= "9") Or e.KeyChar = vbBack Or e.KeyChar = "+") Then
            MessageBox.Show("Invalid Input! Numbers Only.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            e.Handled = True
        End If
    End Sub

    Private Sub btnCreateData_Click(sender As Object, e As EventArgs) Handles btnCreateData.Click
        If txtBoxNmbOfRows.Text = "" Then
            MessageBox.Show("Number of Row cannot be empty !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        btnCreateData.Text = "Please Wait..."
        btnCreateData.Enabled = False

        For i As Integer = 1 To txtBoxNmbOfRows.Text
            With DataGridView1.Rows
                .Add(i, "User " & i, "Indonesia", "Medan", "061-" & i)
            End With
        Next

        btnCreateData.Text = "Make Data"
        btnCreateData.Enabled = True
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Try
            btnExport.Text = "Please Wait..."
            btnExport.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("Ark1")

                For i = 0 To DataGridView1.RowCount - 2
                    For j = 0 To DataGridView1.ColumnCount - 1
                        For k As Integer = 1 To DataGridView1.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)

                MsgBox("Successfully saved" & vbCrLf & "File are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information, "Information")

                btnExport.Text = "Export To MS Excel"
                btnExport.Enabled = True
            End If
        Catch ex As Exception
            MessageBox.Show("Failed to save !!!", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DataGridView1.Columns.Clear()
        If DataGridView1.Columns.Count = 0 Then
            With DataGridView1
                .Columns.Clear()
                .Columns.Add("No", "No")
                .Columns.Add("Name_User", "Name_User")
                .Columns.Add("Country", "Country")
                .Columns.Add("City", "City")
                .Columns.Add("Phone_Number", "Phone_Number")
            End With
        End If
        DataGridView1.DataSource = Nothing
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        Dim conn As OleDbConnection
        Dim dtr As OleDbDataReader
        Dim dta As OleDbDataAdapter
        Dim cmd As OleDbCommand
        Dim dts As DataSet
        Dim excel As String
        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog1.FileName = ""
        OpenFileDialog1.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.Desktop
        OpenFileDialog1.Filter = "All Files (*.*)|*.*|Excel files (*.xlsx)|*.xlsx|CSV Files (*.csv)|*.csv|XLS Files (*.xls)|*xls"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            DataGridView1.Columns.Clear()

            Dim fi As New FileInfo(OpenFileDialog1.FileName)
            Dim FileName As String = OpenFileDialog1.FileName

            excel = fi.FullName
            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + excel + ";Extended Properties=Excel 12.0;")
            dta = New OleDbDataAdapter("Select * From [Ark1$]", conn)
            dts = New DataSet
            dta.Fill(dts, "[Ark1$]")
            DataGridView1.DataSource = dts
            DataGridView1.DataMember = "[Ark1$]"
            conn.Close()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class


