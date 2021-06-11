Imports System.Data.OleDb

Module Module1
    Public cmd As OleDbCommand
    Public conn As OleDbConnection
    Public rd As OleDbDataReader

    Sub koneksi()
        conn = New OleDbConnection("provider=microsoft.ACE.oledb.12.0;data source=" & Application.StartupPath & "\db_penjualan.accdb")
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If

        'MessageBox.Show("Koneksi Berhasil")
    End Sub

End Module
