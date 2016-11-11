Imports System
Imports System.Collections.Generic
Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.VisualBasic.FileIO
Imports Timer = System.Windows.Forms.Timer
Imports System.Diagnostics
Imports System.IO
Imports Elegant.Ui


<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Public Class frmMain
    Inherits System.Windows.Forms.Form

#Region "COMPONENTES"


    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
    Friend WithEvents Panel1 As Elegant.Ui.Panel
    Friend WithEvents StatusBar1 As Elegant.Ui.StatusBar
    Friend WithEvents StatusBarNotificationsArea1 As Elegant.Ui.StatusBarNotificationsArea
    Friend WithEvents StatusBarPane2 As Elegant.Ui.StatusBarPane
    Friend WithEvents StatusBarControlsArea1 As Elegant.Ui.StatusBarControlsArea
    Friend WithEvents StatusBarPane1 As Elegant.Ui.StatusBarPane
    Friend WithEvents CINTA As Elegant.Ui.Ribbon
    Friend WithEvents RibbonTabPage1 As Elegant.Ui.RibbonTabPage
    Friend WithEvents RibbonGroup1 As Elegant.Ui.RibbonGroup
    Friend WithEvents BackstageView1 As Elegant.Ui.BackstageView
    Friend WithEvents BackstageViewPage1 As Elegant.Ui.BackstageViewPage

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.

    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim themeSelector As Elegant.Ui.ThemeSelector
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.formFrameSkinner = New Elegant.Ui.FormFrameSkinner()
        Me.CINTA = New Elegant.Ui.Ribbon()
        Me.BackstageView1 = New Elegant.Ui.BackstageView()
        Me.BackstageViewPage1 = New Elegant.Ui.BackstageViewPage()
        Me.RibbonTabPage1 = New Elegant.Ui.RibbonTabPage()
        Me.RibbonGroup1 = New Elegant.Ui.RibbonGroup()
        Me.Panel1 = New Elegant.Ui.Panel()
        Me.StatusBar1 = New Elegant.Ui.StatusBar()
        Me.StatusBarNotificationsArea1 = New Elegant.Ui.StatusBarNotificationsArea()
        Me.StatusBarPane2 = New Elegant.Ui.StatusBarPane()
        Me.StatusBarControlsArea1 = New Elegant.Ui.StatusBarControlsArea()
        Me.StatusBarPane1 = New Elegant.Ui.StatusBarPane()
        themeSelector = New Elegant.Ui.ThemeSelector(Me.components)
        CType(Me.CINTA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BackstageView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RibbonTabPage1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RibbonTabPage1.SuspendLayout()
        CType(Me.RibbonGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.StatusBar1.SuspendLayout()
        Me.StatusBarNotificationsArea1.SuspendLayout()
        Me.StatusBarControlsArea1.SuspendLayout()
        Me.SuspendLayout()
        '
        'formFrameSkinner
        '
        Me.formFrameSkinner.AllowGlass = False
        Me.formFrameSkinner.Form = Me
        '
        'CINTA
        '
        Me.CINTA.ApplicationButtonText = "≡ ARCHIVOS"
        Me.CINTA.BackstageView = Me.BackstageView1
        Me.CINTA.CurrentTabPage = Me.RibbonTabPage1
        Me.CINTA.Dock = System.Windows.Forms.DockStyle.Top
        Me.CINTA.Id = "22e2148a-8014-494e-a19f-7ab1ca0a1fb2"
        Me.CINTA.Location = New System.Drawing.Point(0, 0)
        Me.CINTA.Name = "CINTA"
        Me.CINTA.Size = New System.Drawing.Size(1036, 153)
        Me.CINTA.TabIndex = 1
        Me.CINTA.TabPages.AddRange(New Elegant.Ui.RibbonTabPage() {Me.RibbonTabPage1})
        Me.CINTA.Text = "Ribbon1"
        '
        'BackstageView1
        '
        Me.BackstageView1.CurrentPage = Me.BackstageViewPage1
        Me.BackstageView1.Id = "86393b95-9764-4040-8970-1087d5ffef5f"
        Me.BackstageView1.Items.AddRange(New System.Windows.Forms.Control() {Me.BackstageViewPage1})
        Me.BackstageView1.Location = New System.Drawing.Point(0, 54)
        Me.BackstageView1.Name = "BackstageView1"
        Me.BackstageView1.Size = New System.Drawing.Size(1036, 714)
        Me.BackstageView1.TabIndex = 3
        '
        'BackstageViewPage1
        '
        Me.BackstageViewPage1.Location = New System.Drawing.Point(0, 0)
        Me.BackstageViewPage1.Name = "BackstageViewPage1"
        Me.BackstageViewPage1.Padding = New System.Windows.Forms.Padding(0, 1, 2, 1)
        Me.BackstageViewPage1.Size = New System.Drawing.Size(899, 714)
        Me.BackstageViewPage1.TabIndex = 0
        Me.BackstageViewPage1.Text = "BackstageViewPage1"
        '
        'RibbonTabPage1
        '
        Me.RibbonTabPage1.Controls.Add(Me.RibbonGroup1)
        Me.RibbonTabPage1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RibbonTabPage1.KeyTip = Nothing
        Me.RibbonTabPage1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonTabPage1.Name = "RibbonTabPage1"
        Me.RibbonTabPage1.Size = New System.Drawing.Size(1036, 99)
        Me.RibbonTabPage1.TabIndex = 0
        Me.RibbonTabPage1.Text = "RibbonTabPage"
        '
        'RibbonGroup1
        '
        Me.RibbonGroup1.Location = New System.Drawing.Point(5, 5)
        Me.RibbonGroup1.Name = "RibbonGroup1"
        Me.RibbonGroup1.Size = New System.Drawing.Size(20, 89)
        Me.RibbonGroup1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.StatusBar1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 153)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1036, 615)
        Me.Panel1.TabIndex = 2
        Me.Panel1.Text = "Panel1"
        '
        'StatusBar1
        '
        Me.StatusBar1.Controls.Add(Me.StatusBarNotificationsArea1)
        Me.StatusBar1.Controls.Add(Me.StatusBarControlsArea1)
        Me.StatusBar1.ControlsArea = Me.StatusBarControlsArea1
        Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.StatusBar1.IntegrateWithForm = False
        Me.StatusBar1.Location = New System.Drawing.Point(0, 593)
        Me.StatusBar1.Name = "StatusBar1"
        Me.StatusBar1.NotificationsArea = Me.StatusBarNotificationsArea1
        Me.StatusBar1.Size = New System.Drawing.Size(1036, 22)
        Me.StatusBar1.TabIndex = 0
        Me.StatusBar1.Text = "StatusBar1"
        '
        'StatusBarNotificationsArea1
        '
        Me.StatusBarNotificationsArea1.Controls.Add(Me.StatusBarPane2)
        Me.StatusBarNotificationsArea1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.StatusBarNotificationsArea1.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarNotificationsArea1.MaximumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarNotificationsArea1.MinimumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarNotificationsArea1.Name = "StatusBarNotificationsArea1"
        Me.StatusBarNotificationsArea1.Size = New System.Drawing.Size(964, 22)
        Me.StatusBarNotificationsArea1.TabIndex = 1
        '
        'StatusBarPane2
        '
        Me.StatusBarPane2.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarPane2.MaximumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarPane2.MinimumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarPane2.Name = "StatusBarPane2"
        Me.StatusBarPane2.Size = New System.Drawing.Size(20, 22)
        Me.StatusBarPane2.TabIndex = 0
        '
        'StatusBarControlsArea1
        '
        Me.StatusBarControlsArea1.Controls.Add(Me.StatusBarPane1)
        Me.StatusBarControlsArea1.Dock = System.Windows.Forms.DockStyle.Right
        Me.StatusBarControlsArea1.Location = New System.Drawing.Point(964, 0)
        Me.StatusBarControlsArea1.MaximumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarControlsArea1.MinimumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarControlsArea1.Name = "StatusBarControlsArea1"
        Me.StatusBarControlsArea1.Size = New System.Drawing.Size(72, 22)
        Me.StatusBarControlsArea1.TabIndex = 0
        '
        'StatusBarPane1
        '
        Me.StatusBarPane1.Location = New System.Drawing.Point(0, 0)
        Me.StatusBarPane1.MaximumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarPane1.MinimumSize = New System.Drawing.Size(0, 22)
        Me.StatusBarPane1.Name = "StatusBarPane1"
        Me.StatusBarPane1.Size = New System.Drawing.Size(20, 22)
        Me.StatusBarPane1.TabIndex = 0
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Fuchsia
        Me.ClientSize = New System.Drawing.Size(1036, 768)
        Me.Controls.Add(Me.BackstageView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.CINTA)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(200, 4)
        Me.MaximizeBox = False
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "MC Elegane"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        CType(Me.CINTA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BackstageView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RibbonTabPage1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RibbonTabPage1.ResumeLayout(False)
        Me.RibbonTabPage1.PerformLayout()
        CType(Me.RibbonGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.StatusBar1.ResumeLayout(False)
        Me.StatusBar1.PerformLayout()
        Me.StatusBarNotificationsArea1.ResumeLayout(False)
        Me.StatusBarNotificationsArea1.PerformLayout()
        Me.StatusBarControlsArea1.ResumeLayout(False)
        Me.StatusBarControlsArea1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents formFrameSkinner As Elegant.Ui.FormFrameSkinner
#End Region

    Private Sub Inicio()
        _indicatorUpdateTimer = New Timer()
        _indicatorUpdateTimer.Interval = 20
        AddHandler _indicatorUpdateTimer.Tick, AddressOf IndicatorTimer_Tick
        '    formShadow = New FormFrameShadow(formFrameSkinner)
        SetStyle(ControlStyles.UserPaint, True)
        SetStyle(ControlStyles.ResizeRedraw, True)
        If SystemFonts.MenuFont.FontFamily.Name = "Segoe UI" Then Font = SystemFonts.MenuFont


    End Sub

    Protected Overrides Sub OnLoad(ByVal e As EventArgs)
        Dim arg() : arg = Environment.GetCommandLineArgs()
        Dim File As String
        Try
            Inicio()
            MyBase.OnLoad(e)
            If arg.Length > 1 Then
                File = arg(1)
                'Abre(File)
                '     If MsgBox("Desea abrir el archivo " & vbCrLf & File, vbYesNo, "Abrir Archivo") = vbYes Then Abre(File)
            End If

        Catch ex As InvalidOperationException ' WindowsFormsApplicationBase can cause the InvalidOperationException sometimes when trying to hide splash screen
            Debug.WriteLine(ex.Message)
        End Try
        _indicatorUpdateTimer.Start()

        ' formShadow.ShowShadow()
    End Sub


End Class
