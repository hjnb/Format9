Public Class TopForm

    'データベースのパス
    Public dbFilePath As String = My.Application.Info.DirectoryPath & "\Format9.mdb"
    Public DB_Format9 As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbFilePath

    '.iniファイルのパス
    Public iniFilePath As String = My.Application.Info.DirectoryPath & "\Format9.ini"

    '画像パス
    'Public imageFilePath As String = My.Application.Info.DirectoryPath & "\Format9.PNG"

    'Arrangeのデータベースパス
    Public dbArrangeFilePath As String = Util.getIniString("System", "ArrangeDir", iniFilePath) & "\Arrange.mdb"
    Public DB_Arrange As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbArrangeFilePath

    'フォーム
    Private f9CreateForm As 様式9作成
    Private timeMForm As 勤務時間マスタ

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
        InitializeComponent()

        Me.StartPosition = FormStartPosition.CenterScreen
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.MaximizeBox = False
    End Sub

    ''' <summary>
    ''' loadイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub TopForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'データベース、エクセル、構成ファイルの存在チェック
        If Not System.IO.File.Exists(dbFilePath) Then
            MsgBox("Format9データベースファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If
        If Not System.IO.File.Exists(dbArrangeFilePath) Then
            MsgBox("Arrangeデータベースファイルが存在しません。" & Environment.NewLine & "iniファイルのArrangeDirに適切なパスを設定して下さい。")
            Me.Close()
            Exit Sub
        End If

        If Not System.IO.File.Exists(iniFilePath) Then
            MsgBox("構成ファイルが存在しません。ファイルを配置して下さい。")
            Me.Close()
            Exit Sub
        End If
    End Sub

    ''' <summary>
    ''' 様式9データ作成ボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnFormat9_Click(sender As System.Object, e As System.EventArgs) Handles btnFormat9.Click
        If IsNothing(f9CreateForm) OrElse f9CreateForm.IsDisposed Then
            f9CreateForm = New 様式9作成()
            f9CreateForm.Show()
        End If
    End Sub

    ''' <summary>
    ''' 勤務時間マスタボタンクリックイベント
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub btnTimeM_Click(sender As System.Object, e As System.EventArgs) Handles btnTimeM.Click
        If IsNothing(timeMForm) OrElse timeMForm.IsDisposed Then
            timeMForm = New 勤務時間マスタ()
            timeMForm.Show()
        End If
    End Sub
End Class
