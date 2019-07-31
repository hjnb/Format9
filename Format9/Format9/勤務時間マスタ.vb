Imports System.Data.OleDb

Public Class 勤務時間マスタ

    ''' <summary>
    ''' 行ヘッダーのカレントセルを表す三角マークを非表示に設定する為のクラス。
    ''' </summary>
    ''' <remarks></remarks>
    Public Class dgvRowHeaderCell

        'DataGridViewRowHeaderCell を継承
        Inherits DataGridViewRowHeaderCell

        'DataGridViewHeaderCell.Paint をオーバーライドして行ヘッダーを描画
        Protected Overrides Sub Paint(ByVal graphics As Graphics, ByVal clipBounds As Rectangle, _
           ByVal cellBounds As Rectangle, ByVal rowIndex As Integer, ByVal cellState As DataGridViewElementStates, _
           ByVal value As Object, ByVal formattedValue As Object, ByVal errorText As String, _
           ByVal cellStyle As DataGridViewCellStyle, ByVal advancedBorderStyle As DataGridViewAdvancedBorderStyle, _
           ByVal paintParts As DataGridViewPaintParts)
            '標準セルの描画からセル内容の背景だけ除いた物を描画(-5)
            MyBase.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value, _
                     formattedValue, errorText, cellStyle, advancedBorderStyle, _
                     Not DataGridViewPaintParts.ContentBackground)
        End Sub

    End Class

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.KeyPreview = True
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 勤務時間マスタ_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データグリッドビュー初期設定
        initDgvTimeM()

        'データ表示
        displayDgvTimeM()
    End Sub

    ''' <summary>
    ''' KeyDownイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub 勤務時間マスタ_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            If e.Control = False Then
                Me.SelectNextControl(Me.ActiveControl, Not e.Shift, True, True, True)
            End If
        End If
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvTimeM()
        Util.EnableDoubleBuffering(dgvTimeM)

        With dgvTimeM
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = False
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersVisible = False
            '.RowHeadersWidth = 35
            .RowTemplate.Height = 19
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = False
            .EnableHeadersVisualStyles = False
            .Font = New Font("ＭＳ Ｐゴシック", 11)
            .ReadOnly = True
        End With
    End Sub

    ''' <summary>
    ''' 入力内容クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearInput()
        wNamBox.Text = ""
        dayTimeBox.Text = ""
        nightTimeBox.Text = ""
        nextTimeBox.Text = ""
    End Sub

    ''' <summary>
    ''' マスタデータ表示
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub displayDgvTimeM()
        '内容クリア
        clearInput()
        dgvTimeM.Columns.Clear()

        'データ取得、表示
        Dim cnn As New ADODB.Connection
        cnn.Open(TopForm.DB_Format9)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select WNam, DayTime, NightTime, NextTime From TimeM"
        rs.Open(sql, cnn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "TimeM")
        Dim dt As DataTable = ds.Tables("TimeM")

        '表示
        dgvTimeM.DataSource = dt
        cnn.Close()
        If Not IsNothing(dgvTimeM.CurrentRow) Then
            dgvTimeM.CurrentRow.Selected = False
        End If

        '幅設定等
        With dgvTimeM
            With .Columns("WNam")
                .HeaderText = "勤務名称"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 85
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
            With .Columns("DayTime")
                .HeaderText = "日勤帯時間"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 85
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
            With .Columns("NightTime")
                .HeaderText = "夜間帯時間"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 85
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
            With .Columns("NextTime")
                .HeaderText = "日跨ぎ時間"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 85
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
        End With

        wNamBox.Focus()
    End Sub

    ''' <summary>
    ''' 登録ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnRegist_Click(sender As System.Object, e As System.EventArgs) Handles btnRegist.Click
        '勤務名
        Dim wNam As String = wNamBox.Text
        If wNam = "" Then
            MsgBox("勤務名称を入力下さい。", MsgBoxStyle.Exclamation)
            wNamBox.Focus()
            Return
        End If
        '日勤帯勤務時間
        Dim dayTime As String = dayTimeBox.Text
        If dayTime <> "" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(dayTime, "^\d+(\.\d+)?$") Then
            MsgBox("時間単位で適切な数値を入力して下さい。", MsgBoxStyle.Exclamation)
            dayTimeBox.Focus()
            Return
        End If
        '夜間帯勤務時間
        Dim nightTime As String = nightTimeBox.Text
        If nightTime <> "" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(nightTime, "^\d+(\.\d+)?$") Then
            MsgBox("時間単位で適切な数値を入力して下さい。", MsgBoxStyle.Exclamation)
            nightTimeBox.Focus()
            Return
        End If
        '日跨ぎ夜間勤務時間
        Dim nextTime As String = nextTimeBox.Text
        If nextTime <> "" AndAlso Not System.Text.RegularExpressions.Regex.IsMatch(nextTime, "^\d+(\.\d+)?$") Then
            MsgBox("時間単位で適切な数値を入力して下さい。", MsgBoxStyle.Exclamation)
            nextTimeBox.Focus()
            Return
        End If

        '登録
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Format9)
        Dim sql As String = "select WNam, DayTime, NightTime, NextTime from TimeM where WNam = '" & wNam & "'"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            '新規登録
            rs.AddNew()
            rs.Fields("WNam").Value = wNam
        End If
        rs.Fields("DayTime").Value = dayTime
        rs.Fields("NightTime").Value = nightTime
        rs.Fields("NextTime").Value = nextTime
        rs.Update()
        rs.Close()
        cn.Close()

        '再表示
        displayDgvTimeM()
    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click
        '勤務名
        Dim wNam As String = wNamBox.Text
        If wNam = "" Then
            MsgBox("勤務名称を入力下さい。", MsgBoxStyle.Exclamation)
            wNamBox.Focus()
            Return
        End If

        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Format9)
        Dim sql As String = "select WNam, DayTime, NightTime, NextTime from TimeM where WNam = '" & wNam & "'"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenKeyset, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount <= 0 Then
            MsgBox("登録されていません。", MsgBoxStyle.Exclamation)
            rs.Close()
            cn.Close()
            Return
        End If

        '削除
        Dim result As DialogResult = MessageBox.Show("削除してよろしいですか？", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = Windows.Forms.DialogResult.Yes Then
            rs.Delete()
            rs.Update()
            rs.Close()
            cn.Close()

            '再表示
            displayDgvTimeM()
        Else
            rs.Close()
            cn.Close()
        End If
    End Sub

    ''' <summary>
    ''' CellMouseClickイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgvTimeM_CellMouseClick(sender As Object, e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvTimeM.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim wNam As String = Util.checkDBNullValue(dgvTimeM("WNam", e.RowIndex).Value)
            Dim dayTime As String = Util.checkDBNullValue(dgvTimeM("DayTime", e.RowIndex).Value)
            Dim nightTime As String = Util.checkDBNullValue(dgvTimeM("NightTime", e.RowIndex).Value)
            Dim nextTime As String = Util.checkDBNullValue(dgvTimeM("NextTime", e.RowIndex).Value)

            'セット
            wNamBox.Text = wNam
            dayTimeBox.Text = dayTime
            nightTimeBox.Text = nightTime
            nextTimeBox.Text = nextTime
        End If
    End Sub
End Class