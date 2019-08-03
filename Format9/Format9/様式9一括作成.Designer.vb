<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 様式9一括作成
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ymBox = New ymdBox.ymdBox()
        Me.rbtnNsR = New System.Windows.Forms.RadioButton()
        Me.rbtnNsI = New System.Windows.Forms.RadioButton()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "勤務年月"
        '
        'ymBox
        '
        Me.ymBox.boxType = 5
        Me.ymBox.DateText = ""
        Me.ymBox.EraLabelText = "R01"
        Me.ymBox.EraText = ""
        Me.ymBox.Location = New System.Drawing.Point(35, 55)
        Me.ymBox.MonthLabelText = "08"
        Me.ymBox.MonthText = ""
        Me.ymBox.Name = "ymBox"
        Me.ymBox.Size = New System.Drawing.Size(95, 40)
        Me.ymBox.TabIndex = 7
        Me.ymBox.textReadOnly = False
        '
        'rbtnNsR
        '
        Me.rbtnNsR.AutoSize = True
        Me.rbtnNsR.Location = New System.Drawing.Point(162, 79)
        Me.rbtnNsR.Name = "rbtnNsR"
        Me.rbtnNsR.Size = New System.Drawing.Size(71, 16)
        Me.rbtnNsR.TabIndex = 12
        Me.rbtnNsR.TabStop = True
        Me.rbtnNsR.Text = "療養病棟"
        Me.rbtnNsR.UseVisualStyleBackColor = True
        '
        'rbtnNsI
        '
        Me.rbtnNsI.AutoSize = True
        Me.rbtnNsI.Location = New System.Drawing.Point(162, 55)
        Me.rbtnNsI.Name = "rbtnNsI"
        Me.rbtnNsI.Size = New System.Drawing.Size(71, 16)
        Me.rbtnNsI.TabIndex = 11
        Me.rbtnNsI.TabStop = True
        Me.rbtnNsI.Text = "一般病棟"
        Me.rbtnNsI.UseVisualStyleBackColor = True
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(275, 55)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 40)
        Me.btnCreate.TabIndex = 13
        Me.btnCreate.Text = "作成"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        '様式9一括作成
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 140)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.rbtnNsR)
        Me.Controls.Add(Me.rbtnNsI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ymBox)
        Me.Name = "様式9一括作成"
        Me.Text = "様式9一括作成"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ymBox As ymdBox.ymdBox
    Friend WithEvents rbtnNsR As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNsI As System.Windows.Forms.RadioButton
    Friend WithEvents btnCreate As System.Windows.Forms.Button
End Class
