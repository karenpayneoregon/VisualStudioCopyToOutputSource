Imports WorkingWithLocalAccessDatabase.Classes

Public Class Form1
    Property CustomerBindingSource() As New BindingSource
    ''' <summary>
    ''' Get record count if database exists
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CustomerRecordCountButton_Click(sender As Object, e As EventArgs) Handles CustomerRecordCountButton.Click
        Dim ops = New DataOperations
        If ops.DatabaseExistsInDebugFolder() Then
            MessageBox.Show($"Current record count {ops.CustomerRecordCount()}")
        Else
            My.Dialogs.InformationDialog("Database currently does not reside in debug folder", "Note")
        End If
    End Sub
    ''' <summary>
    ''' Add records to the database table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AddRecordsButton_Click(sender As Object, e As EventArgs) Handles AddRecordsButton.Click
        Dim ops = New DataOperations
        If Not ops.DatabaseExistsInDebugFolder() Then
            Exit Sub
        End If

        Dim mockedList As New CustomerData
        Dim newCustomersInDatabase = mockedList.CustomerList()

        ops.AddNewCustomerRecords(newCustomersInDatabase)

        If ops.IsSuccessFul Then
            CustomerBindingSource.DataSource = ops.ReadCustomerTable
            DataGridView1.DataSource = CustomerBindingSource

            SetIdentifierColumnReadOnly()

        End If

    End Sub
    ''' <summary>
    ''' If database exists load any records in the customer table
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ops = New DataOperations
        If ops.DatabaseExistsInDebugFolder() Then
            CustomerBindingSource.DataSource = ops.ReadCustomerTable
            DataGridView1.DataSource = customerBindingSource
            SetIdentifierColumnReadOnly()
        End If
    End Sub
    ''' <summary>
    ''' Remove current row in DataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RemoveCurrentButton_Click(sender As Object, e As EventArgs) Handles RemoveCurrentButton.Click
        If customerBindingSource.DataSource IsNot Nothing AndAlso customerBindingSource.Current IsNot Nothing Then
            Dim ops = New DataOperations
            If ops.RemoveRecord(CType(customerBindingSource.Current, Customer).Id) Then
                customerBindingSource.RemoveCurrent()
            End If
        End If
    End Sub
    ''' <summary>
    ''' Do not permit editing primary key
    ''' </summary>
    Private Sub SetIdentifierColumnReadOnly()
        If DataGridView1.Columns.Contains("id") Then
            DataGridView1.Columns("id").ReadOnly = True
        End If
    End Sub
End Class