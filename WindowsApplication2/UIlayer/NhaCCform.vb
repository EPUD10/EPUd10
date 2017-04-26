Imports BUS1
Imports DAO1
Imports DTO1



Public Class NhaCCform
    Dim con As New config
    Dim NCCBUS As New NhaCCBUS
    Dim NCC As New NhaCCDTO
    Private Sub NhaCCform_Load(sender As Object, e As EventArgs) Handles Me.Load
        dgvNhaCC.DataSource = NCCBUS.GetData

    End Sub


End Class
