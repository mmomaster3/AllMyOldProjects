Public Class Form1
    Private Sub WaterResourcesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.WaterResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KrivitskiyDataSet)

    End Sub

    Private Sub WaterResourcesBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles WaterResourcesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.WaterResourcesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.KrivitskiyDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "KrivitskiyDataSet.WaterResources". При необходимости она может быть перемещена или удалена.
        Me.WaterResourcesTableAdapter.Fill(Me.KrivitskiyDataSet.WaterResources)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        WaterResourcesBindingSource.AddNew()
        РекаTextBox.Text = "Друзь"
        ПлощадьTextBox.Text = 26
        Год_созданияTextBox.Text = 1960
        ГлубинаTextBox.Text = 8
        WaterResourcesBindingSource.Insert()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ВодохранилищаTextBox.Text = "Зельвеньское" Then
            ВодохранилищаTextBox.Text = ""
        End If
    End Sub
End Class
