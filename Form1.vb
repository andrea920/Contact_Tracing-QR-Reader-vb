﻿Imports System.IO
Imports AForge.Video
Imports AForge.Video.DirectShow
Imports ZXing
Public Class Form1
    Dim CamCapture As VideoCaptureDevice
    Dim BM As Bitmap
    Dim ChooseCam As FilterInfoCollection
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Using Entry As StreamWriter = New StreamWriter(Application.StartupPath & "\PeopleEntry\" + tbxName.Text & " " + "Record.txt")
            MessageBox.Show("Data Recorded!")

            Entry.WriteLine(lblName.Text & " " + tbxName.Text)
            Entry.WriteLine(lblAddress.Text & " " + tbxAddress.Text)
            Entry.WriteLine(lblCnum.Text & " " + tbxCnum.Text)
            Entry.WriteLine(lblTemp.Text & " " + tbxTemp.Text)


            If radMale.Checked = True Then
                Entry.WriteLine(vbCrLf & gbxGender.Text + " " + radMale.Text & vbCrLf)
            Else
                Entry.WriteLine(vbCrLf & gbxGender.Text + " " + radFemale.Text & vbCrLf)
            End If

            If rad1dose.Checked = True Then
                Entry.WriteLine(gbxVacc.Text + " " + rad1dose.Text & vbCrLf)
            ElseIf rad2dose.Checked = True Then
                Entry.WriteLine(gbxVacc.Text + " " + rad2dose.Text & vbCrLf)
            ElseIf radBooster.Checked = True Then
                Entry.WriteLine(gbxVacc.Text + " " + radBooster.Text & vbCrLf)
            ElseIf rad2booster.Checked = True Then
                Entry.WriteLine(gbxVacc.Text + " " + rad2booster.Text & vbCrLf)
            Else
                Entry.WriteLine(vbCrLf & gbxVacc.Text + " " + radNotyet.Text & vbCrLf)
            End If


            Entry.WriteLine(gbxQuestion.Text)
            If cbxFever.Checked = True Then
                Entry.WriteLine(cbxFever.Text)
            End If
            If cbxCoughs.Checked = True Then
                Entry.WriteLine(cbxCoughs.Text)
            End If
            If cbxBreathComp.Checked = True Then
                Entry.WriteLine(cbxBreathComp.Text)
            End If
            If cbxSorethroat.Checked = True Then
                Entry.WriteLine(cbxSorethroat.Text)
            End If
            If cbxColds.Checked = True Then
                Entry.WriteLine(cbxColds.Text)
            ElseIf cbxIdont.Checked Then
                Entry.WriteLine(cbxIdont.Text)
            End If
            Entry.Close()
        End Using
        radMale.Checked = False
        radFemale.Checked = False
        rad1dose.Checked = False
        rad2dose.Checked = False
        radBooster.Checked = False
        rad2booster.Checked = False
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        Dim ViewData As String
        ViewData = My.Computer.FileSystem.ReadAllText(tbxFind.Text)
        Dim ViewFile As String = ViewData
        tbxDisplay.Text = ViewFile
    End Sub

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click
        Dim GetPath As OpenFileDialog = New OpenFileDialog()

        If GetPath.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Dim DataRecord As String = GetPath.FileName
            tbxFind.Text = DataRecord
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChooseCam = New FilterInfoCollection(FilterCategory.VideoInputDevice)

        For Each filterInfo As FilterInfo In ChooseCam
            cbCamDevice.Items.Add(filterInfo.Name)
        Next

        cbCamDevice.SelectedIndex = 0
    End Sub

    Private Sub btnQRScan_Click(sender As Object, e As EventArgs) Handles btnQRScan.Click
        CamCapture = New VideoCaptureDevice(ChooseCam(cbCamDevice.SelectedIndex).MonikerString)
        AddHandler CamCapture.NewFrame, New NewFrameEventHandler(AddressOf CamDevice_NewFrame)
        CamCapture.Start()
        TimeScanner.Start()
    End Sub

    Private Sub CamDevice_NewFrame(sender As Object, EventArgs As NewFrameEventArgs)
        BM = DirectCast(EventArgs.Frame.Clone(), Bitmap)
        pictBxQRCapture.Image = DirectCast(EventArgs.Frame.Clone(), Bitmap)
    End Sub

    Private Sub TimeScanner_Tick(sender As Object, e As EventArgs) Handles TimeScanner.Tick
        Dim CamReader As BarcodeReader = New BarcodeReader()
        Dim CamResult As Result = CamReader.Decode(DirectCast(pictBxQRCapture.Image, Bitmap))
        If pictBxQRCapture.Image IsNot Nothing Then
            If CamResult IsNot Nothing Then
                tbxName.Text = ToString()
                'TimeScanner.Stop()
            End If
        End If
    End Sub




End Class
