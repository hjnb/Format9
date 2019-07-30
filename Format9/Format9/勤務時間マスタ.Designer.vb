<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 勤務時間マスタ
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.wNamBox = New System.Windows.Forms.TextBox()
        Me.dgvTimeM = New System.Windows.Forms.DataGridView()
        Me.btnRegist = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.dayTimeBox = New hmBox.hmBox()
        Me.nightTimeBox = New hmBox.hmBox()
        Me.nextTimeBox = New hmBox.hmBox()
        Me.emptyCheckDay = New System.Windows.Forms.CheckBox()
        Me.emptyCheckNight = New System.Windows.Forms.CheckBox()
        Me.emptyCheckNext = New System.Windows.Forms.CheckBox()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvTimeM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(39, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "勤務名称"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "日勤帯時間"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label3.Location = New System.Drawing.Point(39, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "夜間帯時間"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label4.Location = New System.Drawing.Point(39, 179)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "日跨ぎ時間"
        '
        'wNamBox
        '
        Me.wNamBox.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.wNamBox.Location = New System.Drawing.Point(152, 22)
        Me.wNamBox.Name = "wNamBox"
        Me.wNamBox.Size = New System.Drawing.Size(110, 23)
        Me.wNamBox.TabIndex = 4
        '
        'dgvTimeM
        '
        Me.dgvTimeM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTimeM.Location = New System.Drawing.Point(42, 220)
        Me.dgvTimeM.Name = "dgvTimeM"
        Me.dgvTimeM.RowTemplate.Height = 21
        Me.dgvTimeM.Size = New System.Drawing.Size(357, 355)
        Me.dgvTimeM.TabIndex = 10
        '
        'btnRegist
        '
        Me.btnRegist.Location = New System.Drawing.Point(324, 137)
        Me.btnRegist.Name = "btnRegist"
        Me.btnRegist.Size = New System.Drawing.Size(75, 30)
        Me.btnRegist.TabIndex = 8
        Me.btnRegist.Text = "登録"
        Me.btnRegist.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(324, 176)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 30)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "削除"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'dayTimeBox
        '
        Me.dayTimeBox.hourText = "00"
        Me.dayTimeBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.dayTimeBox.Location = New System.Drawing.Point(186, 59)
        Me.dayTimeBox.minuteText = "00"
        Me.dayTimeBox.Name = "dayTimeBox"
        Me.dayTimeBox.Size = New System.Drawing.Size(111, 46)
        Me.dayTimeBox.TabIndex = 11
        '
        'nightTimeBox
        '
        Me.nightTimeBox.hourText = "00"
        Me.nightTimeBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.nightTimeBox.Location = New System.Drawing.Point(186, 111)
        Me.nightTimeBox.minuteText = "00"
        Me.nightTimeBox.Name = "nightTimeBox"
        Me.nightTimeBox.Size = New System.Drawing.Size(111, 46)
        Me.nightTimeBox.TabIndex = 12
        '
        'nextTimeBox
        '
        Me.nextTimeBox.hourText = "00"
        Me.nextTimeBox.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.nextTimeBox.Location = New System.Drawing.Point(186, 163)
        Me.nextTimeBox.minuteText = "00"
        Me.nextTimeBox.Name = "nextTimeBox"
        Me.nextTimeBox.Size = New System.Drawing.Size(111, 46)
        Me.nextTimeBox.TabIndex = 13
        '
        'emptyCheckDay
        '
        Me.emptyCheckDay.AutoSize = True
        Me.emptyCheckDay.Location = New System.Drawing.Point(152, 74)
        Me.emptyCheckDay.Name = "emptyCheckDay"
        Me.emptyCheckDay.Size = New System.Drawing.Size(15, 14)
        Me.emptyCheckDay.TabIndex = 14
        Me.emptyCheckDay.UseVisualStyleBackColor = True
        '
        'emptyCheckNight
        '
        Me.emptyCheckNight.AutoSize = True
        Me.emptyCheckNight.Location = New System.Drawing.Point(152, 126)
        Me.emptyCheckNight.Name = "emptyCheckNight"
        Me.emptyCheckNight.Size = New System.Drawing.Size(15, 14)
        Me.emptyCheckNight.TabIndex = 15
        Me.emptyCheckNight.UseVisualStyleBackColor = True
        '
        'emptyCheckNext
        '
        Me.emptyCheckNext.AutoSize = True
        Me.emptyCheckNext.Location = New System.Drawing.Point(152, 179)
        Me.emptyCheckNext.Name = "emptyCheckNext"
        Me.emptyCheckNext.Size = New System.Drawing.Size(15, 14)
        Me.emptyCheckNext.TabIndex = 16
        Me.emptyCheckNext.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(135, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 12)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "空チェック"
        '
        '勤務時間マスタ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 607)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.emptyCheckNext)
        Me.Controls.Add(Me.emptyCheckNight)
        Me.Controls.Add(Me.emptyCheckDay)
        Me.Controls.Add(Me.nextTimeBox)
        Me.Controls.Add(Me.nightTimeBox)
        Me.Controls.Add(Me.dayTimeBox)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnRegist)
        Me.Controls.Add(Me.dgvTimeM)
        Me.Controls.Add(Me.wNamBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "勤務時間マスタ"
        Me.Text = "勤務時間マスタ"
        CType(Me.dgvTimeM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents wNamBox As System.Windows.Forms.TextBox
    Friend WithEvents dgvTimeM As System.Windows.Forms.DataGridView
    Friend WithEvents btnRegist As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents dayTimeBox As hmBox.hmBox
    Friend WithEvents nightTimeBox As hmBox.hmBox
    Friend WithEvents nextTimeBox As hmBox.hmBox
    Friend WithEvents emptyCheckDay As System.Windows.Forms.CheckBox
    Friend WithEvents emptyCheckNight As System.Windows.Forms.CheckBox
    Friend WithEvents emptyCheckNext As System.Windows.Forms.CheckBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
