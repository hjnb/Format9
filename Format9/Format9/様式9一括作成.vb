Imports Microsoft.Office.Interop
Imports System.Runtime.InteropServices
Imports System.Data.OleDb

Public Class 様式9一括作成

    '勤務名対応時間テーブル
    Private workTimeTable As DataTable

    '変換対象勤務名リスト
    Private workNameList As List(Of String)

    'エクセルの氏名列のアルファベット
    Private Const NAME_COLUMN_CHAR As String = "I"

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
    Private Sub 様式9一括作成_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        '初期設定は一般病棟にチェック
        rbtnNsI.Checked = True

        '勤務名対応時間読み込み
        loadWorkTime()
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
    ''' 作成ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnCreate_Click(sender As System.Object, e As System.EventArgs) Handles btnCreate.Click
        '当月、当月の日数
        Dim ym As String = ymBox.getADStr4Ym()
        Dim daysInMonth As Integer = DateTime.DaysInMonth(CInt(ym.Split("/")(0)), CInt(ym.Split("/")(1)))
        '先月、先月の日数
        Dim prevYm As String = New DateTime(CInt(ym.Split("/")(0)), CInt(ym.Split("/")(1)), 1).AddMonths(-1).ToString("yyyy/MM")
        Dim daysInPrevMonth As Integer = DateTime.DaysInMonth(CInt(prevYm.Split("/")(0)), CInt(prevYm.Split("/")(1)))

        '種別
        Dim hyo As String = If(rbtnNsI.Checked, "一般病棟", "療養病棟")

        '当月勤務データ取得
        Dim workDataDic As New Dictionary(Of String, String(,))
        Dim cn As New ADODB.Connection()
        cn.Open(TopForm.DB_Arrange)
        Dim sql As String = "select * from KHyo where Ym = '" & ym & "' and Hyo = '" & hyo & "' order by Seq"
        Dim rs As New ADODB.Recordset
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            Dim workData(1, 30) As String
            For i As Integer = 1 To 31
                Dim work As String = Util.checkDBNullValue(rs.Fields("H" & i).Value)
                workData(0, i - 1) = work
            Next
            Dim nam As String = Util.checkDBNullValue(rs.Fields("Nam").Value)

            workDataDic.Add(nam, workData.Clone())
            rs.MoveNext()
        End While
        rs.Close()

        '先月最終日勤務データで準夜の人の当月データ初日の夜間帯時間に0.5を設定
        sql = "select * from KHyo where Ym = '" & prevYm & "' and Hyo = '" & hyo & "' order by Seq"
        rs.Open(sql, cn, ADODB.CursorTypeEnum.adOpenForwardOnly, ADODB.LockTypeEnum.adLockOptimistic)
        While Not rs.EOF
            Dim nam As String = Util.checkDBNullValue(rs.Fields("Nam").Value)
            Dim lastWork As String = Util.checkDBNullValue(rs.Fields("H" & daysInPrevMonth).Value)
            If lastWork = "準夜" Then
                If workDataDic.ContainsKey(nam) Then
                    Dim workData(,) As String = workDataDic(nam)
                    workData(1, 0) = "0.50"
                    workDataDic(nam) = workData
                End If
            End If
            rs.MoveNext()
        End While
        rs.Close()
        cn.Close()

        '勤務名→勤務時間変換
        Dim keys(workDataDic.Keys.Count - 1) As String
        workDataDic.Keys.CopyTo(keys, 0)
        For Each key As String In keys
            Dim workData(,) As String = workDataDic(key)
            For i As Integer = 0 To daysInMonth - 1
                Dim work As String = workData(0, i) '勤務名
                If workNameList.IndexOf(work) < 0 Then
                    workData(0, i) = ""
                    Continue For
                End If
                Dim dayTime As String = workTimeTable.Select("WNam = '" & work & "'")(0).Item("DayTime")
                Dim nightTime As String = workTimeTable.Select("WNam = '" & work & "'")(0).Item("NightTime")
                Dim nextTime As String = workTimeTable.Select("WNam = '" & work & "'")(0).Item("NextTime")
                '日勤帯時間
                workData(0, i) = If(dayTime = "0", "", dayTime)
                '夜間帯時間
                Dim existsTime As String = If(workData(1, i) = "", 0, workData(1, i)) '既に入力されている時間
                Dim et As Decimal = CDec(existsTime)
                Dim nt As Decimal = CDec(nightTime)
                Dim total As Decimal = et + nt
                workData(1, i) = If(total > 0, total.ToString("0.00"), "")
                '日跨ぎ時間
                If i < daysInMonth - 1 AndAlso work = "準夜" Then
                    workData(1, i + 1) = nextTime
                End If
            Next

            '変換したデータを代入
            workDataDic(key) = workData
        Next

        '書き込みエクセルファイル選択
        Dim excelFilePath As String = ""
        Dim ofd As New OpenFileDialog()
        ofd.FileName = ""
        ofd.InitialDirectory = ""
        ofd.Filter = "エクセルファイル(*.xls)|"
        ofd.FilterIndex = 1
        ofd.Title = "ファイルを選択してください"
        ofd.RestoreDirectory = True
        If ofd.ShowDialog() = DialogResult.OK Then
            excelFilePath = ofd.FileName
        Else
            Return
        End If

        '選んだファイルの拡張子を確認
        Dim ext As String = excelFilePath.Substring(excelFilePath.LastIndexOf(".") + 1)
        If Not (ext = "xls" OrElse ext = "xlsx") Then
            MsgBox("エクセルファイルを選択して下さい。", MsgBoxStyle.Exclamation)
            Return
        End If

        'シート名
        Dim sheetName As String = CInt(ym.Split("/")(0)) & "." & CInt(ym.Split("/")(1))

        'エクセル準備
        Dim objExcel As Excel.Application = CreateObject("Excel.Application")
        Dim objWorkBooks As Excel.Workbooks = objExcel.Workbooks
        Dim objWorkBook As Excel.Workbook = objWorkBooks.Open(excelFilePath)
        If Not sheetExists(sheetName, objWorkBook) Then
            MsgBox("シート: " & sheetName & " が存在しません。", MsgBoxStyle.Exclamation)
            objExcel.Quit()
            Marshal.ReleaseComObject(objWorkBook)
            Marshal.ReleaseComObject(objExcel)
            objWorkBook = Nothing
            objExcel = Nothing
            Return
        End If
        Dim oSheet As Excel.Worksheet = objWorkBook.Worksheets(sheetName)
        objExcel.Calculation = Excel.XlCalculation.xlCalculationManual
        objExcel.ScreenUpdating = False

        'シートに書き込み処理(とりあえず1000行目まで氏名探すかんじで)
        For i As Integer = 1 To 1000
            Dim nam As String = If(IsNothing(oSheet.Range(NAME_COLUMN_CHAR & i).Value), "", oSheet.Range(NAME_COLUMN_CHAR & i).Value)
            If workDataDic.ContainsKey(nam) Then
                oSheet.Range("AD" & i, "BH" & (i + 1)).Value = workDataDic(nam)
                '文字列として貼り付けられるので、それをもう一度繰り返すことでいいかんじに数値としてなって色々計算してくれるかんじに
                oSheet.Range("AD" & i, "BH" & (i + 1)).Value = oSheet.Range("AD" & i, "BH" & (i + 1)).Value
            End If
        Next

        objExcel.Calculation = Excel.XlCalculation.xlCalculationAutomatic
        objExcel.ScreenUpdating = True

        '保存
        objWorkBook.Save()

        ' EXCEL解放
        objExcel.Quit()
        Marshal.ReleaseComObject(objWorkBook)
        Marshal.ReleaseComObject(objExcel)
        oSheet = Nothing
        objWorkBook = Nothing
        objExcel = Nothing

        MsgBox(sheetName & "シートへの書き込みが完了しました。", MsgBoxStyle.Information)
    End Sub

    ''' <summary>
    ''' シート存在チェック
    ''' </summary>
    ''' <param name="sheetName">シート名</param>
    ''' <param name="wb">workBook</param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function sheetExists(sheetName As String, wb As Excel.Workbook)
        Dim s As Excel.Worksheet
        On Error Resume Next
        s = wb.Sheets(SheetName)
        On Error GoTo 0
        Return Not s Is Nothing
    End Function
End Class