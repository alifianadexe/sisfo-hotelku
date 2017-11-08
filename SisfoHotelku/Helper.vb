Module Helper
    Dim conn As New SqlClient.SqlConnection
    Dim rd As SqlClient.SqlDataReader


    Public Function generateConnString()
        Dim server As String = "localhost"
        Dim connString As String = "Data Source=" + server + ",1433;Network Library=DBMSSOCN;Initial Catalog=db_hotel;user id=alifianadexe;password=adexe123"
        Try
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = connString
                conn.Open()
                conn.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return connString
    End Function

    Public Function generateID(ByVal what As String, ByVal conn As SqlClient.SqlConnection)
        Dim id As String = ""
        Select Case what
            Case "id_reservation"
                Dim sql As String = "SELECT * FROM tbl_reservation ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "2017001"
                Else
                    id = Val(rd.Item(0)) + 1
                End If

                rd.Close()
            Case "id_client"
                Dim sql As String = "SELECT * FROM tbl_client ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "CLN001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "CLN00" + id
                    ElseIf Len(id) = 2 Then
                        id = "CLN0" + id
                    ElseIf Len(id) = 3 Then
                        id = "CLN" + id
                    End If
                End If
                rd.Close()

            Case "id_room"
                Dim sql As String = "SELECT * FROM tbl_room ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "101"
                Else
                    id = Val(rd.Item(0)) + 1
                End If

                rd.Close()
            Case "id_invoice"
                Dim sql As String = "SELECT * FROM tbl_invoice ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "INV001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "INV00" + id
                    ElseIf Len(id) = 2 Then
                        id = "INV0" + id
                    ElseIf Len(id) = 3 Then
                        id = "INV" + id
                    End If
                End If
                rd.Close()

            Case "id_tagihan"
                Dim sql As String = "SELECT * FROM tbl_tagihan ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "2200001"
                Else
                    id = Val(rd.Item(0)) + 1
                End If
                rd.Close()

            Case "id_room_history"
                Dim sql As String = "SELECT * FROM tbl_room_history ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "RHO001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "RHO00" + id
                    ElseIf Len(id) = 2 Then
                        id = "RHO0" + id
                    ElseIf Len(id) = 3 Then
                        id = "RHO" + id
                    End If
                End If
                rd.Close()

            Case "id_hotel"
                Dim sql As String = "SELECT * FROM tbl_hotel ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "HTL001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "HTL00" + id
                    ElseIf Len(id) = 2 Then
                        id = "HTL0" + id
                    ElseIf Len(id) = 3 Then
                        id = "HTL" + id
                    End If
                End If
                rd.Close()

            Case "id_room_damaged"
                Dim sql As String = "SELECT * FROM tbl_room_damaged ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "RDG001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "RDG00" + id
                    ElseIf Len(id) = 2 Then
                        id = "RDG0" + id
                    ElseIf Len(id) = 3 Then
                        id = "RDG" + id
                    End If
                End If
                rd.Close()

            Case "id_petugas"
                Dim sql As String = "SELECT * FROM tbl_petugas ORDER BY " + what + " DESC"
                Dim cmnd As New SqlClient.SqlCommand(sql, conn)
                rd = cmnd.ExecuteReader
                rd.Read()

                If Not rd.HasRows Then
                    id = "PTG001"
                Else
                    id = Val(Mid(rd.Item(0), 4, 3)) + 1
                    If Len(id) = 1 Then
                        id = "PTG00" + id
                    ElseIf Len(id) = 2 Then
                        id = "PTG0" + id
                    ElseIf Len(id) = 3 Then
                        id = "PTG" + id
                    End If
                End If
                rd.Close()

        End Select


        Return id
    End Function

    Public Function cekEmptyTextbox(ByVal ParamArray obj() As Object) As Boolean
        Dim bool As Boolean = True
        For i As Integer = 0 To UBound(obj)
            If obj(i).Text = "" Then
                MessageBox.Show("Isi semua kolom yang kosong!", "Warn", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
                bool = False
            End If
        Next
        Return bool
    End Function
End Module
