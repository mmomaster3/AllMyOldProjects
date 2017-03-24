Public Class Client
    Private Sub ClientBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ClientBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AssemblePcDataSet)

    End Sub

    Private Sub Client_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Client". При необходимости она может быть перемещена или удалена.
        Me.ClientTableAdapter.Fill(Me.AssemblePcDataSet.Client)

    End Sub
End Class