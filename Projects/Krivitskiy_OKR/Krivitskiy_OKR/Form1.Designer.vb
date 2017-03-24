<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ВодохранилищаLabel As System.Windows.Forms.Label
        Dim РекаLabel As System.Windows.Forms.Label
        Dim Год_созданияLabel As System.Windows.Forms.Label
        Dim ПлощадьLabel As System.Windows.Forms.Label
        Dim ГлубинаLabel As System.Windows.Forms.Label
        Me.KrivitskiyDataSet = New Krivitskiy_OKR.KrivitskiyDataSet()
        Me.WaterResourcesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WaterResourcesTableAdapter = New Krivitskiy_OKR.KrivitskiyDataSetTableAdapters.WaterResourcesTableAdapter()
        Me.TableAdapterManager = New Krivitskiy_OKR.KrivitskiyDataSetTableAdapters.TableAdapterManager()
        Me.WaterResourcesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.WaterResourcesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ВодохранилищаTextBox = New System.Windows.Forms.TextBox()
        Me.РекаTextBox = New System.Windows.Forms.TextBox()
        Me.Год_созданияTextBox = New System.Windows.Forms.TextBox()
        Me.ПлощадьTextBox = New System.Windows.Forms.TextBox()
        Me.ГлубинаTextBox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        ВодохранилищаLabel = New System.Windows.Forms.Label()
        РекаLabel = New System.Windows.Forms.Label()
        Год_созданияLabel = New System.Windows.Forms.Label()
        ПлощадьLabel = New System.Windows.Forms.Label()
        ГлубинаLabel = New System.Windows.Forms.Label()
        CType(Me.KrivitskiyDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaterResourcesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WaterResourcesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WaterResourcesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'KrivitskiyDataSet
        '
        Me.KrivitskiyDataSet.DataSetName = "KrivitskiyDataSet"
        Me.KrivitskiyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WaterResourcesBindingSource
        '
        Me.WaterResourcesBindingSource.DataMember = "WaterResources"
        Me.WaterResourcesBindingSource.DataSource = Me.KrivitskiyDataSet
        '
        'WaterResourcesTableAdapter
        '
        Me.WaterResourcesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.UpdateOrder = Krivitskiy_OKR.KrivitskiyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.WaterResourcesTableAdapter = Me.WaterResourcesTableAdapter
        '
        'WaterResourcesBindingNavigator
        '
        Me.WaterResourcesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WaterResourcesBindingNavigator.BindingSource = Me.WaterResourcesBindingSource
        Me.WaterResourcesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WaterResourcesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WaterResourcesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WaterResourcesBindingNavigatorSaveItem})
        Me.WaterResourcesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.WaterResourcesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WaterResourcesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WaterResourcesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WaterResourcesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WaterResourcesBindingNavigator.Name = "WaterResourcesBindingNavigator"
        Me.WaterResourcesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WaterResourcesBindingNavigator.Size = New System.Drawing.Size(435, 25)
        Me.WaterResourcesBindingNavigator.TabIndex = 0
        Me.WaterResourcesBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 15)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 6)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'WaterResourcesBindingNavigatorSaveItem
        '
        Me.WaterResourcesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WaterResourcesBindingNavigatorSaveItem.Image = CType(resources.GetObject("WaterResourcesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WaterResourcesBindingNavigatorSaveItem.Name = "WaterResourcesBindingNavigatorSaveItem"
        Me.WaterResourcesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 23)
        Me.WaterResourcesBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'ВодохранилищаLabel
        '
        ВодохранилищаLabel.AutoSize = True
        ВодохранилищаLabel.Location = New System.Drawing.Point(20, 52)
        ВодохранилищаLabel.Name = "ВодохранилищаLabel"
        ВодохранилищаLabel.Size = New System.Drawing.Size(91, 13)
        ВодохранилищаLabel.TabIndex = 1
        ВодохранилищаLabel.Text = "Водохранилища:"
        '
        'ВодохранилищаTextBox
        '
        Me.ВодохранилищаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WaterResourcesBindingSource, "Водохранилища", True))
        Me.ВодохранилищаTextBox.Location = New System.Drawing.Point(117, 49)
        Me.ВодохранилищаTextBox.Name = "ВодохранилищаTextBox"
        Me.ВодохранилищаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ВодохранилищаTextBox.TabIndex = 2
        '
        'РекаLabel
        '
        РекаLabel.AutoSize = True
        РекаLabel.Location = New System.Drawing.Point(76, 95)
        РекаLabel.Name = "РекаLabel"
        РекаLabel.Size = New System.Drawing.Size(35, 13)
        РекаLabel.TabIndex = 3
        РекаLabel.Text = "Река:"
        '
        'РекаTextBox
        '
        Me.РекаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WaterResourcesBindingSource, "Река", True))
        Me.РекаTextBox.Location = New System.Drawing.Point(117, 92)
        Me.РекаTextBox.Name = "РекаTextBox"
        Me.РекаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.РекаTextBox.TabIndex = 4
        '
        'Год_созданияLabel
        '
        Год_созданияLabel.AutoSize = True
        Год_созданияLabel.Location = New System.Drawing.Point(32, 141)
        Год_созданияLabel.Name = "Год_созданияLabel"
        Год_созданияLabel.Size = New System.Drawing.Size(79, 13)
        Год_созданияLabel.TabIndex = 5
        Год_созданияLabel.Text = "Год создания:"
        '
        'Год_созданияTextBox
        '
        Me.Год_созданияTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WaterResourcesBindingSource, "Год создания", True))
        Me.Год_созданияTextBox.Location = New System.Drawing.Point(117, 138)
        Me.Год_созданияTextBox.Name = "Год_созданияTextBox"
        Me.Год_созданияTextBox.Size = New System.Drawing.Size(100, 20)
        Me.Год_созданияTextBox.TabIndex = 6
        '
        'ПлощадьLabel
        '
        ПлощадьLabel.AutoSize = True
        ПлощадьLabel.Location = New System.Drawing.Point(54, 188)
        ПлощадьLabel.Name = "ПлощадьLabel"
        ПлощадьLabel.Size = New System.Drawing.Size(57, 13)
        ПлощадьLabel.TabIndex = 7
        ПлощадьLabel.Text = "Площадь:"
        '
        'ПлощадьTextBox
        '
        Me.ПлощадьTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WaterResourcesBindingSource, "Площадь", True))
        Me.ПлощадьTextBox.Location = New System.Drawing.Point(117, 185)
        Me.ПлощадьTextBox.Name = "ПлощадьTextBox"
        Me.ПлощадьTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ПлощадьTextBox.TabIndex = 8
        '
        'ГлубинаLabel
        '
        ГлубинаLabel.AutoSize = True
        ГлубинаLabel.Location = New System.Drawing.Point(60, 238)
        ГлубинаLabel.Name = "ГлубинаLabel"
        ГлубинаLabel.Size = New System.Drawing.Size(51, 13)
        ГлубинаLabel.TabIndex = 9
        ГлубинаLabel.Text = "Глубина:"
        '
        'ГлубинаTextBox
        '
        Me.ГлубинаTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WaterResourcesBindingSource, "Глубина", True))
        Me.ГлубинаTextBox.Location = New System.Drawing.Point(117, 235)
        Me.ГлубинаTextBox.Name = "ГлубинаTextBox"
        Me.ГлубинаTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ГлубинаTextBox.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(217, 287)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(206, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Добавление конкретной записи"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(217, 325)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(206, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Удаление"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 371)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(ГлубинаLabel)
        Me.Controls.Add(Me.ГлубинаTextBox)
        Me.Controls.Add(ПлощадьLabel)
        Me.Controls.Add(Me.ПлощадьTextBox)
        Me.Controls.Add(Год_созданияLabel)
        Me.Controls.Add(Me.Год_созданияTextBox)
        Me.Controls.Add(РекаLabel)
        Me.Controls.Add(Me.РекаTextBox)
        Me.Controls.Add(ВодохранилищаLabel)
        Me.Controls.Add(Me.ВодохранилищаTextBox)
        Me.Controls.Add(Me.WaterResourcesBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.KrivitskiyDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaterResourcesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WaterResourcesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WaterResourcesBindingNavigator.ResumeLayout(False)
        Me.WaterResourcesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents KrivitskiyDataSet As KrivitskiyDataSet
    Friend WithEvents WaterResourcesBindingSource As BindingSource
    Friend WithEvents WaterResourcesTableAdapter As KrivitskiyDataSetTableAdapters.WaterResourcesTableAdapter
    Friend WithEvents TableAdapterManager As KrivitskiyDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WaterResourcesBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents WaterResourcesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ВодохранилищаTextBox As TextBox
    Friend WithEvents РекаTextBox As TextBox
    Friend WithEvents Год_созданияTextBox As TextBox
    Friend WithEvents ПлощадьTextBox As TextBox
    Friend WithEvents ГлубинаTextBox As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
