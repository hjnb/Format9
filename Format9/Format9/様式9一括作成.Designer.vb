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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.btnCreate.Location = New System.Drawing.Point(271, 55)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(79, 40)
        Me.btnCreate.TabIndex = 13
        Me.btnCreate.Text = "作成"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("MS UI Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Red
        Me.GroupBox1.Location = New System.Drawing.Point(41, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(309, 156)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "作成前に確認して下さい"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(17, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(289, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "・ シート名 : yyyy.m のシートを用意して下さい（例 : 2019.6）"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(17, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(195, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "・ 勤務者の氏名を入力しておいて下さい"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(26, 85)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 12)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "（氏名が一致する勤務データで作成する為）"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(17, 110)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(227, 12)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "・ 勤務時間入力セルは空白にしておいて下さい"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(26, 124)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(267, 12)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "（計算式が設定されてるセル(総夜勤の行)はそのままで）"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(26, 44)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(205, 12)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "（既存のシートをコピーして作成して下さい）"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Red
        Me.GroupBox2.Location = New System.Drawing.Point(41, 311)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(309, 236)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "作成後に確認して下さい"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(17, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(238, 12)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "・ 日付行、曜日行は手動で正しく入力して下さい"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(17, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(224, 12)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "・ 勤務データがあるのに空白になってしまう場合"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Blue
        Me.Label10.Location = New System.Drawing.Point(28, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(234, 12)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "→ 氏名の漢字は正しいですか？確認して下さい"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Blue
        Me.Label11.Location = New System.Drawing.Point(28, 195)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(258, 12)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "→ 個人データ作成の画面で作成してコピペして下さい"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Blue
        Me.Label12.Location = New System.Drawing.Point(17, 136)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(274, 12)
        Me.Label12.TabIndex = 5
        Me.Label12.Text = "・ 種別、雇用勤務形態等は手動で正しく入力して下さい"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label13.Location = New System.Drawing.Point(17, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(208, 16)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "・ 総師長、丸山師長のデータは"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label14.Location = New System.Drawing.Point(30, 48)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(256, 16)
        Me.Label14.TabIndex = 7
        Me.Label14.Text = "個人用データ作成してコピペで上書きで"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("MS UI Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.DarkViolet
        Me.Label15.Location = New System.Drawing.Point(72, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(141, 16)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "（そのうち対応します）"
        '
        '様式9一括作成
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 571)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCreate)
        Me.Controls.Add(Me.rbtnNsR)
        Me.Controls.Add(Me.rbtnNsI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ymBox)
        Me.Name = "様式9一括作成"
        Me.Text = "様式9一括作成"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ymBox As ymdBox.ymdBox
    Friend WithEvents rbtnNsR As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnNsI As System.Windows.Forms.RadioButton
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
