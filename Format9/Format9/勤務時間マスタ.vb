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
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
            .DefaultCellStyle.BackColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.ForeColor = Color.Black
            .DefaultCellStyle.SelectionBackColor = Color.FromKnownColor(KnownColor.Control)
            .DefaultCellStyle.SelectionForeColor = Color.Black
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersWidth = 35
            .RowTemplate.Height = 18
            .RowTemplate.HeaderCell = New dgvRowHeaderCell() '行ヘッダの三角マークを非表示に
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = False
            .EnableHeadersVisualStyles = False
            .Font = New Font("ＭＳ Ｐゴシック", 10)
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

        '幅設定等
        With dgvTimeM
            With .Columns("WNam")
                .HeaderText = "勤務名称"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
            With .Columns("DayTime")
                .HeaderText = "日勤帯時間"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
            With .Columns("NightTime")
                .HeaderText = "夜間帯時間"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
            With .Columns("NextTime")
                .HeaderText = "日跨ぎ時間"
                .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .SortMode = DataGridViewColumnSortMode.NotSortable
                .Width = 80
                .HeaderCell.Style.Font = New Font("ＭＳ Ｐゴシック", 9)
            End With
        End With

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
        Dim dayTime As String = If(emptyCheckDay.Checked, "", dayTimeBox.getTime())
        '夜間帯勤務時間
        Dim nightTime As String = If(emptyCheckNight.Checked, "", nightTimeBox.getTime())
        '日跨ぎ夜間勤務時間
        Dim nextTime As String = If(emptyCheckNext.Checked, "", nextTimeBox.getTime())

        '登録


    End Sub

    ''' <summary>
    ''' 削除ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnDelete_Click(sender As System.Object, e As System.EventArgs) Handles btnDelete.Click

    End Sub

    ''' <summary>
    ''' 空チェック値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub emptyCheck_CheckedChanged(sender As Object, e As System.EventArgs) Handles emptyCheckDay.CheckedChanged, emptyCheckNight.CheckedChanged, emptyCheckNext.CheckedChanged

    End Sub
End Class