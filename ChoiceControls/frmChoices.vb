Public Class frmChoices

    Private Sub LoadComboBoxChoices()
        cboSaleItems.Items.Add("Long sleeve shirt")
        cboSaleItems.Items.Add("Short sleeve shirt")
        cboSaleItems.Items.Add("Lightweight jacket")
    End Sub

    Private Sub frmChoices_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadComboBoxChoices()
    End Sub

    Private Sub cboSaleItems_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSaleItems.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
