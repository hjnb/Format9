Imports System.Data.OleDb

Public Class 様式9作成

    '勤務名対応時間テーブル
    Private workTimeTable As DataTable

    '変換対象勤務名リスト
    Private workNameList As List(Of String)

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
    Private Sub 様式9作成_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データグリッドビュー初期設定
        initDgvF9()

        '氏名リスト初期設定
        initNamList()

        '勤務時間テーブル読み込み
        loadWorkTime()

        '初期は看護師にセット
        rbtnNsI.Checked = True
    End Sub

    ''' <summary>
    ''' 勤務名対応時間読み込み
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub loadWorkTime()
        '勤務名対応時間テーブル作成
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Format9)
        Dim rs As New ADODB.Recordset
        Dim sql As String = "select WNam, DayTime, NightTime, NextTime from TimeM"
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockReadOnly)
        Dim da As OleDbDataAdapter = New OleDbDataAdapter()
        Dim ds As DataSet = New DataSet()
        da.Fill(ds, rs, "TimeM")
        workTimeTable = ds.Tables("TimeM")
        cn.Close()

        '変換対象勤務名リスト作成
        workNameList = New List(Of String)
        For Each row As DataRow In workTimeTable.Rows
            workNameList.Add(row("WNam"))
        Next
    End Sub

    ''' <summary>
    ''' 氏名リスト初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initNamList()
        Dim ym As String = ymBox.getADStr4Ym() '設定年月(yyyy/MM)
        Dim syu As String = ""
        Dim hyo As String = ""
        If rbtnNsI.Checked Then
            syu = "看"
            hyo = "一般病棟"
        ElseIf rbtnNsR.Checked Then
            syu = "看"
            hyo = "療養病棟"
        Else
            syu = "助"
            hyo = "病棟"
        End If

        namListBox.Items.Clear()
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Arrange)
        Dim sql As String = "SELECT Nam FROM KHyo where Ym = '" & ym & "' and Hyo Like '%" & hyo & "' and Syu Like '%" & syu & "' order by Seq"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            Dim txt As String = Util.checkDBNullValue(rs.Fields("Nam").Value)
            namListBox.Items.Add(txt)
            rs.MoveNext()
        End While
        rs.Close()
        cn.Close()
    End Sub

    ''' <summary>
    ''' 年月ボックス値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub ymBox_YmLabelTextChange(sender As Object, e As System.EventArgs) Handles ymBox.YmLabelTextChange
        '氏名リスト更新
        initNamList()

        'データグリッドビュー内容クリア
        clearDgv()
    End Sub

    ''' <summary>
    ''' 種別ラジオボタン値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub rbtn_CheckedChanged(sender As Object, e As System.EventArgs) Handles rbtnHp.CheckedChanged, rbtnNsI.CheckedChanged, rbtnNsR.CheckedChanged
        If DirectCast(sender, RadioButton).Checked Then
            initNamList()
            clearDgv()
        End If
    End Sub

    ''' <summary>
    ''' データグリッドビュー初期設定
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub initDgvF9()
        Util.EnableDoubleBuffering(dgvF9)

        With dgvF9
            .AllowUserToAddRows = False '行追加禁止
            .AllowUserToResizeColumns = False '列の幅をユーザーが変更できないようにする
            .AllowUserToResizeRows = False '行の高さをユーザーが変更できないようにする
            .AllowUserToDeleteRows = False '行削除禁止
            .BorderStyle = BorderStyle.FixedSingle
            .MultiSelect = True
            .SelectionMode = DataGridViewSelectionMode.CellSelect
            .RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing
            .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .RowHeadersVisible = False
            .RowTemplate.Height = 19
            .BackgroundColor = Color.FromKnownColor(KnownColor.Control)
            .ShowCellToolTips = False
            .EnableHeadersVisualStyles = False
            .Font = New Font("ＭＳ Ｐゴシック", 10)
            .ReadOnly = True
            .ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableWithoutHeaderText
        End With

        Dim dt As New DataTable()
        For i As Integer = 1 To 31
            dt.Columns.Add("Day" & i, GetType(String))
        Next
        For i As Integer = 0 To 1
            dt.Rows.Add(dt.NewRow())
        Next
        dgvF9.DataSource = dt

        If Not IsNothing(dgvF9.CurrentCell) Then
            dgvF9.CurrentCell.Selected = False
        End If

        '幅設定等
        With dgvF9
            For i As Integer = 1 To 31
                With .Columns("Day" & i)
                    .HeaderText = i
                    .DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                    .Width = 47
                    .SortMode = DataGridViewColumnSortMode.NotSortable
                End With
            Next
        End With

    End Sub

    ''' <summary>
    ''' データグリッドビュー内容クリア
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub clearDgv()
        For i As Integer = 0 To 1
            For j As Integer = 1 To 31
                dgvF9("Day" & j, i).Value = ""
            Next
        Next
        dgvF9.ClearSelection()
    End Sub

    ''' <summary>
    ''' 勤務データ表示
    ''' </summary>
    ''' <param name="ym">年月(yyyy/MM)</param>
    ''' <param name="nam">氏名</param>
    ''' <remarks></remarks>
    Private Sub displayDgvF9(ym As String, nam As String)
        '内容クリア
        clearDgv()

        '選択解除
        If Not IsNothing(dgvF9.CurrentCell) Then
            dgvF9.CurrentCell.Selected = False
        End If

        '当月勤務データ取得
        Dim workData(30) As String '勤務名保持用
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Arrange)
        Dim sql As String = "select * from KHyo where Ym = '" & ym & "' and Nam = '" & nam & "'"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            For i As Integer = 1 To 31
                Dim work As String = Util.checkDBNullValue(rs.Fields("H" & i).Value)
                workData(i - 1) = work
            Next
            rs.MoveNext()
        End While
        rs.Close()

        '先月勤務データの最後の勤務
        Dim prevLastWork As String = "" '先月の最終日の勤務
        Dim prevYm As String = New DateTime(CInt(ym.Split("/")(0)), CInt(ym.Split("/")(1)), 1).AddMonths(-1).ToString("yyyy/MM")
        Dim lastDay As Integer = DateTime.DaysInMonth(CInt(prevYm.Split("/")(0)), CInt(prevYm.Split("/")(1)))
        sql = "select * from KHyo where Ym = '" & prevYm & "' and Nam = '" & nam & "'"
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            prevLastWork = Util.checkDBNullValue(rs.Fields("H" & lastDay).Value)
            rs.MoveNext()
        End While
        rs.Close()
        cn.Close()
        If prevLastWork = "準夜" Then
            dgvF9("Day1", 1).Value = "0.50"
        End If

        '勤務名 → 勤務時間 変換処理
        For i As Integer = 1 To 31
            Dim work As String = workData(i - 1)
            If workNameList.IndexOf(work) < 0 Then
                dgvF9("Day" & i, 0).Value = ""
                Continue For
            End If
            Dim dayTime As String = workTimeTable.Select("WNam = '" & work & "'")(0).Item("DayTime")
            Dim nightTime As String = workTimeTable.Select("WNam = '" & work & "'")(0).Item("NightTime")
            Dim nextTime As String = workTimeTable.Select("WNam = '" & work & "'")(0).Item("NextTime")

            '日勤帯時間
            dgvF9("Day" & i, 0).Value = If(dayTime = "0", "", dayTime)
            '夜間帯時間
            Dim existsTime As String = If(Util.checkDBNullValue(dgvF9("Day" & i, 1).Value) = "", 0, dgvF9("Day" & i, 1).Value) '既に入力されている時間
            Dim et As Decimal = CDec(existsTime)
            Dim nt As Decimal = CDec(nightTime)
            Dim total As Decimal = et + nt
            dgvF9("Day" & i, 1).Value = If(total > 0, total.ToString("0.00"), "")
            '日跨ぎ時間
            If i <> 31 AndAlso work = "準夜" Then
                dgvF9("Day" & (i + 1), 1).Value = nextTime
            End If
        Next

    End Sub

    ''' <summary>
    ''' コピーボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCopy_Click(sender As System.Object, e As System.EventArgs) Handles btnCopy.Click
        '全選択
        dgvF9.SelectAll()

        '選択内容コピー
        Clipboard.SetDataObject(dgvF9.GetClipboardContent())

        '選択解除
        dgvF9.ClearSelection()
    End Sub

    ''' <summary>
    ''' 氏名リスト値変更イベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub namListBox_SelectedValueChanged(sender As Object, e As System.EventArgs) Handles namListBox.SelectedValueChanged
        displayDgvF9(ymBox.getADStr4Ym(), namListBox.Text)
    End Sub

    ''' <summary>
    ''' 総師長変換ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnSasaki_Click(sender As System.Object, e As System.EventArgs) Handles btnSasaki.Click
        For i As Integer = 1 To 31
            Dim dayTime As String = Util.checkDBNullValue(dgvF9("Day" & i, 0).Value)
            If dayTime = "8.00" Then
                dgvF9("Day" & i, 1).Value = ""
            End If
        Next
    End Sub

    ''' <summary>
    ''' 丸山市長変換ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnMaruyama_Click(sender As System.Object, e As System.EventArgs) Handles btnMaruyama.Click
        For i As Integer = 1 To 31
            Dim dayTime As String = Util.checkDBNullValue(dgvF9("Day" & i, 0).Value)
            If dayTime = "8.00" Then
                dgvF9("Day" & i, 0).Value = "6.50"
            End If
        Next
    End Sub
End Class