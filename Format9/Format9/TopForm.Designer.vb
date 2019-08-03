<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TopForm
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
        Me.btnFormat9 = New System.Windows.Forms.Button()
        Me.btnTimeM = New System.Windows.Forms.Button()
        Me.btnWriteExcel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFormat9
        '
        Me.btnFormat9.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnFormat9.Location = New System.Drawing.Point(30, 19)
        Me.btnFormat9.Name = "btnFormat9"
        Me.btnFormat9.Size = New System.Drawing.Size(164, 70)
        Me.btnFormat9.TabIndex = 0
        Me.btnFormat9.Text = "個人データ作成"
        Me.btnFormat9.UseVisualStyleBackColor = True
        '
        'btnTimeM
        '
        Me.btnTimeM.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnTimeM.Location = New System.Drawing.Point(30, 206)
        Me.btnTimeM.Name = "btnTimeM"
        Me.btnTimeM.Size = New System.Drawing.Size(164, 70)
        Me.btnTimeM.TabIndex = 1
        Me.btnTimeM.Text = "勤務時間マスタ"
        Me.btnTimeM.UseVisualStyleBackColor = True
        '
        'btnWriteExcel
        '
        Me.btnWriteExcel.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnWriteExcel.Location = New System.Drawing.Point(31, 113)
        Me.btnWriteExcel.Name = "btnWriteExcel"
        Me.btnWriteExcel.Size = New System.Drawing.Size(163, 70)
        Me.btnWriteExcel.TabIndex = 2
        Me.btnWriteExcel.Text = "一括でエクセルに書き込む"
        Me.btnWriteExcel.UseVisualStyleBackColor = True
        '
        'TopForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(229, 299)
        Me.Controls.Add(Me.btnWriteExcel)
        Me.Controls.Add(Me.btnTimeM)
        Me.Controls.Add(Me.btnFormat9)
        Me.Name = "TopForm"
        Me.Text = "様式9作成"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnFormat9 As System.Windows.Forms.Button
    Friend WithEvents btnTimeM As System.Windows.Forms.Button
    Friend WithEvents btnWriteExcel As System.Windows.Forms.Button

End Class
