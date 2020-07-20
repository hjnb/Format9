<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class 様式9作成
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
        Me.components = New System.ComponentModel.Container()
        Me.ymBox = New ymdBox.ymdBox()
        Me.namListBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rbtnNsI = New System.Windows.Forms.RadioButton()
        Me.btnCopy = New System.Windows.Forms.Button()
        Me.rbtnNsR = New System.Windows.Forms.RadioButton()
        Me.btnSasaki = New System.Windows.Forms.Button()
        Me.btnMaruyama = New System.Windows.Forms.Button()
        Me.dgvF9 = New Format9.ExDataGridView(Me.components)
        CType(Me.dgvF9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ymBox
        '
        Me.ymBox.boxType = 5
        Me.ymBox.DateText = ""
        Me.ymBox.EraLabelText = "R02"
        Me.ymBox.EraText = ""
        Me.ymBox.Location = New System.Drawing.Point(23, 46)
        Me.ymBox.MonthLabelText = "07"
        Me.ymBox.MonthText = ""
        Me.ymBox.Name = "ymBox"
        Me.ymBox.Size = New System.Drawing.Size(95, 40)
        Me.ymBox.TabIndex = 1
        Me.ymBox.textReadOnly = False
        '
        'namListBox
        '
        Me.namListBox.FormattingEnabled = True
        Me.namListBox.ItemHeight = 12
        Me.namListBox.Location = New System.Drawing.Point(146, 49)
        Me.namListBox.Name = "namListBox"
        Me.namListBox.Size = New System.Drawing.Size(110, 88)
        Me.namListBox.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 12)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "勤務年月"
        '
        'rbtnNsI
        '
        Me.rbtnNsI.AutoSize = True
        Me.rbtnNsI.Location = New System.Drawing.Point(146, 6)
        Me.rbtnNsI.Name = "rbtnNsI"
        Me.rbtnNsI.Size = New System.Drawing.Size(47, 16)
        Me.rbtnNsI.TabIndex = 7
        Me.rbtnNsI.TabStop = True
        Me.rbtnNsI.Text = "一般"
        Me.rbtnNsI.UseVisualStyleBackColor = True
        '
        'btnCopy
        '
        Me.btnCopy.Location = New System.Drawing.Point(284, 88)
        Me.btnCopy.Name = "btnCopy"
        Me.btnCopy.Size = New System.Drawing.Size(109, 46)
        Me.btnCopy.TabIndex = 9
        Me.btnCopy.Text = "全コピー"
        Me.btnCopy.UseVisualStyleBackColor = True
        '
        'rbtnNsR
        '
        Me.rbtnNsR.AutoSize = True
        Me.rbtnNsR.Location = New System.Drawing.Point(146, 28)
        Me.rbtnNsR.Name = "rbtnNsR"
        Me.rbtnNsR.Size = New System.Drawing.Size(47, 16)
        Me.rbtnNsR.TabIndex = 10
        Me.rbtnNsR.TabStop = True
        Me.rbtnNsR.Text = "療養"
        Me.rbtnNsR.UseVisualStyleBackColor = True
        '
        'btnSasaki
        '
        Me.btnSasaki.Location = New System.Drawing.Point(507, 46)
        Me.btnSasaki.Name = "btnSasaki"
        Me.btnSasaki.Size = New System.Drawing.Size(105, 47)
        Me.btnSasaki.TabIndex = 11
        Me.btnSasaki.Text = "総師長　変換"
        Me.btnSasaki.UseVisualStyleBackColor = True
        '
        'btnMaruyama
        '
        Me.btnMaruyama.Location = New System.Drawing.Point(638, 46)
        Me.btnMaruyama.Name = "btnMaruyama"
        Me.btnMaruyama.Size = New System.Drawing.Size(105, 47)
        Me.btnMaruyama.TabIndex = 12
        Me.btnMaruyama.Text = "丸山師長　変換"
        Me.btnMaruyama.UseVisualStyleBackColor = True
        '
        'dgvF9
        '
        Me.dgvF9.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvF9.Location = New System.Drawing.Point(23, 147)
        Me.dgvF9.Name = "dgvF9"
        Me.dgvF9.RowTemplate.Height = 21
        Me.dgvF9.Size = New System.Drawing.Size(1460, 63)
        Me.dgvF9.TabIndex = 0
        '
        '様式9作成
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1508, 227)
        Me.Controls.Add(Me.btnMaruyama)
        Me.Controls.Add(Me.btnSasaki)
        Me.Controls.Add(Me.rbtnNsR)
        Me.Controls.Add(Me.btnCopy)
        Me.Controls.Add(Me.rbtnNsI)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.namListBox)
        Me.Controls.Add(Me.ymBox)
        Me.Controls.Add(Me.dgvF9)
        Me.Name = "様式9作成"
        Me.Text = "様式9作成"
        CType(Me.dgvF9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvF9 As Format9.ExDataGridView
    Friend WithEvents ymBox As ymdBox.ymdBox
    Friend WithEvents namListBox As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rbtnNsI As System.Windows.Forms.RadioButton
    Friend WithEvents btnCopy As System.Windows.Forms.Button
    Friend WithEvents rbtnNsR As System.Windows.Forms.RadioButton
    Friend WithEvents btnSasaki As System.Windows.Forms.Button
    Friend WithEvents btnMaruyama As System.Windows.Forms.Button
End Class
